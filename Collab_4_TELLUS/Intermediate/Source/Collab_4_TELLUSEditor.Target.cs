using UnrealBuildTool;

public class Collab_4_TELLUSEditorTarget : TargetRules
{
	public Collab_4_TELLUSEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Collab_4_TELLUS");
	}
}
