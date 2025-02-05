# KiotaTasks for nuke
## [kiota](https://github.com/microsoft/kiota) tool integration for [nuke](https://github.com/nuke-build/nuke)

## Project Status: Minimal Support
This project is provided as-is, with no guarantee of ongoing support or active development. While I may make occasional improvements when I have time, I do not actively maintain or provide support for this library.

### Contributions & Issues
* Feel free to submit pull requests if you’d like to improve the project.
* Issues can be reported, but I may not respond or address them in a timely manner.
* If you're interested in taking over maintenance, feel free to open a discussion.

## Usage
Install [kiota](https://github.com/microsoft/kiota) as a global tool
```shell
dotnet tool install --global Microsoft.OpenApi.Kiota
```
Add package to the project
```shell
dotnet add package MLgentDev.Nuke.Kiota --version 0.1.0
```
Example
```csharp
using MLgentDev.Nuke.Common.Tools.Kiota;
...
KiotaTasks.KiotaGenerate(options => options
    .SetLanguage(GenerationLanguage.CSharp)
    .SetNamespaceName("Namespace")
    .SetClassName("Client")
    .SetOpenapi("path/to/openapi")
    .SetOutput("path/to/output/folder"));
```


## Build
* [dotnet](https://dotnet.microsoft.com/en-us/) 8 and 9 should be installed

Install [nuke](https://github.com/nuke-build/nuke) 
```shell
dotnet tool install Nuke.GlobalTool --global
```

Clone [kiota](https://github.com/microsoft/kiota) repository
```shell
nuke CloneKiota
```

Install [kiota](https://github.com/microsoft/kiota) as global tool (required by tests)
```shell
dotnet tool install --global Microsoft.OpenApi.Kiota
```

Build
```shell
nuke MakeAllCi
```

## Inspired by
[Nuke.NuGetKeyVaultSignTool](https://github.com/ricaun-io/Nuke.NuGetKeyVaultSignTool) written by [ricaun](https://github.com/ricaun)
and merged to [nuke](https://github.com/nuke-build/nuke) by this pull request [Support for NuGetKeyVaultSignTool](https://github.com/nuke-build/nuke/pull/1485)

