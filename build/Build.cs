using Nuke.Common;
using Nuke.Common.Tools.GitVersion;
using Serilog;

public class Build : NukeBuild
{
    [GitVersion] GitVersion _gitVersion;

    public static void Main() => Execute<Build>(_ => _.ShowVersion);

    Target ShowVersion => _ => _
        .Executes(() =>
        {
            Log.Logger.Information("SemVer: {SemVer}", _gitVersion.SemVer);
            Log.Logger.Information("AssemblySemVer: {AssemblySemVer}", _gitVersion.AssemblySemVer);
            Log.Logger.Information("AssemblyFileVersion: {AssemblyFileVersion}", _gitVersion.AssemblySemFileVer);
            Log.Logger.Information("InformationalVersion: {InformationalVersion}", _gitVersion.InformationalVersion);
            Log.Logger.Information("NuGetVersion: {NuGetVersion}", _gitVersion.NuGetVersion);
            Log.Logger.Information("NuGetVersionV2: {NuGetVersionV2}", _gitVersion.NuGetVersionV2);
        });
}
