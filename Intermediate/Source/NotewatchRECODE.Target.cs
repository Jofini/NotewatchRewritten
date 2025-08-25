using UnrealBuildTool;

public class NotewatchRECODETarget : TargetRules
{
	public NotewatchRECODETarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("NotewatchRECODE");
	}
}
