using UnrealBuildTool;

public class Collab_4_TELLUSClientTarget : TargetRules
{
	public Collab_4_TELLUSClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Collab_4_TELLUS");
	}
}
