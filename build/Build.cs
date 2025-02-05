using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.Git;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.PathConstruction;

// [GitHubActions(
//     "MakeAllCi",
//     GitHubActionsImage.UbuntuLatest,
//     On = [GitHubActionsTrigger.Push],
//     InvokedTargets = [nameof(MakeAllCi)])]
class Build : NukeBuild
{
    public Build()
    {
        // ToolPathResolver.GetPathExecutable() = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
    
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    public static int Main() => Execute<Build>(x => x.Compile);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution] readonly Solution Solution;
    [Solution("dependencies/kiota/kiota.sln")] readonly Solution SolutionKiota;

    AbsolutePath DependenciesDirectory => RootDirectory / "dependencies";
    AbsolutePath DependenciesKiotaDirectory => DependenciesDirectory / "kiota";
    AbsolutePath KiotaJsonGenerator => RootDirectory / "src" / "KiotaTasks.Generator" / "bin" / Configuration / "net8.0" / "KiotaTasks.Generator";
    AbsolutePath KiotaJsonSourcePath => RootDirectory / "src" / "KiotaTasks.Generator" / "bin" / Configuration / "net8.0" / "Kiota.json";
    AbsolutePath KiotaJsonTargetPath => RootDirectory / "src" / "MLgentDev.Nuke.Kiota" / "Kiota.json";
    AbsolutePath ProjectForPublishing => RootDirectory / "src" / "MLgentDev.Nuke.Kiota" / "MLgentDev.Nuke.Kiota.csproj";

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            DotNetTasks.DotNetClean(_ => _
                .SetProject(Solution)
                .SetConfiguration(Configuration)
                .SetVerbosity(DotNetVerbosity.quiet));
        });

    Target Restore => _ => _
        .Executes(() =>
        {
            DotNetTasks.DotNetRestore(_ => _
                .SetProjectFile(Solution)
                .SetVerbosity(DotNetVerbosity.quiet));
        });

    Target Compile => _ => _
        .After(CloneKiota, CompileKiota)
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetTasks.DotNetBuild(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoRestore()
                .SetVerbosity(DotNetVerbosity.quiet));
        });

    Target CloneKiota => _ => _.Executes(() =>
    {
        if (Directory.Exists(DependenciesKiotaDirectory))
        {
            Directory.Delete(DependenciesKiotaDirectory, true);
        }
        GitTasks.Git("clone https://github.com/microsoft/kiota.git", workingDirectory: DependenciesDirectory);
    });

    Target CompileKiota => _ => _
        .After(CloneKiota)
        .Executes(() =>
    {
        DotNetTasks.DotNetBuild(_ => _
            .SetProjectFile(SolutionKiota)
            .SetConfiguration(Configuration.Debug)
            .SetVerbosity(DotNetVerbosity.quiet));
    });

    Target GenerateKiotaToolManifest => _ => _
        .After(Compile)
        .Executes(() =>
    {
        ProcessTasks.StartProcess(KiotaJsonGenerator, "", workingDirectory: KiotaJsonGenerator.Parent).WaitForExit();
        File.Copy(KiotaJsonSourcePath, KiotaJsonTargetPath, overwrite: true);
    });

    Target GenerateKiotaCode => _ => _
        .After(Compile)
        .DependsOn(GenerateKiotaToolManifest)
        .Executes(() =>
    {
        Nuke.CodeGeneration.CodeGenerator.GenerateCode(
            KiotaJsonTargetPath,
            tool => KiotaJsonTargetPath.Parent / (Path.GetFileNameWithoutExtension(tool.SpecificationFile) + ".Generated.cs"),
            tool => $"MLgentDev.Nuke.Common.Tools.Kiota",
            tool => Path.GetFileName(tool.SpecificationFile));
    });

    Target CompileAfterGenerate => _ => _
        .After(CloneKiota, CompileKiota)
        .After(GenerateKiotaToolManifest, GenerateKiotaCode)
        .Executes(() =>
        {
            DotNetTasks.DotNetBuild(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoRestore()
                .SetVerbosity(DotNetVerbosity.quiet));
        });


    Target Test => _ => _
        .After(Compile, CompileAfterGenerate)
        .Executes(() =>
        {
            DotNetTasks.DotNetTest(_ => _
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .SetVerbosity(DotNetVerbosity.quiet));
        });
    
    Target Publish => _ => _
        .After(Compile)
        .After(GenerateKiotaCode)
        .After(CompileAfterGenerate)
        .After(Test)
        .Executes(() =>
        {
            DotNetTasks.DotNetPublish(_ => _
                .SetProject(ProjectForPublishing)
                .SetConfiguration(Configuration.Release)
                .SetVerbosity(DotNetVerbosity.quiet));
            DotNetTasks.DotNetPack(_ => _
                .SetProject(ProjectForPublishing)
                .SetConfiguration(Configuration.Release)
                .SetVerbosity(DotNetVerbosity.quiet));
        });
    
    Target MakeAllCi => _ => _
        .DependsOn(CompileKiota)
        .DependsOn(Clean, Restore, Compile)
        .DependsOn(GenerateKiotaToolManifest, GenerateKiotaCode)
        .DependsOn(CompileAfterGenerate)
        .DependsOn(Test)
        .DependsOn(Publish);
}