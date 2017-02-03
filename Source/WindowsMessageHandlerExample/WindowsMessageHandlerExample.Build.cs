// Copyright 2008-2015 Deep Cove Software Ltd. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	using System.IO;
	
	public class WindowsMessageHandlerExample : ModuleRules
	{
		public WindowsMessageHandlerExample(ReadOnlyTargetRules Target) : base(Target)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"Core",
                    "Slate",
				}
			);

			PrivateIncludePaths.AddRange(
				new string[] {
					"WindowsMessageHandlerExample/Private",
				}
			);
		}
	}
}
