// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.
using UnrealBuildTool;

public class xlnt : ModuleRules
{
	public xlnt(TargetInfo Target)
	{
		Type = ModuleType.External;

		string xlntPath = UEBuildConfiguration.UEThirdPartySourceDirectory + "xlnt/";

		PublicIncludePaths.Add(xlntPath + "include");
		PublicLibraryPaths.Add(xlntPath + "lib");
		
		if (Target.Configuration == UnrealTargetConfiguration.Debug && BuildConfiguration.bDebugBuildsActuallyUseDebugCRT)
        {
			if(Target.Platform == UnrealTargetPlatform.Win64)
				PublicAdditionalLibraries.Add(xlntPath + "lib/xlnt_debug_x64.lib");
			else
				PublicAdditionalLibraries.Add(xlntPath + "lib/xlnt_debug_x86.lib");
		} else {
			if(Target.Platform == UnrealTargetPlatform.Win64)
				PublicAdditionalLibraries.Add(xlntPath + "lib/xlnt_release_x64.lib");
			else
				PublicAdditionalLibraries.Add(xlntPath + "lib/xlnt_release_x86.lib");
		}
    }
}
