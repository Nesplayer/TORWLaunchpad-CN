using LaunchpadReloaded.Options.Modifiers;
using LaunchpadReloaded.Options.Modifiers.Universal;
using LaunchpadReloaded.Features;
using MiraAPI.Utilities.Assets;
using UnityEngine;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers;

namespace LaunchpadReloaded.Modifiers.Game.Universal;

public sealed class SmolModifier : LPModifier
{
    public override string ModifierName => "Smol";
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.MiniIcon;
    public override string GetDescription() => "You are smaller than\nthe average player.";
    public override int GetAssignmentChance() => (int)OptionGroupSingleton<UniversalModifierOptions>.Instance.SmolChance;
    public override int GetAmountPerGame() => (int)OptionGroupSingleton<SmolOptions>.Instance.SmolAmount;
    public override bool IsModifierValidOn(RoleBehaviour role) => base.IsModifierValidOn(role) && !role.Player.HasModifier<GiantModifier>();

    public override void OnActivate()
    {
        Player.MyPhysics.Speed /= 0.75f;
        Player.transform.localScale *= 0.7f;
    }

    public override void OnDeactivate()
    {
        Player.MyPhysics.Speed *= 0.75f;
        Player.transform.localScale /= 0.7f;
    }
}