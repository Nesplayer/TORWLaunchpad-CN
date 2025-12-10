using TORWL.Roles.Neutral;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TORWL.Options.Roles.Neutral;

public class JesterOptions : AbstractOptionGroup<JesterRole>
{
    public override string GroupName => "Jester";

    [ModdedToggleOption("Can Use Vents")]
    public bool CanUseVents { get; set; } = true;
}