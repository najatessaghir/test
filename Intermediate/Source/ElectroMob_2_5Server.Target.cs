using UnrealBuildTool;

public class ElectroMob_2_5ServerTarget : TargetRules
{
	public ElectroMob_2_5ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ElectroMob_2_5");
	}
}
