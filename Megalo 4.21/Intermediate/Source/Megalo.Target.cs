using UnrealBuildTool;

public class MegaloTarget : TargetRules
{
	public MegaloTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Megalo");
	}
}
