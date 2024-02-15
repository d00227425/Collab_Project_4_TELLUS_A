using UnrealBuildTool;

public class Collab_4_TELLUSTarget : TargetRules
{
	public Collab_4_TELLUSTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Collab_4_TELLUS");
	}
}
