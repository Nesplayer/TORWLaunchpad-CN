using LaunchpadReloaded.Features;
using LaunchpadReloaded.Options.Modifiers;
using LaunchpadReloaded.Options.Modifiers.Crewmate;
using MiraAPI.Utilities.Assets;
using MiraAPI.Events;
using MiraAPI.Events.Vanilla.Gameplay;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers;
using MiraAPI.Modifiers.Types;
using UnityEngine;

namespace LaunchpadReloaded.Modifiers;

public class BaitModifier : GameModifier
{
    public override string ModifierName => "Bait";
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.BaitIcon;
    public override Color FreeplayFileColor => new Color32(77, 166, 255, 255);

    public override int GetAmountPerGame()
    {
        return (int)OptionGroupSingleton<BaitOptions>.Instance.BaitAmount;
    }

    public override int GetAssignmentChance()
    {
        return (int)OptionGroupSingleton<CrewmateModifierOptions>.Instance.BaitChance;
    }

    public override string GetDescription()
    {
        return "Your killer self-reports after you are killed!";
    }

    [RegisterEvent]
    public static void OnKill(AfterMurderEvent e)
    {
        if (ModifierExtensions.HasModifier<BaitModifier>(e.Target))
        {
            e.Source.CmdReportDeadBody(e.Target.Data);
        }
    }
}