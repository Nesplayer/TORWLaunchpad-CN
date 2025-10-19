using LaunchpadReloaded.Options.Modifiers;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Options.Modifiers.Universal;
using MiraAPI.Utilities.Assets;
using UnityEngine;
using MiraAPI.GameOptions;

namespace LaunchpadReloaded.Modifiers.Game.Universal;

public sealed class FlashModifier : LPModifier
{
    public override string ModifierName => "Flash";
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.FlashIcon;
    public override int GetAssignmentChance() => (int)OptionGroupSingleton<UniversalModifierOptions>.Instance.FlashChance;
    public override int GetAmountPerGame() => (int)OptionGroupSingleton<FlashOptions>.Instance.FlashAmount;
    public override Color FreeplayFileColor => Color.yellow;

    public override string GetDescription()
    {
        return "You are faster than other players!";
    }

    public override void OnActivate()
    {
        if (Player != null)
        {
            Player.MyPhysics.Speed /= 0.75f;
        }
    }

    public override void OnDeactivate()
    {
        if (Player != null)
        {
            Player.MyPhysics.Speed *= 0.75f;
        }
    }
}