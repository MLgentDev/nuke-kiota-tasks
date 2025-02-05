// Generated from Kiota.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace MLgentDev.Nuke.Common.Tools.Kiota;

/// <summary><p>OpenAPI based HTTP Client code generator</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[PathTool(Executable = PathExecutable)]
public partial class KiotaTasks : ToolTasks, IRequirePathTool
{
    public static string KiotaPath { get => new KiotaTasks().GetToolPathInternal(); set => new KiotaTasks().SetToolPath(value); }
    public const string PathExecutable = "kiota";
    /// <summary><p>OpenAPI based HTTP Client code generator</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    public static IReadOnlyCollection<Output> Kiota(ArgumentStringHandler arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Action<OutputType, string> logger = null, Func<IProcess, object> exitHandler = null) => new KiotaTasks().Run(arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, logger, exitHandler);
    /// <summary><p>Generates a REST HTTP API client from an OpenAPI description file.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--additional-data</c> via <see cref="KiotaGenerateSettings.AdditionalData"/></li><li><c>--backing-store</c> via <see cref="KiotaGenerateSettings.BackingStore"/></li><li><c>--class-name</c> via <see cref="KiotaGenerateSettings.ClassName"/></li><li><c>--clean-output</c> via <see cref="KiotaGenerateSettings.CleanOutput"/></li><li><c>--clear-cache</c> via <see cref="KiotaGenerateSettings.ClearCache"/></li><li><c>--deserializer</c> via <see cref="KiotaGenerateSettings.Deserializer"/></li><li><c>--disable-ssl-validation</c> via <see cref="KiotaGenerateSettings.DisableSslValidation"/></li><li><c>--disable-validation-rules</c> via <see cref="KiotaGenerateSettings.DisableValidationRules"/></li><li><c>--exclude-backward-compatible</c> via <see cref="KiotaGenerateSettings.ExcludeBackwardCompatible"/></li><li><c>--exclude-path</c> via <see cref="KiotaGenerateSettings.ExcludePath"/></li><li><c>--include-path</c> via <see cref="KiotaGenerateSettings.IncludePath"/></li><li><c>--language</c> via <see cref="KiotaGenerateSettings.Language"/></li><li><c>--log-level</c> via <see cref="KiotaGenerateSettings.LogLevel"/></li><li><c>--manifest</c> via <see cref="KiotaGenerateSettings.Manifest"/></li><li><c>--namespace-name</c> via <see cref="KiotaGenerateSettings.NamespaceName"/></li><li><c>--openapi</c> via <see cref="KiotaGenerateSettings.Openapi"/></li><li><c>--output</c> via <see cref="KiotaGenerateSettings.Output"/></li><li><c>--serializer</c> via <see cref="KiotaGenerateSettings.Serializer"/></li><li><c>--structured-mime-types</c> via <see cref="KiotaGenerateSettings.StructuredMimeTypes"/></li><li><c>--type-access-modifier</c> via <see cref="KiotaGenerateSettings.TypeAccessModifier"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaGenerate(KiotaGenerateSettings options = null) => new KiotaTasks().Run<KiotaGenerateSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaGenerate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaGenerateSettings)"/>
    public static IReadOnlyCollection<Output> KiotaGenerate(Configure<KiotaGenerateSettings> configurator) => new KiotaTasks().Run<KiotaGenerateSettings>(configurator.Invoke(new KiotaGenerateSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaGenerate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaGenerateSettings)"/>
    public static IEnumerable<(KiotaGenerateSettings Settings, IReadOnlyCollection<Output> Output)> KiotaGenerate(CombinatorialConfigure<KiotaGenerateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaGenerate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Searches for an OpenAPI description in multiple registries.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;searchTerm&gt;</c> via <see cref="KiotaSearchSettings.SearchTerm"/></li><li><c>--clear-cache</c> via <see cref="KiotaSearchSettings.ClearCache"/></li><li><c>--log-level</c> via <see cref="KiotaSearchSettings.LogLevel"/></li><li><c>--version</c> via <see cref="KiotaSearchSettings.Version"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaSearch(KiotaSearchSettings options = null) => new KiotaTasks().Run<KiotaSearchSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaSearch(MLgentDev.Nuke.Common.Tools.Kiota.KiotaSearchSettings)"/>
    public static IReadOnlyCollection<Output> KiotaSearch(Configure<KiotaSearchSettings> configurator) => new KiotaTasks().Run<KiotaSearchSettings>(configurator.Invoke(new KiotaSearchSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaSearch(MLgentDev.Nuke.Common.Tools.Kiota.KiotaSearchSettings)"/>
    public static IEnumerable<(KiotaSearchSettings Settings, IReadOnlyCollection<Output> Output)> KiotaSearch(CombinatorialConfigure<KiotaSearchSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaSearch, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Downloads an OpenAPI description from multiple registries.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>&lt;key&gt;</c> via <see cref="KiotaDownloadSettings.Key"/></li><li><c>--clean-output</c> via <see cref="KiotaDownloadSettings.CleanOutput"/></li><li><c>--clear-cache</c> via <see cref="KiotaDownloadSettings.ClearCache"/></li><li><c>--disable-ssl-validation</c> via <see cref="KiotaDownloadSettings.DisableSslValidation"/></li><li><c>--log-level</c> via <see cref="KiotaDownloadSettings.LogLevel"/></li><li><c>--output</c> via <see cref="KiotaDownloadSettings.Output"/></li><li><c>--version</c> via <see cref="KiotaDownloadSettings.Version"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaDownload(KiotaDownloadSettings options = null) => new KiotaTasks().Run<KiotaDownloadSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaDownload(MLgentDev.Nuke.Common.Tools.Kiota.KiotaDownloadSettings)"/>
    public static IReadOnlyCollection<Output> KiotaDownload(Configure<KiotaDownloadSettings> configurator) => new KiotaTasks().Run<KiotaDownloadSettings>(configurator.Invoke(new KiotaDownloadSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaDownload(MLgentDev.Nuke.Common.Tools.Kiota.KiotaDownloadSettings)"/>
    public static IEnumerable<(KiotaDownloadSettings Settings, IReadOnlyCollection<Output> Output)> KiotaDownload(CombinatorialConfigure<KiotaDownloadSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaDownload, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Displays the API tree in a given description.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--clear-cache</c> via <see cref="KiotaShowSettings.ClearCache"/></li><li><c>--disable-ssl-validation</c> via <see cref="KiotaShowSettings.DisableSslValidation"/></li><li><c>--exclude-path</c> via <see cref="KiotaShowSettings.ExcludePath"/></li><li><c>--include-path</c> via <see cref="KiotaShowSettings.IncludePath"/></li><li><c>--log-level</c> via <see cref="KiotaShowSettings.LogLevel"/></li><li><c>--manifest</c> via <see cref="KiotaShowSettings.Manifest"/></li><li><c>--max-depth</c> via <see cref="KiotaShowSettings.MaxDepth"/></li><li><c>--openapi</c> via <see cref="KiotaShowSettings.Openapi"/></li><li><c>--search-key</c> via <see cref="KiotaShowSettings.SearchKey"/></li><li><c>--version</c> via <see cref="KiotaShowSettings.Version"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaShow(KiotaShowSettings options = null) => new KiotaTasks().Run<KiotaShowSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaShow(MLgentDev.Nuke.Common.Tools.Kiota.KiotaShowSettings)"/>
    public static IReadOnlyCollection<Output> KiotaShow(Configure<KiotaShowSettings> configurator) => new KiotaTasks().Run<KiotaShowSettings>(configurator.Invoke(new KiotaShowSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaShow(MLgentDev.Nuke.Common.Tools.Kiota.KiotaShowSettings)"/>
    public static IEnumerable<(KiotaShowSettings Settings, IReadOnlyCollection<Output> Output)> KiotaShow(CombinatorialConfigure<KiotaShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaShow, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Displays information about the languages supported by kiota and dependencies to add in your project.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--clear-cache</c> via <see cref="KiotaInfoSettings.ClearCache"/></li><li><c>--dependency-type</c> via <see cref="KiotaInfoSettings.DependencyType"/></li><li><c>--json</c> via <see cref="KiotaInfoSettings.Json"/></li><li><c>--language</c> via <see cref="KiotaInfoSettings.Language"/></li><li><c>--log-level</c> via <see cref="KiotaInfoSettings.LogLevel"/></li><li><c>--manifest</c> via <see cref="KiotaInfoSettings.Manifest"/></li><li><c>--openapi</c> via <see cref="KiotaInfoSettings.Openapi"/></li><li><c>--search-key</c> via <see cref="KiotaInfoSettings.SearchKey"/></li><li><c>--version</c> via <see cref="KiotaInfoSettings.Version"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaInfo(KiotaInfoSettings options = null) => new KiotaTasks().Run<KiotaInfoSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaInfo(MLgentDev.Nuke.Common.Tools.Kiota.KiotaInfoSettings)"/>
    public static IReadOnlyCollection<Output> KiotaInfo(Configure<KiotaInfoSettings> configurator) => new KiotaTasks().Run<KiotaInfoSettings>(configurator.Invoke(new KiotaInfoSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaInfo(MLgentDev.Nuke.Common.Tools.Kiota.KiotaInfoSettings)"/>
    public static IEnumerable<(KiotaInfoSettings Settings, IReadOnlyCollection<Output> Output)> KiotaInfo(CombinatorialConfigure<KiotaInfoSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaInfo, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Updates existing clients under the target directory using their lock files.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--clean-output</c> via <see cref="KiotaUpdateSettings.CleanOutput"/></li><li><c>--clear-cache</c> via <see cref="KiotaUpdateSettings.ClearCache"/></li><li><c>--log-level</c> via <see cref="KiotaUpdateSettings.LogLevel"/></li><li><c>--output</c> via <see cref="KiotaUpdateSettings.Output"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaUpdate(KiotaUpdateSettings options = null) => new KiotaTasks().Run<KiotaUpdateSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaUpdate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaUpdateSettings)"/>
    public static IReadOnlyCollection<Output> KiotaUpdate(Configure<KiotaUpdateSettings> configurator) => new KiotaTasks().Run<KiotaUpdateSettings>(configurator.Invoke(new KiotaUpdateSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaUpdate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaUpdateSettings)"/>
    public static IEnumerable<(KiotaUpdateSettings Settings, IReadOnlyCollection<Output> Output)> KiotaUpdate(CombinatorialConfigure<KiotaUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaUpdate, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Logs in to GitHub using a device code flow.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--log-level</c> via <see cref="KiotaLoginGithubDeviceSettings.LogLevel"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaLoginGithubDevice(KiotaLoginGithubDeviceSettings options = null) => new KiotaTasks().Run<KiotaLoginGithubDeviceSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaLoginGithubDevice(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubDeviceSettings)"/>
    public static IReadOnlyCollection<Output> KiotaLoginGithubDevice(Configure<KiotaLoginGithubDeviceSettings> configurator) => new KiotaTasks().Run<KiotaLoginGithubDeviceSettings>(configurator.Invoke(new KiotaLoginGithubDeviceSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaLoginGithubDevice(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubDeviceSettings)"/>
    public static IEnumerable<(KiotaLoginGithubDeviceSettings Settings, IReadOnlyCollection<Output> Output)> KiotaLoginGithubDevice(CombinatorialConfigure<KiotaLoginGithubDeviceSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaLoginGithubDevice, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Logs in to GitHub using a Personal Access Token.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--log-level</c> via <see cref="KiotaLoginGithubPatSettings.LogLevel"/></li><li><c>--pat</c> via <see cref="KiotaLoginGithubPatSettings.Pat"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaLoginGithubPat(KiotaLoginGithubPatSettings options = null) => new KiotaTasks().Run<KiotaLoginGithubPatSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaLoginGithubPat(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubPatSettings)"/>
    public static IReadOnlyCollection<Output> KiotaLoginGithubPat(Configure<KiotaLoginGithubPatSettings> configurator) => new KiotaTasks().Run<KiotaLoginGithubPatSettings>(configurator.Invoke(new KiotaLoginGithubPatSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaLoginGithubPat(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubPatSettings)"/>
    public static IEnumerable<(KiotaLoginGithubPatSettings Settings, IReadOnlyCollection<Output> Output)> KiotaLoginGithubPat(CombinatorialConfigure<KiotaLoginGithubPatSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaLoginGithubPat, degreeOfParallelism, completeOnFailure);
    /// <summary><p>Logs out of GitHub.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--log-level</c> via <see cref="KiotaLogoutGithubSettings.LogLevel"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaLogoutGithub(KiotaLogoutGithubSettings options = null) => new KiotaTasks().Run<KiotaLogoutGithubSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaLogoutGithub(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLogoutGithubSettings)"/>
    public static IReadOnlyCollection<Output> KiotaLogoutGithub(Configure<KiotaLogoutGithubSettings> configurator) => new KiotaTasks().Run<KiotaLogoutGithubSettings>(configurator.Invoke(new KiotaLogoutGithubSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaLogoutGithub(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLogoutGithubSettings)"/>
    public static IEnumerable<(KiotaLogoutGithubSettings Settings, IReadOnlyCollection<Output> Output)> KiotaLogoutGithub(CombinatorialConfigure<KiotaLogoutGithubSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaLogoutGithub, degreeOfParallelism, completeOnFailure);
    /// <summary><p>WARNING EXPERIMENTAL: Starts a kiota as a JSON-RPC server.</p><p>For more details, visit the <a href="https://github.com/microsoft/kiota">official website</a>.</p></summary>
    /// <remarks><p>This is a <a href="https://www.nuke.build/docs/common/cli-tools/#fluent-api">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p><ul><li><c>--mode</c> via <see cref="KiotaRpcSettings.Mode"/></li><li><c>--pipe-name</c> via <see cref="KiotaRpcSettings.PipeName"/></li></ul></remarks>
    public static IReadOnlyCollection<Output> KiotaRpc(KiotaRpcSettings options = null) => new KiotaTasks().Run<KiotaRpcSettings>(options);
    /// <inheritdoc cref="KiotaTasks.KiotaRpc(MLgentDev.Nuke.Common.Tools.Kiota.KiotaRpcSettings)"/>
    public static IReadOnlyCollection<Output> KiotaRpc(Configure<KiotaRpcSettings> configurator) => new KiotaTasks().Run<KiotaRpcSettings>(configurator.Invoke(new KiotaRpcSettings()));
    /// <inheritdoc cref="KiotaTasks.KiotaRpc(MLgentDev.Nuke.Common.Tools.Kiota.KiotaRpcSettings)"/>
    public static IEnumerable<(KiotaRpcSettings Settings, IReadOnlyCollection<Output> Output)> KiotaRpc(CombinatorialConfigure<KiotaRpcSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false) => configurator.Invoke(KiotaRpc, degreeOfParallelism, completeOnFailure);
}
#region KiotaGenerateSettings
/// <inheritdoc cref="KiotaTasks.KiotaGenerate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaGenerateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaGenerate), Arguments = "generate")]
public partial class KiotaGenerateSettings : ToolOptions
{
    /// <summary>The path or URI to the OpenAPI description file used to generate the code files.</summary>
    [Argument(Format = "--openapi {value}", Secret = false)] public string Openapi => Get<string>(() => Openapi);
    /// <summary>The path or URI to the API manifest file used to generate the code files. Append #apikey if the target manifest contains multiple API dependencies entries.</summary>
    [Argument(Format = "--manifest {value}", Secret = false)] public string Manifest => Get<string>(() => Manifest);
    /// <summary>The output directory path for the generated code files.</summary>
    [Argument(Format = "--output {value}", Secret = false)] public string Output => Get<string>(() => Output);
    /// <summary>The target language for the generated code files.</summary>
    [Argument(Format = "--language {value}", Secret = false)] public GenerationLanguage Language => Get<GenerationLanguage>(() => Language);
    /// <summary>The class name to use for the core client class.</summary>
    [Argument(Format = "--class-name {value}", Secret = false)] public string ClassName => Get<string>(() => ClassName);
    /// <summary>The type access modifier to use for the client types.</summary>
    [Argument(Format = "--type-access-modifier {value}", Secret = false)] public AccessModifier TypeAccessModifier => Get<AccessModifier>(() => TypeAccessModifier);
    /// <summary>The namespace to use for the core client class specified with the --class-name option.</summary>
    [Argument(Format = "--namespace-name {value}", Secret = false)] public string NamespaceName => Get<string>(() => NamespaceName);
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
    /// <summary>Enables backing store for models.</summary>
    [Argument(Format = "--backing-store {value}", Secret = false)] public bool? BackingStore => Get<bool?>(() => BackingStore);
    /// <summary>Excludes backward compatible and obsolete assets from the generated result. Should be used for new clients.</summary>
    [Argument(Format = "--exclude-backward-compatible {value}", Secret = false)] public bool? ExcludeBackwardCompatible => Get<bool?>(() => ExcludeBackwardCompatible);
    /// <summary>Will include the 'AdditionalData' property for models.</summary>
    [Argument(Format = "--additional-data {value}", Secret = false)] public bool? AdditionalData => Get<bool?>(() => AdditionalData);
    /// <summary>The fully qualified class names for serializers. Accepts multiple values. Use `none` to generate a client without any serializer.</summary>
    [Argument(Format = "--serializer {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> Serializer => Get<List<string>>(() => Serializer);
    /// <summary>The fully qualified class names for deserializers. Accepts multiple values. Use `none` to generate a client without any deserializer.</summary>
    [Argument(Format = "--deserializer {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> Deserializer => Get<List<string>>(() => Deserializer);
    /// <summary>Removes all files from the output directory before generating the code files.</summary>
    [Argument(Format = "--clean-output {value}", Secret = false)] public bool? CleanOutput => Get<bool?>(() => CleanOutput);
    /// <summary>The MIME types with optional priorities as defined in RFC9110 Accept header to use for structured data model generation. Accepts multiple values.</summary>
    [Argument(Format = "--structured-mime-types {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> StructuredMimeTypes => Get<List<string>>(() => StructuredMimeTypes);
    /// <summary>The paths to include in the generation. Glob patterns accepted. Accepts multiple values. Append #OPERATION to the pattern to specify the operation to include. e.g. users/*/messages#GET</summary>
    [Argument(Format = "--include-path {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> IncludePath => Get<List<string>>(() => IncludePath);
    /// <summary>The paths to exclude from the generation. Glob patterns accepted. Accepts multiple values. Append #OPERATION to the pattern to specify the operation to exclude. e.g. users/*/messages#GET</summary>
    [Argument(Format = "--exclude-path {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> ExcludePath => Get<List<string>>(() => ExcludePath);
    /// <summary>The OpenAPI description validation rules to disable. Accepts multiple values.</summary>
    [Argument(Format = "--disable-validation-rules {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> DisableValidationRules => Get<List<string>>(() => DisableValidationRules);
    /// <summary>Clears any cached data for the current command.</summary>
    [Argument(Format = "--clear-cache {value}", Secret = false)] public bool? ClearCache => Get<bool?>(() => ClearCache);
    /// <summary>Disables SSL certificate validation.</summary>
    [Argument(Format = "--disable-ssl-validation {value}", Secret = false)] public bool? DisableSslValidation => Get<bool?>(() => DisableSslValidation);
}
#endregion
#region KiotaSearchSettings
/// <inheritdoc cref="KiotaTasks.KiotaSearch(MLgentDev.Nuke.Common.Tools.Kiota.KiotaSearchSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaSearch), Arguments = "search")]
public partial class KiotaSearchSettings : ToolOptions
{
    /// <summary>The term to search for.</summary>
    [Argument(Format = "{value}", Position = 0)] public string SearchTerm => Get<string>(() => SearchTerm);
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
    /// <summary>Clears any cached data for the current command.</summary>
    [Argument(Format = "--clear-cache {value}", Secret = false)] public bool? ClearCache => Get<bool?>(() => ClearCache);
    /// <summary>The version of the OpenAPI document to use.</summary>
    [Argument(Format = "--version {value}", Secret = false)] public string Version => Get<string>(() => Version);
}
#endregion
#region KiotaDownloadSettings
/// <inheritdoc cref="KiotaTasks.KiotaDownload(MLgentDev.Nuke.Common.Tools.Kiota.KiotaDownloadSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaDownload), Arguments = "download")]
public partial class KiotaDownloadSettings : ToolOptions
{
    /// <summary>The search result key to download the description for. Use the search command to get the key.</summary>
    [Argument(Format = "{value}", Position = 0)] public string Key => Get<string>(() => Key);
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
    /// <summary>Clears any cached data for the current command.</summary>
    [Argument(Format = "--clear-cache {value}", Secret = false)] public bool? ClearCache => Get<bool?>(() => ClearCache);
    /// <summary>The version of the OpenAPI document to use.</summary>
    [Argument(Format = "--version {value}", Secret = false)] public string Version => Get<string>(() => Version);
    /// <summary>Removes all files from the output directory before generating the code files.</summary>
    [Argument(Format = "--clean-output {value}", Secret = false)] public bool? CleanOutput => Get<bool?>(() => CleanOutput);
    /// <summary>The output directory path for the generated code files.</summary>
    [Argument(Format = "--output {value}", Secret = false)] public string Output => Get<string>(() => Output);
    /// <summary>Disables SSL certificate validation.</summary>
    [Argument(Format = "--disable-ssl-validation {value}", Secret = false)] public bool? DisableSslValidation => Get<bool?>(() => DisableSslValidation);
}
#endregion
#region KiotaShowSettings
/// <inheritdoc cref="KiotaTasks.KiotaShow(MLgentDev.Nuke.Common.Tools.Kiota.KiotaShowSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaShow), Arguments = "show")]
public partial class KiotaShowSettings : ToolOptions
{
    /// <summary>The API search key to display the description for. Use the search command to get the key.</summary>
    [Argument(Format = "--search-key {value}", Secret = false)] public string SearchKey => Get<string>(() => SearchKey);
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
    /// <summary>The version of the OpenAPI document to use.</summary>
    [Argument(Format = "--version {value}", Secret = false)] public string Version => Get<string>(() => Version);
    /// <summary>The path or URI to the OpenAPI description file used to generate the code files.</summary>
    [Argument(Format = "--openapi {value}", Secret = false)] public string Openapi => Get<string>(() => Openapi);
    /// <summary>The path or URI to the API manifest file used to generate the code files. Append #apikey if the target manifest contains multiple API dependencies entries.</summary>
    [Argument(Format = "--manifest {value}", Secret = false)] public string Manifest => Get<string>(() => Manifest);
    /// <summary>The maximum depth of the tree to display</summary>
    [Argument(Format = "--max-depth {value}", Secret = false)] public int? MaxDepth => Get<int?>(() => MaxDepth);
    /// <summary>The paths to include in the generation. Glob patterns accepted. Accepts multiple values. Append #OPERATION to the pattern to specify the operation to include. e.g. users/*/messages#GET</summary>
    [Argument(Format = "--include-path {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> IncludePath => Get<List<string>>(() => IncludePath);
    /// <summary>The paths to exclude from the generation. Glob patterns accepted. Accepts multiple values. Append #OPERATION to the pattern to specify the operation to exclude. e.g. users/*/messages#GET</summary>
    [Argument(Format = "--exclude-path {value}", Secret = false, Separator = " ")] public IReadOnlyList<string> ExcludePath => Get<List<string>>(() => ExcludePath);
    /// <summary>Clears any cached data for the current command.</summary>
    [Argument(Format = "--clear-cache {value}", Secret = false)] public bool? ClearCache => Get<bool?>(() => ClearCache);
    /// <summary>Disables SSL certificate validation.</summary>
    [Argument(Format = "--disable-ssl-validation {value}", Secret = false)] public bool? DisableSslValidation => Get<bool?>(() => DisableSslValidation);
}
#endregion
#region KiotaInfoSettings
/// <inheritdoc cref="KiotaTasks.KiotaInfo(MLgentDev.Nuke.Common.Tools.Kiota.KiotaInfoSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaInfo), Arguments = "info")]
public partial class KiotaInfoSettings : ToolOptions
{
    /// <summary>The path or URI to the OpenAPI description file used to generate the code files.</summary>
    [Argument(Format = "--openapi {value}", Secret = false)] public string Openapi => Get<string>(() => Openapi);
    /// <summary>The path or URI to the API manifest file used to generate the code files. Append #apikey if the target manifest contains multiple API dependencies entries.</summary>
    [Argument(Format = "--manifest {value}", Secret = false)] public string Manifest => Get<string>(() => Manifest);
    /// <summary>The version of the OpenAPI document to use.</summary>
    [Argument(Format = "--version {value}", Secret = false)] public string Version => Get<string>(() => Version);
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
    /// <summary>Clears any cached data for the current command.</summary>
    [Argument(Format = "--clear-cache {value}", Secret = false)] public bool? ClearCache => Get<bool?>(() => ClearCache);
    /// <summary>The API search key to display the description for. Use the search command to get the key.</summary>
    [Argument(Format = "--search-key {value}", Secret = false)] public string SearchKey => Get<string>(() => SearchKey);
    /// <summary>The target language for the dependencies instructions.</summary>
    [Argument(Format = "--language {value}", Secret = false)] public GenerationLanguage Language => Get<GenerationLanguage>(() => Language);
    /// <summary>Generate a plain and machine-parsable json output.</summary>
    [Argument(Format = "--json {value}", Secret = false)] public bool? Json => Get<bool?>(() => Json);
    /// <summary>The type of dependency to display instructions for.</summary>
    [Argument(Format = "--dependency-type {value}", Secret = false, Separator = " ")] public IReadOnlyList<DependencyType> DependencyType => Get<List<DependencyType>>(() => DependencyType);
}
#endregion
#region KiotaUpdateSettings
/// <inheritdoc cref="KiotaTasks.KiotaUpdate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaUpdate), Arguments = "update")]
public partial class KiotaUpdateSettings : ToolOptions
{
    /// <summary>The output directory path for the generated code files.</summary>
    [Argument(Format = "--output {value}", Secret = false)] public string Output => Get<string>(() => Output);
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
    /// <summary>Removes all files from the output directory before generating the code files.</summary>
    [Argument(Format = "--clean-output {value}", Secret = false)] public bool? CleanOutput => Get<bool?>(() => CleanOutput);
    /// <summary>Clears any cached data for the current command.</summary>
    [Argument(Format = "--clear-cache {value}", Secret = false)] public bool? ClearCache => Get<bool?>(() => ClearCache);
}
#endregion
#region KiotaLoginGithubDeviceSettings
/// <inheritdoc cref="KiotaTasks.KiotaLoginGithubDevice(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubDeviceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaLoginGithubDevice), Arguments = "login github device")]
public partial class KiotaLoginGithubDeviceSettings : ToolOptions
{
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
}
#endregion
#region KiotaLoginGithubPatSettings
/// <inheritdoc cref="KiotaTasks.KiotaLoginGithubPat(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubPatSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaLoginGithubPat), Arguments = "login github pat")]
public partial class KiotaLoginGithubPatSettings : ToolOptions
{
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
    /// <summary>The personal access token to use to authenticate to GitHub.</summary>
    [Argument(Format = "--pat {value}", Secret = true)] public string Pat => Get<string>(() => Pat);
}
#endregion
#region KiotaLogoutGithubSettings
/// <inheritdoc cref="KiotaTasks.KiotaLogoutGithub(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLogoutGithubSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaLogoutGithub), Arguments = "logout github")]
public partial class KiotaLogoutGithubSettings : ToolOptions
{
    /// <summary>The log level to use when logging messages to the main output.</summary>
    [Argument(Format = "--log-level {value}", Secret = false)] public LogLevel LogLevel => Get<LogLevel>(() => LogLevel);
}
#endregion
#region KiotaRpcSettings
/// <inheritdoc cref="KiotaTasks.KiotaRpc(MLgentDev.Nuke.Common.Tools.Kiota.KiotaRpcSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Command(Type = typeof(KiotaTasks), Command = nameof(KiotaTasks.KiotaRpc), Arguments = "rpc")]
public partial class KiotaRpcSettings : ToolOptions
{
    /// <summary>Whether the RPC server should use stdin/stdout or a named pipe.</summary>
    [Argument(Format = "--mode {value}", Secret = false)] public RpcMode Mode => Get<RpcMode>(() => Mode);
    /// <summary>The name of the named pipe to use for the RPC server.</summary>
    [Argument(Format = "--pipe-name {value}", Secret = false)] public string PipeName => Get<string>(() => PipeName);
}
#endregion
#region KiotaGenerateSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaGenerate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaGenerateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaGenerateSettingsExtensions
{
    #region Openapi
    /// <inheritdoc cref="KiotaGenerateSettings.Openapi"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Openapi))]
    public static T SetOpenapi<T>(this T o, string v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Openapi, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Openapi"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Openapi))]
    public static T ResetOpenapi<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.Openapi));
    #endregion
    #region Manifest
    /// <inheritdoc cref="KiotaGenerateSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Manifest))]
    public static T SetManifest<T>(this T o, string v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Manifest, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Manifest))]
    public static T ResetManifest<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.Manifest));
    #endregion
    #region Output
    /// <inheritdoc cref="KiotaGenerateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region Language
    /// <inheritdoc cref="KiotaGenerateSettings.Language"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Language))]
    public static T SetLanguage<T>(this T o, GenerationLanguage v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Language, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Language"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Language))]
    public static T ResetLanguage<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.Language));
    #endregion
    #region ClassName
    /// <inheritdoc cref="KiotaGenerateSettings.ClassName"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ClassName))]
    public static T SetClassName<T>(this T o, string v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ClassName, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ClassName"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ClassName))]
    public static T ResetClassName<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.ClassName));
    #endregion
    #region TypeAccessModifier
    /// <inheritdoc cref="KiotaGenerateSettings.TypeAccessModifier"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.TypeAccessModifier))]
    public static T SetTypeAccessModifier<T>(this T o, AccessModifier v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.TypeAccessModifier, v));
    /// <inheritdoc cref="KiotaGenerateSettings.TypeAccessModifier"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.TypeAccessModifier))]
    public static T ResetTypeAccessModifier<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.TypeAccessModifier));
    #endregion
    #region NamespaceName
    /// <inheritdoc cref="KiotaGenerateSettings.NamespaceName"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.NamespaceName))]
    public static T SetNamespaceName<T>(this T o, string v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.NamespaceName, v));
    /// <inheritdoc cref="KiotaGenerateSettings.NamespaceName"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.NamespaceName))]
    public static T ResetNamespaceName<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.NamespaceName));
    #endregion
    #region LogLevel
    /// <inheritdoc cref="KiotaGenerateSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaGenerateSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
    #region BackingStore
    /// <inheritdoc cref="KiotaGenerateSettings.BackingStore"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.BackingStore))]
    public static T SetBackingStore<T>(this T o, bool? v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.BackingStore, v));
    /// <inheritdoc cref="KiotaGenerateSettings.BackingStore"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.BackingStore))]
    public static T ResetBackingStore<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.BackingStore));
    /// <inheritdoc cref="KiotaGenerateSettings.BackingStore"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.BackingStore))]
    public static T EnableBackingStore<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.BackingStore, true));
    /// <inheritdoc cref="KiotaGenerateSettings.BackingStore"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.BackingStore))]
    public static T DisableBackingStore<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.BackingStore, false));
    /// <inheritdoc cref="KiotaGenerateSettings.BackingStore"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.BackingStore))]
    public static T ToggleBackingStore<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.BackingStore, !o.BackingStore));
    #endregion
    #region ExcludeBackwardCompatible
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludeBackwardCompatible"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludeBackwardCompatible))]
    public static T SetExcludeBackwardCompatible<T>(this T o, bool? v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ExcludeBackwardCompatible, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludeBackwardCompatible"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludeBackwardCompatible))]
    public static T ResetExcludeBackwardCompatible<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.ExcludeBackwardCompatible));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludeBackwardCompatible"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludeBackwardCompatible))]
    public static T EnableExcludeBackwardCompatible<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ExcludeBackwardCompatible, true));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludeBackwardCompatible"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludeBackwardCompatible))]
    public static T DisableExcludeBackwardCompatible<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ExcludeBackwardCompatible, false));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludeBackwardCompatible"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludeBackwardCompatible))]
    public static T ToggleExcludeBackwardCompatible<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ExcludeBackwardCompatible, !o.ExcludeBackwardCompatible));
    #endregion
    #region AdditionalData
    /// <inheritdoc cref="KiotaGenerateSettings.AdditionalData"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.AdditionalData))]
    public static T SetAdditionalData<T>(this T o, bool? v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.AdditionalData, v));
    /// <inheritdoc cref="KiotaGenerateSettings.AdditionalData"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.AdditionalData))]
    public static T ResetAdditionalData<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.AdditionalData));
    /// <inheritdoc cref="KiotaGenerateSettings.AdditionalData"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.AdditionalData))]
    public static T EnableAdditionalData<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.AdditionalData, true));
    /// <inheritdoc cref="KiotaGenerateSettings.AdditionalData"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.AdditionalData))]
    public static T DisableAdditionalData<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.AdditionalData, false));
    /// <inheritdoc cref="KiotaGenerateSettings.AdditionalData"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.AdditionalData))]
    public static T ToggleAdditionalData<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.AdditionalData, !o.AdditionalData));
    #endregion
    #region Serializer
    /// <inheritdoc cref="KiotaGenerateSettings.Serializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Serializer))]
    public static T SetSerializer<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Serializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Serializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Serializer))]
    public static T SetSerializer<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Serializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Serializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Serializer))]
    public static T AddSerializer<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.Serializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Serializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Serializer))]
    public static T AddSerializer<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.Serializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Serializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Serializer))]
    public static T RemoveSerializer<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.Serializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Serializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Serializer))]
    public static T RemoveSerializer<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.Serializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Serializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Serializer))]
    public static T ClearSerializer<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.ClearCollection(() => o.Serializer));
    #endregion
    #region Deserializer
    /// <inheritdoc cref="KiotaGenerateSettings.Deserializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Deserializer))]
    public static T SetDeserializer<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Deserializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Deserializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Deserializer))]
    public static T SetDeserializer<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.Deserializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Deserializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Deserializer))]
    public static T AddDeserializer<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.Deserializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Deserializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Deserializer))]
    public static T AddDeserializer<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.Deserializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Deserializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Deserializer))]
    public static T RemoveDeserializer<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.Deserializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Deserializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Deserializer))]
    public static T RemoveDeserializer<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.Deserializer, v));
    /// <inheritdoc cref="KiotaGenerateSettings.Deserializer"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.Deserializer))]
    public static T ClearDeserializer<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.ClearCollection(() => o.Deserializer));
    #endregion
    #region CleanOutput
    /// <inheritdoc cref="KiotaGenerateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.CleanOutput))]
    public static T SetCleanOutput<T>(this T o, bool? v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.CleanOutput, v));
    /// <inheritdoc cref="KiotaGenerateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.CleanOutput))]
    public static T ResetCleanOutput<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.CleanOutput));
    /// <inheritdoc cref="KiotaGenerateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.CleanOutput))]
    public static T EnableCleanOutput<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.CleanOutput, true));
    /// <inheritdoc cref="KiotaGenerateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.CleanOutput))]
    public static T DisableCleanOutput<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.CleanOutput, false));
    /// <inheritdoc cref="KiotaGenerateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.CleanOutput))]
    public static T ToggleCleanOutput<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.CleanOutput, !o.CleanOutput));
    #endregion
    #region StructuredMimeTypes
    /// <inheritdoc cref="KiotaGenerateSettings.StructuredMimeTypes"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.StructuredMimeTypes))]
    public static T SetStructuredMimeTypes<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.StructuredMimeTypes, v));
    /// <inheritdoc cref="KiotaGenerateSettings.StructuredMimeTypes"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.StructuredMimeTypes))]
    public static T SetStructuredMimeTypes<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.StructuredMimeTypes, v));
    /// <inheritdoc cref="KiotaGenerateSettings.StructuredMimeTypes"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.StructuredMimeTypes))]
    public static T AddStructuredMimeTypes<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.StructuredMimeTypes, v));
    /// <inheritdoc cref="KiotaGenerateSettings.StructuredMimeTypes"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.StructuredMimeTypes))]
    public static T AddStructuredMimeTypes<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.StructuredMimeTypes, v));
    /// <inheritdoc cref="KiotaGenerateSettings.StructuredMimeTypes"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.StructuredMimeTypes))]
    public static T RemoveStructuredMimeTypes<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.StructuredMimeTypes, v));
    /// <inheritdoc cref="KiotaGenerateSettings.StructuredMimeTypes"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.StructuredMimeTypes))]
    public static T RemoveStructuredMimeTypes<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.StructuredMimeTypes, v));
    /// <inheritdoc cref="KiotaGenerateSettings.StructuredMimeTypes"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.StructuredMimeTypes))]
    public static T ClearStructuredMimeTypes<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.ClearCollection(() => o.StructuredMimeTypes));
    #endregion
    #region IncludePath
    /// <inheritdoc cref="KiotaGenerateSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.IncludePath))]
    public static T SetIncludePath<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.IncludePath))]
    public static T SetIncludePath<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.IncludePath))]
    public static T AddIncludePath<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.IncludePath))]
    public static T AddIncludePath<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.IncludePath))]
    public static T RemoveIncludePath<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.IncludePath))]
    public static T RemoveIncludePath<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.IncludePath))]
    public static T ClearIncludePath<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.ClearCollection(() => o.IncludePath));
    #endregion
    #region ExcludePath
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludePath))]
    public static T SetExcludePath<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludePath))]
    public static T SetExcludePath<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludePath))]
    public static T AddExcludePath<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludePath))]
    public static T AddExcludePath<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludePath))]
    public static T RemoveExcludePath<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludePath))]
    public static T RemoveExcludePath<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ExcludePath))]
    public static T ClearExcludePath<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.ClearCollection(() => o.ExcludePath));
    #endregion
    #region DisableValidationRules
    /// <inheritdoc cref="KiotaGenerateSettings.DisableValidationRules"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableValidationRules))]
    public static T SetDisableValidationRules<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.DisableValidationRules, v));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableValidationRules"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableValidationRules))]
    public static T SetDisableValidationRules<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.DisableValidationRules, v));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableValidationRules"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableValidationRules))]
    public static T AddDisableValidationRules<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.DisableValidationRules, v));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableValidationRules"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableValidationRules))]
    public static T AddDisableValidationRules<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.AddCollection(() => o.DisableValidationRules, v));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableValidationRules"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableValidationRules))]
    public static T RemoveDisableValidationRules<T>(this T o, params string[] v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.DisableValidationRules, v));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableValidationRules"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableValidationRules))]
    public static T RemoveDisableValidationRules<T>(this T o, IEnumerable<string> v) where T : KiotaGenerateSettings => o.Modify(b => b.RemoveCollection(() => o.DisableValidationRules, v));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableValidationRules"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableValidationRules))]
    public static T ClearDisableValidationRules<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.ClearCollection(() => o.DisableValidationRules));
    #endregion
    #region ClearCache
    /// <inheritdoc cref="KiotaGenerateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ClearCache))]
    public static T SetClearCache<T>(this T o, bool? v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ClearCache, v));
    /// <inheritdoc cref="KiotaGenerateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ClearCache))]
    public static T ResetClearCache<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.ClearCache));
    /// <inheritdoc cref="KiotaGenerateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ClearCache))]
    public static T EnableClearCache<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ClearCache, true));
    /// <inheritdoc cref="KiotaGenerateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ClearCache))]
    public static T DisableClearCache<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ClearCache, false));
    /// <inheritdoc cref="KiotaGenerateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.ClearCache))]
    public static T ToggleClearCache<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.ClearCache, !o.ClearCache));
    #endregion
    #region DisableSslValidation
    /// <inheritdoc cref="KiotaGenerateSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableSslValidation))]
    public static T SetDisableSslValidation<T>(this T o, bool? v) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, v));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableSslValidation))]
    public static T ResetDisableSslValidation<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Remove(() => o.DisableSslValidation));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableSslValidation))]
    public static T EnableDisableSslValidation<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, true));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableSslValidation))]
    public static T DisableDisableSslValidation<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, false));
    /// <inheritdoc cref="KiotaGenerateSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaGenerateSettings), Property = nameof(KiotaGenerateSettings.DisableSslValidation))]
    public static T ToggleDisableSslValidation<T>(this T o) where T : KiotaGenerateSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, !o.DisableSslValidation));
    #endregion
}
#endregion
#region KiotaSearchSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaSearch(MLgentDev.Nuke.Common.Tools.Kiota.KiotaSearchSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaSearchSettingsExtensions
{
    #region SearchTerm
    /// <inheritdoc cref="KiotaSearchSettings.SearchTerm"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.SearchTerm))]
    public static T SetSearchTerm<T>(this T o, string v) where T : KiotaSearchSettings => o.Modify(b => b.Set(() => o.SearchTerm, v));
    /// <inheritdoc cref="KiotaSearchSettings.SearchTerm"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.SearchTerm))]
    public static T ResetSearchTerm<T>(this T o) where T : KiotaSearchSettings => o.Modify(b => b.Remove(() => o.SearchTerm));
    #endregion
    #region LogLevel
    /// <inheritdoc cref="KiotaSearchSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaSearchSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaSearchSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaSearchSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
    #region ClearCache
    /// <inheritdoc cref="KiotaSearchSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.ClearCache))]
    public static T SetClearCache<T>(this T o, bool? v) where T : KiotaSearchSettings => o.Modify(b => b.Set(() => o.ClearCache, v));
    /// <inheritdoc cref="KiotaSearchSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.ClearCache))]
    public static T ResetClearCache<T>(this T o) where T : KiotaSearchSettings => o.Modify(b => b.Remove(() => o.ClearCache));
    /// <inheritdoc cref="KiotaSearchSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.ClearCache))]
    public static T EnableClearCache<T>(this T o) where T : KiotaSearchSettings => o.Modify(b => b.Set(() => o.ClearCache, true));
    /// <inheritdoc cref="KiotaSearchSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.ClearCache))]
    public static T DisableClearCache<T>(this T o) where T : KiotaSearchSettings => o.Modify(b => b.Set(() => o.ClearCache, false));
    /// <inheritdoc cref="KiotaSearchSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.ClearCache))]
    public static T ToggleClearCache<T>(this T o) where T : KiotaSearchSettings => o.Modify(b => b.Set(() => o.ClearCache, !o.ClearCache));
    #endregion
    #region Version
    /// <inheritdoc cref="KiotaSearchSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.Version))]
    public static T SetVersion<T>(this T o, string v) where T : KiotaSearchSettings => o.Modify(b => b.Set(() => o.Version, v));
    /// <inheritdoc cref="KiotaSearchSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaSearchSettings), Property = nameof(KiotaSearchSettings.Version))]
    public static T ResetVersion<T>(this T o) where T : KiotaSearchSettings => o.Modify(b => b.Remove(() => o.Version));
    #endregion
}
#endregion
#region KiotaDownloadSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaDownload(MLgentDev.Nuke.Common.Tools.Kiota.KiotaDownloadSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaDownloadSettingsExtensions
{
    #region Key
    /// <inheritdoc cref="KiotaDownloadSettings.Key"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.Key))]
    public static T SetKey<T>(this T o, string v) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.Key, v));
    /// <inheritdoc cref="KiotaDownloadSettings.Key"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.Key))]
    public static T ResetKey<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Remove(() => o.Key));
    #endregion
    #region LogLevel
    /// <inheritdoc cref="KiotaDownloadSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaDownloadSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
    #region ClearCache
    /// <inheritdoc cref="KiotaDownloadSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.ClearCache))]
    public static T SetClearCache<T>(this T o, bool? v) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.ClearCache, v));
    /// <inheritdoc cref="KiotaDownloadSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.ClearCache))]
    public static T ResetClearCache<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Remove(() => o.ClearCache));
    /// <inheritdoc cref="KiotaDownloadSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.ClearCache))]
    public static T EnableClearCache<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.ClearCache, true));
    /// <inheritdoc cref="KiotaDownloadSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.ClearCache))]
    public static T DisableClearCache<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.ClearCache, false));
    /// <inheritdoc cref="KiotaDownloadSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.ClearCache))]
    public static T ToggleClearCache<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.ClearCache, !o.ClearCache));
    #endregion
    #region Version
    /// <inheritdoc cref="KiotaDownloadSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.Version))]
    public static T SetVersion<T>(this T o, string v) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.Version, v));
    /// <inheritdoc cref="KiotaDownloadSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.Version))]
    public static T ResetVersion<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Remove(() => o.Version));
    #endregion
    #region CleanOutput
    /// <inheritdoc cref="KiotaDownloadSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.CleanOutput))]
    public static T SetCleanOutput<T>(this T o, bool? v) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.CleanOutput, v));
    /// <inheritdoc cref="KiotaDownloadSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.CleanOutput))]
    public static T ResetCleanOutput<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Remove(() => o.CleanOutput));
    /// <inheritdoc cref="KiotaDownloadSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.CleanOutput))]
    public static T EnableCleanOutput<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.CleanOutput, true));
    /// <inheritdoc cref="KiotaDownloadSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.CleanOutput))]
    public static T DisableCleanOutput<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.CleanOutput, false));
    /// <inheritdoc cref="KiotaDownloadSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.CleanOutput))]
    public static T ToggleCleanOutput<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.CleanOutput, !o.CleanOutput));
    #endregion
    #region Output
    /// <inheritdoc cref="KiotaDownloadSettings.Output"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KiotaDownloadSettings.Output"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region DisableSslValidation
    /// <inheritdoc cref="KiotaDownloadSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.DisableSslValidation))]
    public static T SetDisableSslValidation<T>(this T o, bool? v) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, v));
    /// <inheritdoc cref="KiotaDownloadSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.DisableSslValidation))]
    public static T ResetDisableSslValidation<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Remove(() => o.DisableSslValidation));
    /// <inheritdoc cref="KiotaDownloadSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.DisableSslValidation))]
    public static T EnableDisableSslValidation<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, true));
    /// <inheritdoc cref="KiotaDownloadSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.DisableSslValidation))]
    public static T DisableDisableSslValidation<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, false));
    /// <inheritdoc cref="KiotaDownloadSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaDownloadSettings), Property = nameof(KiotaDownloadSettings.DisableSslValidation))]
    public static T ToggleDisableSslValidation<T>(this T o) where T : KiotaDownloadSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, !o.DisableSslValidation));
    #endregion
}
#endregion
#region KiotaShowSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaShow(MLgentDev.Nuke.Common.Tools.Kiota.KiotaShowSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaShowSettingsExtensions
{
    #region SearchKey
    /// <inheritdoc cref="KiotaShowSettings.SearchKey"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.SearchKey))]
    public static T SetSearchKey<T>(this T o, string v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.SearchKey, v));
    /// <inheritdoc cref="KiotaShowSettings.SearchKey"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.SearchKey))]
    public static T ResetSearchKey<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.SearchKey));
    #endregion
    #region LogLevel
    /// <inheritdoc cref="KiotaShowSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaShowSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
    #region Version
    /// <inheritdoc cref="KiotaShowSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.Version))]
    public static T SetVersion<T>(this T o, string v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.Version, v));
    /// <inheritdoc cref="KiotaShowSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.Version))]
    public static T ResetVersion<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.Version));
    #endregion
    #region Openapi
    /// <inheritdoc cref="KiotaShowSettings.Openapi"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.Openapi))]
    public static T SetOpenapi<T>(this T o, string v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.Openapi, v));
    /// <inheritdoc cref="KiotaShowSettings.Openapi"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.Openapi))]
    public static T ResetOpenapi<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.Openapi));
    #endregion
    #region Manifest
    /// <inheritdoc cref="KiotaShowSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.Manifest))]
    public static T SetManifest<T>(this T o, string v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.Manifest, v));
    /// <inheritdoc cref="KiotaShowSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.Manifest))]
    public static T ResetManifest<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.Manifest));
    #endregion
    #region MaxDepth
    /// <inheritdoc cref="KiotaShowSettings.MaxDepth"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.MaxDepth))]
    public static T SetMaxDepth<T>(this T o, int? v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.MaxDepth, v));
    /// <inheritdoc cref="KiotaShowSettings.MaxDepth"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.MaxDepth))]
    public static T ResetMaxDepth<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.MaxDepth));
    #endregion
    #region IncludePath
    /// <inheritdoc cref="KiotaShowSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.IncludePath))]
    public static T SetIncludePath<T>(this T o, params string[] v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.IncludePath))]
    public static T SetIncludePath<T>(this T o, IEnumerable<string> v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.IncludePath))]
    public static T AddIncludePath<T>(this T o, params string[] v) where T : KiotaShowSettings => o.Modify(b => b.AddCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.IncludePath))]
    public static T AddIncludePath<T>(this T o, IEnumerable<string> v) where T : KiotaShowSettings => o.Modify(b => b.AddCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.IncludePath))]
    public static T RemoveIncludePath<T>(this T o, params string[] v) where T : KiotaShowSettings => o.Modify(b => b.RemoveCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.IncludePath))]
    public static T RemoveIncludePath<T>(this T o, IEnumerable<string> v) where T : KiotaShowSettings => o.Modify(b => b.RemoveCollection(() => o.IncludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.IncludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.IncludePath))]
    public static T ClearIncludePath<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.ClearCollection(() => o.IncludePath));
    #endregion
    #region ExcludePath
    /// <inheritdoc cref="KiotaShowSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ExcludePath))]
    public static T SetExcludePath<T>(this T o, params string[] v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ExcludePath))]
    public static T SetExcludePath<T>(this T o, IEnumerable<string> v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ExcludePath))]
    public static T AddExcludePath<T>(this T o, params string[] v) where T : KiotaShowSettings => o.Modify(b => b.AddCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ExcludePath))]
    public static T AddExcludePath<T>(this T o, IEnumerable<string> v) where T : KiotaShowSettings => o.Modify(b => b.AddCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ExcludePath))]
    public static T RemoveExcludePath<T>(this T o, params string[] v) where T : KiotaShowSettings => o.Modify(b => b.RemoveCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ExcludePath))]
    public static T RemoveExcludePath<T>(this T o, IEnumerable<string> v) where T : KiotaShowSettings => o.Modify(b => b.RemoveCollection(() => o.ExcludePath, v));
    /// <inheritdoc cref="KiotaShowSettings.ExcludePath"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ExcludePath))]
    public static T ClearExcludePath<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.ClearCollection(() => o.ExcludePath));
    #endregion
    #region ClearCache
    /// <inheritdoc cref="KiotaShowSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ClearCache))]
    public static T SetClearCache<T>(this T o, bool? v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.ClearCache, v));
    /// <inheritdoc cref="KiotaShowSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ClearCache))]
    public static T ResetClearCache<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.ClearCache));
    /// <inheritdoc cref="KiotaShowSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ClearCache))]
    public static T EnableClearCache<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.ClearCache, true));
    /// <inheritdoc cref="KiotaShowSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ClearCache))]
    public static T DisableClearCache<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.ClearCache, false));
    /// <inheritdoc cref="KiotaShowSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.ClearCache))]
    public static T ToggleClearCache<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.ClearCache, !o.ClearCache));
    #endregion
    #region DisableSslValidation
    /// <inheritdoc cref="KiotaShowSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.DisableSslValidation))]
    public static T SetDisableSslValidation<T>(this T o, bool? v) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, v));
    /// <inheritdoc cref="KiotaShowSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.DisableSslValidation))]
    public static T ResetDisableSslValidation<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Remove(() => o.DisableSslValidation));
    /// <inheritdoc cref="KiotaShowSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.DisableSslValidation))]
    public static T EnableDisableSslValidation<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, true));
    /// <inheritdoc cref="KiotaShowSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.DisableSslValidation))]
    public static T DisableDisableSslValidation<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, false));
    /// <inheritdoc cref="KiotaShowSettings.DisableSslValidation"/>
    [Pure] [Builder(Type = typeof(KiotaShowSettings), Property = nameof(KiotaShowSettings.DisableSslValidation))]
    public static T ToggleDisableSslValidation<T>(this T o) where T : KiotaShowSettings => o.Modify(b => b.Set(() => o.DisableSslValidation, !o.DisableSslValidation));
    #endregion
}
#endregion
#region KiotaInfoSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaInfo(MLgentDev.Nuke.Common.Tools.Kiota.KiotaInfoSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaInfoSettingsExtensions
{
    #region Openapi
    /// <inheritdoc cref="KiotaInfoSettings.Openapi"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Openapi))]
    public static T SetOpenapi<T>(this T o, string v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Openapi, v));
    /// <inheritdoc cref="KiotaInfoSettings.Openapi"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Openapi))]
    public static T ResetOpenapi<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.Openapi));
    #endregion
    #region Manifest
    /// <inheritdoc cref="KiotaInfoSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Manifest))]
    public static T SetManifest<T>(this T o, string v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Manifest, v));
    /// <inheritdoc cref="KiotaInfoSettings.Manifest"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Manifest))]
    public static T ResetManifest<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.Manifest));
    #endregion
    #region Version
    /// <inheritdoc cref="KiotaInfoSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Version))]
    public static T SetVersion<T>(this T o, string v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Version, v));
    /// <inheritdoc cref="KiotaInfoSettings.Version"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Version))]
    public static T ResetVersion<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.Version));
    #endregion
    #region LogLevel
    /// <inheritdoc cref="KiotaInfoSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaInfoSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
    #region ClearCache
    /// <inheritdoc cref="KiotaInfoSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.ClearCache))]
    public static T SetClearCache<T>(this T o, bool? v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.ClearCache, v));
    /// <inheritdoc cref="KiotaInfoSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.ClearCache))]
    public static T ResetClearCache<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.ClearCache));
    /// <inheritdoc cref="KiotaInfoSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.ClearCache))]
    public static T EnableClearCache<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.ClearCache, true));
    /// <inheritdoc cref="KiotaInfoSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.ClearCache))]
    public static T DisableClearCache<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.ClearCache, false));
    /// <inheritdoc cref="KiotaInfoSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.ClearCache))]
    public static T ToggleClearCache<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.ClearCache, !o.ClearCache));
    #endregion
    #region SearchKey
    /// <inheritdoc cref="KiotaInfoSettings.SearchKey"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.SearchKey))]
    public static T SetSearchKey<T>(this T o, string v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.SearchKey, v));
    /// <inheritdoc cref="KiotaInfoSettings.SearchKey"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.SearchKey))]
    public static T ResetSearchKey<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.SearchKey));
    #endregion
    #region Language
    /// <inheritdoc cref="KiotaInfoSettings.Language"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Language))]
    public static T SetLanguage<T>(this T o, GenerationLanguage v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Language, v));
    /// <inheritdoc cref="KiotaInfoSettings.Language"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Language))]
    public static T ResetLanguage<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.Language));
    #endregion
    #region Json
    /// <inheritdoc cref="KiotaInfoSettings.Json"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Json))]
    public static T SetJson<T>(this T o, bool? v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Json, v));
    /// <inheritdoc cref="KiotaInfoSettings.Json"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Json))]
    public static T ResetJson<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Remove(() => o.Json));
    /// <inheritdoc cref="KiotaInfoSettings.Json"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Json))]
    public static T EnableJson<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Json, true));
    /// <inheritdoc cref="KiotaInfoSettings.Json"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Json))]
    public static T DisableJson<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Json, false));
    /// <inheritdoc cref="KiotaInfoSettings.Json"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.Json))]
    public static T ToggleJson<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.Json, !o.Json));
    #endregion
    #region DependencyType
    /// <inheritdoc cref="KiotaInfoSettings.DependencyType"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.DependencyType))]
    public static T SetDependencyType<T>(this T o, params DependencyType[] v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.DependencyType, v));
    /// <inheritdoc cref="KiotaInfoSettings.DependencyType"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.DependencyType))]
    public static T SetDependencyType<T>(this T o, IEnumerable<DependencyType> v) where T : KiotaInfoSettings => o.Modify(b => b.Set(() => o.DependencyType, v));
    /// <inheritdoc cref="KiotaInfoSettings.DependencyType"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.DependencyType))]
    public static T AddDependencyType<T>(this T o, params DependencyType[] v) where T : KiotaInfoSettings => o.Modify(b => b.AddCollection(() => o.DependencyType, v));
    /// <inheritdoc cref="KiotaInfoSettings.DependencyType"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.DependencyType))]
    public static T AddDependencyType<T>(this T o, IEnumerable<DependencyType> v) where T : KiotaInfoSettings => o.Modify(b => b.AddCollection(() => o.DependencyType, v));
    /// <inheritdoc cref="KiotaInfoSettings.DependencyType"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.DependencyType))]
    public static T RemoveDependencyType<T>(this T o, params DependencyType[] v) where T : KiotaInfoSettings => o.Modify(b => b.RemoveCollection(() => o.DependencyType, v));
    /// <inheritdoc cref="KiotaInfoSettings.DependencyType"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.DependencyType))]
    public static T RemoveDependencyType<T>(this T o, IEnumerable<DependencyType> v) where T : KiotaInfoSettings => o.Modify(b => b.RemoveCollection(() => o.DependencyType, v));
    /// <inheritdoc cref="KiotaInfoSettings.DependencyType"/>
    [Pure] [Builder(Type = typeof(KiotaInfoSettings), Property = nameof(KiotaInfoSettings.DependencyType))]
    public static T ClearDependencyType<T>(this T o) where T : KiotaInfoSettings => o.Modify(b => b.ClearCollection(() => o.DependencyType));
    #endregion
}
#endregion
#region KiotaUpdateSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaUpdate(MLgentDev.Nuke.Common.Tools.Kiota.KiotaUpdateSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaUpdateSettingsExtensions
{
    #region Output
    /// <inheritdoc cref="KiotaUpdateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.Output))]
    public static T SetOutput<T>(this T o, string v) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.Output, v));
    /// <inheritdoc cref="KiotaUpdateSettings.Output"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.Output))]
    public static T ResetOutput<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Remove(() => o.Output));
    #endregion
    #region LogLevel
    /// <inheritdoc cref="KiotaUpdateSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaUpdateSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
    #region CleanOutput
    /// <inheritdoc cref="KiotaUpdateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.CleanOutput))]
    public static T SetCleanOutput<T>(this T o, bool? v) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.CleanOutput, v));
    /// <inheritdoc cref="KiotaUpdateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.CleanOutput))]
    public static T ResetCleanOutput<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Remove(() => o.CleanOutput));
    /// <inheritdoc cref="KiotaUpdateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.CleanOutput))]
    public static T EnableCleanOutput<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.CleanOutput, true));
    /// <inheritdoc cref="KiotaUpdateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.CleanOutput))]
    public static T DisableCleanOutput<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.CleanOutput, false));
    /// <inheritdoc cref="KiotaUpdateSettings.CleanOutput"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.CleanOutput))]
    public static T ToggleCleanOutput<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.CleanOutput, !o.CleanOutput));
    #endregion
    #region ClearCache
    /// <inheritdoc cref="KiotaUpdateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.ClearCache))]
    public static T SetClearCache<T>(this T o, bool? v) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.ClearCache, v));
    /// <inheritdoc cref="KiotaUpdateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.ClearCache))]
    public static T ResetClearCache<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Remove(() => o.ClearCache));
    /// <inheritdoc cref="KiotaUpdateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.ClearCache))]
    public static T EnableClearCache<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.ClearCache, true));
    /// <inheritdoc cref="KiotaUpdateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.ClearCache))]
    public static T DisableClearCache<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.ClearCache, false));
    /// <inheritdoc cref="KiotaUpdateSettings.ClearCache"/>
    [Pure] [Builder(Type = typeof(KiotaUpdateSettings), Property = nameof(KiotaUpdateSettings.ClearCache))]
    public static T ToggleClearCache<T>(this T o) where T : KiotaUpdateSettings => o.Modify(b => b.Set(() => o.ClearCache, !o.ClearCache));
    #endregion
}
#endregion
#region KiotaLoginGithubDeviceSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaLoginGithubDevice(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubDeviceSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaLoginGithubDeviceSettingsExtensions
{
    #region LogLevel
    /// <inheritdoc cref="KiotaLoginGithubDeviceSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaLoginGithubDeviceSettings), Property = nameof(KiotaLoginGithubDeviceSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaLoginGithubDeviceSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaLoginGithubDeviceSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaLoginGithubDeviceSettings), Property = nameof(KiotaLoginGithubDeviceSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaLoginGithubDeviceSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
}
#endregion
#region KiotaLoginGithubPatSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaLoginGithubPat(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLoginGithubPatSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaLoginGithubPatSettingsExtensions
{
    #region LogLevel
    /// <inheritdoc cref="KiotaLoginGithubPatSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaLoginGithubPatSettings), Property = nameof(KiotaLoginGithubPatSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaLoginGithubPatSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaLoginGithubPatSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaLoginGithubPatSettings), Property = nameof(KiotaLoginGithubPatSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaLoginGithubPatSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
    #region Pat
    /// <inheritdoc cref="KiotaLoginGithubPatSettings.Pat"/>
    [Pure] [Builder(Type = typeof(KiotaLoginGithubPatSettings), Property = nameof(KiotaLoginGithubPatSettings.Pat))]
    public static T SetPat<T>(this T o, [Secret] string v) where T : KiotaLoginGithubPatSettings => o.Modify(b => b.Set(() => o.Pat, v));
    /// <inheritdoc cref="KiotaLoginGithubPatSettings.Pat"/>
    [Pure] [Builder(Type = typeof(KiotaLoginGithubPatSettings), Property = nameof(KiotaLoginGithubPatSettings.Pat))]
    public static T ResetPat<T>(this T o) where T : KiotaLoginGithubPatSettings => o.Modify(b => b.Remove(() => o.Pat));
    #endregion
}
#endregion
#region KiotaLogoutGithubSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaLogoutGithub(MLgentDev.Nuke.Common.Tools.Kiota.KiotaLogoutGithubSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaLogoutGithubSettingsExtensions
{
    #region LogLevel
    /// <inheritdoc cref="KiotaLogoutGithubSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaLogoutGithubSettings), Property = nameof(KiotaLogoutGithubSettings.LogLevel))]
    public static T SetLogLevel<T>(this T o, LogLevel v) where T : KiotaLogoutGithubSettings => o.Modify(b => b.Set(() => o.LogLevel, v));
    /// <inheritdoc cref="KiotaLogoutGithubSettings.LogLevel"/>
    [Pure] [Builder(Type = typeof(KiotaLogoutGithubSettings), Property = nameof(KiotaLogoutGithubSettings.LogLevel))]
    public static T ResetLogLevel<T>(this T o) where T : KiotaLogoutGithubSettings => o.Modify(b => b.Remove(() => o.LogLevel));
    #endregion
}
#endregion
#region KiotaRpcSettingsExtensions
/// <inheritdoc cref="KiotaTasks.KiotaRpc(MLgentDev.Nuke.Common.Tools.Kiota.KiotaRpcSettings)"/>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class KiotaRpcSettingsExtensions
{
    #region Mode
    /// <inheritdoc cref="KiotaRpcSettings.Mode"/>
    [Pure] [Builder(Type = typeof(KiotaRpcSettings), Property = nameof(KiotaRpcSettings.Mode))]
    public static T SetMode<T>(this T o, RpcMode v) where T : KiotaRpcSettings => o.Modify(b => b.Set(() => o.Mode, v));
    /// <inheritdoc cref="KiotaRpcSettings.Mode"/>
    [Pure] [Builder(Type = typeof(KiotaRpcSettings), Property = nameof(KiotaRpcSettings.Mode))]
    public static T ResetMode<T>(this T o) where T : KiotaRpcSettings => o.Modify(b => b.Remove(() => o.Mode));
    #endregion
    #region PipeName
    /// <inheritdoc cref="KiotaRpcSettings.PipeName"/>
    [Pure] [Builder(Type = typeof(KiotaRpcSettings), Property = nameof(KiotaRpcSettings.PipeName))]
    public static T SetPipeName<T>(this T o, string v) where T : KiotaRpcSettings => o.Modify(b => b.Set(() => o.PipeName, v));
    /// <inheritdoc cref="KiotaRpcSettings.PipeName"/>
    [Pure] [Builder(Type = typeof(KiotaRpcSettings), Property = nameof(KiotaRpcSettings.PipeName))]
    public static T ResetPipeName<T>(this T o) where T : KiotaRpcSettings => o.Modify(b => b.Remove(() => o.PipeName));
    #endregion
}
#endregion
#region GenerationLanguage
/// <summary>Used within <see cref="KiotaTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<GenerationLanguage>))]
public partial class GenerationLanguage : Enumeration
{
    public static GenerationLanguage CSharp = (GenerationLanguage) "CSharp";
    public static GenerationLanguage Java = (GenerationLanguage) "Java";
    public static GenerationLanguage TypeScript = (GenerationLanguage) "TypeScript";
    public static GenerationLanguage PHP = (GenerationLanguage) "PHP";
    public static GenerationLanguage Python = (GenerationLanguage) "Python";
    public static GenerationLanguage Go = (GenerationLanguage) "Go";
    public static GenerationLanguage Swift = (GenerationLanguage) "Swift";
    public static GenerationLanguage Ruby = (GenerationLanguage) "Ruby";
    public static GenerationLanguage CLI = (GenerationLanguage) "CLI";
    public static GenerationLanguage Dart = (GenerationLanguage) "Dart";
    public static GenerationLanguage HTTP = (GenerationLanguage) "HTTP";
    public static implicit operator GenerationLanguage(string value)
    {
        return new GenerationLanguage { Value = value };
    }
}
#endregion
#region AccessModifier
/// <summary>Used within <see cref="KiotaTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<AccessModifier>))]
public partial class AccessModifier : Enumeration
{
    public static AccessModifier Private = (AccessModifier) "Private";
    public static AccessModifier Protected = (AccessModifier) "Protected";
    public static AccessModifier Public = (AccessModifier) "Public";
    public static AccessModifier Internal = (AccessModifier) "Internal";
    public static implicit operator AccessModifier(string value)
    {
        return new AccessModifier { Value = value };
    }
}
#endregion
#region LogLevel
/// <summary>Used within <see cref="KiotaTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<LogLevel>))]
public partial class LogLevel : Enumeration
{
    public static LogLevel Trace = (LogLevel) "Trace";
    public static LogLevel Debug = (LogLevel) "Debug";
    public static LogLevel Information = (LogLevel) "Information";
    public static LogLevel Warning = (LogLevel) "Warning";
    public static LogLevel Error = (LogLevel) "Error";
    public static LogLevel Critical = (LogLevel) "Critical";
    public static LogLevel None = (LogLevel) "None";
    public static implicit operator LogLevel(string value)
    {
        return new LogLevel { Value = value };
    }
}
#endregion
#region DependencyType
/// <summary>Used within <see cref="KiotaTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<DependencyType>))]
public partial class DependencyType : Enumeration
{
    public static DependencyType Abstractions = (DependencyType) "Abstractions";
    public static DependencyType Serialization = (DependencyType) "Serialization";
    public static DependencyType Authentication = (DependencyType) "Authentication";
    public static DependencyType Http = (DependencyType) "Http";
    public static DependencyType Bundle = (DependencyType) "Bundle";
    public static DependencyType Additional = (DependencyType) "Additional";
    public static implicit operator DependencyType(string value)
    {
        return new DependencyType { Value = value };
    }
}
#endregion
#region RpcMode
/// <summary>Used within <see cref="KiotaTasks"/>.</summary>
[PublicAPI]
[Serializable]
[ExcludeFromCodeCoverage]
[TypeConverter(typeof(TypeConverter<RpcMode>))]
public partial class RpcMode : Enumeration
{
    public static RpcMode Stdio = (RpcMode) "Stdio";
    public static RpcMode NamedPipe = (RpcMode) "NamedPipe";
    public static implicit operator RpcMode(string value)
    {
        return new RpcMode { Value = value };
    }
}
#endregion
