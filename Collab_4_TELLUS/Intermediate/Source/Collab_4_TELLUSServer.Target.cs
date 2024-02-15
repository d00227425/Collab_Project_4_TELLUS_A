using UnrealBuildTool;

public class Collab_4_TELLUSServerTarget : TargetRules
{
	public Collab_4_TELLUSServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Collab_4_TELLUS");
	}
}
