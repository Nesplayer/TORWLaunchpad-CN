using LaunchpadReloaded.Options.Modifiers;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Options.Modifiers.Crewmate;
using MiraAPI.GameOptions;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace LaunchpadReloaded.Modifiers.Game.Crewmate;

public sealed class TorchModifier : LPModifier
{
    public override string ModifierName => "Torch";
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.TorchIcon;
    public override string GetDescription() => 
        OptionGroupSingleton<TorchOptions>.Instance.UseFlashlight
        ? "You will have a flashlight\nif lights are sabotaged."
        : "You have max vision\nif lights are sabotaged.";

    public override int GetAssignmentChance() => (int)OptionGroupSingleton<CrewmateModifierOptions>.Instance.TorchChance;
    public override int GetAmountPerGame() => (int)OptionGroupSingleton<TorchOptions>.Instance.TorchAmount;
}