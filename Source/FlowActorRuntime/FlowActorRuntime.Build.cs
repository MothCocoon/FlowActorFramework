// Copyright https://github.com/MothCocoon/FlowGraph/graphs/contributors
using UnrealBuildTool;

public class FlowActorRuntime : ModuleRules
{
	public FlowActorRuntime(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
		[
			"Core",
			"CoreUObject",
			"DeveloperSettings",
			"Engine",
			"Flow",
			"NavigationSystem",
		]);

	}
}
