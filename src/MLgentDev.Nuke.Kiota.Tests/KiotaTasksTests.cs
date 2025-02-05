using MLgentDev.Nuke.Common.Tools.Kiota;

namespace MLgentDev.Nuke.Kiota.Tests;

[TestFixture]
public class KiotaTasksTests
{
    [Test]
    public void Generate_ShouldWork()
    {
        // var directory = Directory.GetCurrentDirectory();
        var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetAssembly(typeof(KiotaTasks))!.Location)!;
        var postsApiYml = Path.Combine(directory, "posts-api.yml");
        var postsApiCs = Path.Combine(directory, "posts-api");
        
        if (Directory.Exists(postsApiCs)) Directory.Delete(postsApiCs, true);
        
        if (!File.Exists(postsApiYml)) Assert.Fail("no input file found");
        if (Directory.Exists(postsApiCs)) Assert.Fail("output dir already exists");

        KiotaTasks.KiotaGenerate(options => options
            .SetLanguage(GenerationLanguage.CSharp)
            .SetNamespaceName("KiotaPosts.Client")
            .SetClassName("PostsClient")
            .SetOpenapi(postsApiYml)
            .SetOutput(postsApiCs));
        
        if (!Directory.Exists(postsApiCs)) Assert.Fail("no output dir found");
    }
}