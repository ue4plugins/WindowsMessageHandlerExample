// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	using System.IO;

	public class WindowsMessageHandlerExample : ModuleRules
	{
		public WindowsMessageHandlerExample(ReadOnlyTargetRules Target) : base(Target)
		{
			PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"Core",
					"Slate",
					"SlateCore",
				});

			PrivateIncludePaths.AddRange(
				new string[] {
					"WindowsMessageHandlerExample/Private",
				});
		}
	}
}
