using UnrealBuildTool;

public class NotewatchRECODEClientTarget : TargetRules
{
	public NotewatchRECODEClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("NotewatchRECODE");
	}
}
