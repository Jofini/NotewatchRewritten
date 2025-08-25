using UnrealBuildTool;

public class NotewatchRECODEEditorTarget : TargetRules
{
	public NotewatchRECODEEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("NotewatchRECODE");
	}
}
