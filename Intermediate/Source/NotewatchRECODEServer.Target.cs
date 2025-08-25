using UnrealBuildTool;

public class NotewatchRECODEServerTarget : TargetRules
{
	public NotewatchRECODEServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("NotewatchRECODE");
	}
}
