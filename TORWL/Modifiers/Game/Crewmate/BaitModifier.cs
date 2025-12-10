using TORWL.Features;
using TORWL.Options.Modifiers;
using TORWL.Options.Modifiers.Crewmate;
using MiraAPI.Utilities.Assets;
using MiraAPI.Events;
using MiraAPI.Events.Vanilla.Gameplay;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers;
using MiraAPI.Modifiers.Types;
using UnityEngine;
using Reactor.Utilities.Extensions;
using TORWL.Utilities;

namespace TORWL.Modifiers.Game.Crewmate;

public class BaitModifier : GameModifier
{
    public override string ModifierName => $"<color=#{LaunchpadPalette.Bait.ToHtmlStringRGBA()}>Bait</color>";
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.BaitIcon;
    public override Color FreeplayFileColor => LaunchpadPalette.Bait;

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

    public override bool IsModifierValidOn(RoleBehaviour role)
    {
        return base.IsModifierValidOn(role) && role.IsCrewmate();
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