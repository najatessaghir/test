using UnrealBuildTool;

public class ElectroMob_2_5EditorTarget : TargetRules
{
	public ElectroMob_2_5EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ElectroMob_2_5");
	}
}
