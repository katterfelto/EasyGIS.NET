#tool nuget:?package=NUnit.ConsoleRunner&version=3.12.0
#addin nuget:?package=Cake.FileHelpers&version=3.4.0
#addin nuget:?package=Cake.ExtendedNuGet&version=3.0.0

var solutionName = "EasyGISDesktop";

//////////////////////////////////////////////////////////////////////
// Additional solution constants
//////////////////////////////////////////////////////////////////////

var solutionFile = string.Format("./{0}.sln", solutionName);

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "FullBuild");
var configuration = Argument("configuration", "Release");

var publishToNuget = true; //Argument("publishtonuget", false);
var nugetserverapikey = Argument("nugetserverapikey", string.Empty);
var nugetserveraddress = Argument("nugetserveraddress", string.Empty);

var version = "0.0.0";

var nugetPackages = new List<string>();

//////////////////////////////////////////////////////////////////////
// HELPER FUNCTIONS
//////////////////////////////////////////////////////////////////////

private void PublishToNugetServer(string fileName)
{
	if (publishToNuget)
    {
	    NuGetPush(fileName, new NuGetPushSettings {
	        Source = nugetserveraddress,
	        ApiKey = nugetserverapikey
	    });
    }
}

private void DeleteFromNugetServer(string name, string version)
{
	if (publishToNuget)
    {
        if (IsNuGetPublished(name.ToLower(), version, nugetserveraddress))
        {
            NuGetDelete(name.ToLower(), version, new NuGetDeleteSettings {
                Source = nugetserveraddress,
                ApiKey = nugetserverapikey
            });
        }        
        CleanDirectory($"../Packages/{name.ToLower()}");
    }
}

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() => {
        //CleanDirectory("./EGIS.Controls/bin");
        //CleanDirectory("./EGIS.ShapeFileLib/bin");
        //CleanDirectory("./ShapeFileTools/bin");
		
		// Need to get version here
        version = System.IO.File.ReadAllText("./version.txt");

        // Remove from nuget server if this version exists
        DeleteFromNugetServer($"EGIS.Controls", version);
        DeleteFromNugetServer($"EGIS.Projections", version);
        DeleteFromNugetServer($"EGIS.ShapeFileLib", version);
    });

Task("Restore")
    .IsDependentOn("Clean");
    // .Does(() => {
    //     NuGetRestore(solutionFile);
    // });

Task("Build")
    .IsDependentOn("Restore");
    // .Does(() => {
    //     MSBuild(solutionFile, new MSBuildSettings()
    //         .SetConfiguration(configuration)
    //     );
    // });

Task("Test")
    .IsDependentOn("Build");
    // .Does(() => {
    //     NUnit3(buildDir + "/UnitTests.dll", new NUnit3Settings {
    //         Results = new[] { new NUnit3Result { FileName = buildDir + "/nunit-results.xml" } }
    //     });
    // });

Task("Publish")
    .IsDependentOn("Test")
    .Does(() => {
        PublishToNugetServer($"./EGIS.Controls/bin/Release/EGIS.Controls.{version}.nupkg");
        PublishToNugetServer($"./EGIS.Projections/bin/Release/EGIS.Projections.{version}.nupkg");
        PublishToNugetServer($"./EGIS.ShapeFileLib/bin/Release/EGIS.ShapeFileLib.{version}.nupkg");
    })
    .DeferOnError();

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("FullBuild")
    .IsDependentOn("Publish");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);