# json to csharp converter

this is a simple web interface for http://jsonclassgenerator.codeplex.com/ based on .netcore 

## installation 
following

## usage 
following

## init on my compute

### environment  windows10 git

```
	cd e:\1git

	git clone https://github.com/wangengzheng/json2csharp
	//output #git clone

	cd json2csharp

	dotnet restore     
	//output #restore

	dotnet run
	//output #run
```



##output #restore

```
dotnet restore
Restoring packages for E:\1git\json2csharp\Json2CSharp.Web\Json2CSharp.Web.csproj...
Restoring packages for E:\1git\json2csharp\Json2CSharp.Web\Json2CSharp.Web.csproj...
Restoring packages for E:\1git\json2csharp\Json2CSharp.Lib\Json2CSharp.Lib.csproj...
Generating MSBuild file E:\1git\json2csharp\Json2CSharp.Lib\obj\Json2CSharp.Lib.csproj.nuget.g.props.
Generating MSBuild file E:\1git\json2csharp\Json2CSharp.Lib\obj\Json2CSharp.Lib.csproj.nuget.g.targets.
Writing lock file to disk. Path: E:\1git\json2csharp\Json2CSharp.Lib\obj\project.assets.json
Restore completed in 1.25 sec for E:\1git\json2csharp\Json2CSharp.Lib\Json2CSharp.Lib.csproj.
Installing Microsoft.AspNetCore.StaticFiles 1.1.2.
Generating MSBuild file E:\1git\json2csharp\Json2CSharp.Web\obj\Json2CSharp.Web.csproj.nuget.g.props.
Generating MSBuild file E:\1git\json2csharp\Json2CSharp.Web\obj\Json2CSharp.Web.csproj.nuget.g.targets.
Writing lock file to disk. Path: E:\1git\json2csharp\Json2CSharp.Web\obj\project.assets.json
Restore completed in 9.23 sec for E:\1git\json2csharp\Json2CSharp.Web\Json2CSharp.Web.csproj.
Installing Microsoft.NETCore.Targets 1.0.3.
Installing Microsoft.NETCore.Jit 1.0.7.
Installing System.Net.Http 4.1.2.
Installing System.Net.Security 4.0.1.
Installing runtime.native.System.Security.Cryptography 4.0.1.
Installing Microsoft.NETCore.Runtime.CoreCLR 1.0.7.
Installing Microsoft.NETCore.DotNetHostPolicy 1.0.5.
Installing Microsoft.NETCore.App 1.0.5.
Installing Microsoft.VisualStudio.Web.CodeGeneration.Tools 1.0.1.
Restore completed in 2.14 min for E:\1git\json2csharp\Json2CSharp.Web\Json2CSharp.Web.csproj.

NuGet Config files used:
C:\Users\Administrator\AppData\Roaming\NuGet\NuGet.Config
C:\Program Files (x86)\NuGet\Config\Microsoft.VisualStudio.Offline.config

Feeds used:
https://www.nuget.org/api/v2/
C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\

	Installed:
	10 package(s) to E:\1git\json2csharp\Json2CSharp.Web\Json2CSharp.Web.csproj

```



##output #run

```

$ dotnet run
Controllers\Json2CSharpController.cs(42,30): warning CS0168: The variable 'e' is declared but never used [E:\1git\json2csharp\Json2CSharp.Web\Json2CSharp.Web.csproj]
Controllers\Json2CSharpController.cs(17,42): warning CS1998: This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread. [E:\1git\json2csharp\Json2CSharp.Web\Json2CSharp.Web.csproj]
Hosting environment: Production
Content root path: E:\1git\json2csharp\Json2CSharp.Web
Now listening on: http://localhost:5002
Application started. Press Ctrl+C to shut down.

```



##output #git clone


```

$ git clone https://github.com/wangengzheng/json2csharp
Cloning into 'json2csharp'...
remote: Counting objects: 127, done.
remote: Compressing objects: 100% (70/70), done.
remote:R Total 127 (delta 51), reuseed 127 (delta 51), pack-reused 0
Receiving objects: 100% (127/127), 37.48 KiB | 4.00 KiB/s, done.
Resolving deltas: 100% (51/51), done.
Checking connectivity... done.


```
