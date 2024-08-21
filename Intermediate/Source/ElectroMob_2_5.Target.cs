using UnrealBuildTool;

public class ElectroMob_2_5Target : TargetRules
{
	public ElectroMob_2_5Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ElectroMob_2_5");
	}
}
