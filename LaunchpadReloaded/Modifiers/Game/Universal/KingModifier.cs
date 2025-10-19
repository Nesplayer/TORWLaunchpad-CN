using LaunchpadReloaded.Components;
using LaunchpadReloaded.Options.Modifiers.Universal;
using LaunchpadReloaded.Options.Modifiers;
using LaunchpadReloaded.Features;
using MiraAPI.Utilities.Assets;
using UnityEngine;
using MiraAPI.GameOptions;

namespace LaunchpadReloaded.Modifiers.Game.Universal;

public sealed class KingModifier : LPModifier
{
    public override string ModifierName => "V.I.P";
    public override Color FreeplayFileColor => new Color32(255, 215, 0, 255);
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.VIPIcon;
    public override int GetAssignmentChance() => (int)OptionGroupSingleton<UniversalModifierOptions>.Instance.KingChance;
    public override int GetAmountPerGame() => (int)OptionGroupSingleton<KingOptions>.Instance.KingAmount;

    public override string GetDescription()
    {
        return "You just look fancy!";
    }

    public override void OnActivate()
    {
        PlayerControl.LocalPlayer.RpcSetHat("hat_NewYear2024");
        PlayerControl.LocalPlayer.RpcSetSkin("skin_Bling");
        PlayerControl.LocalPlayer.RpcSetVisor("visor_masque_white");
    }

    public override void OnDeactivate()
    {
        PlayerControl.LocalPlayer.RpcSetHat("");
        PlayerControl.LocalPlayer.RpcSetSkin("");
        PlayerControl.LocalPlayer.RpcSetVisor("");
    }
}