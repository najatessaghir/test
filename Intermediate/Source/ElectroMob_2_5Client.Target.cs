using UnrealBuildTool;

public class ElectroMob_2_5ClientTarget : TargetRules
{
	public ElectroMob_2_5ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ElectroMob_2_5");
	}
}
