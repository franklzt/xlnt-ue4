// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.
using UnrealBuildTool;

public class xlnt : ModuleRules
{
	public xlnt(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;

		string xlntPath = Target.UEThirdPartySourceDirectory + "xlnt/";

		PublicIncludePaths.Add(xlntPath + "include");
		PublicLibraryPaths.Add(xlntPath + "lib");
		
		if (Target.Configuration == UnrealTargetConfiguration.Debug || Target.Configuration ==  UnrealTargetConfiguration.DebugGame)
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
