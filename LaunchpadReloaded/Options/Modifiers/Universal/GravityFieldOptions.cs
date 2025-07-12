using System;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers.Game.Universal;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using UnityEngine;

namespace LaunchpadReloaded.Options.Modifiers.Universal;

public class GravityFieldOptions : AbstractOptionGroup<GravityModifier>
{
    public override string GroupName => "Gravity Field";
    public override Color GroupColor => LaunchpadPalette.GravityMenu;
    public override Func<bool> GroupVisible =>
        () => OptionGroupSingleton<UniversalModifierOptions>.Instance.GravityChance > 0;
    
    [ModdedNumberOption("Amount", 0f, 5f, 1f, suffixType: MiraNumberSuffixes.None, zeroInfinity: true)]
    public float GravityAmount { get; set; } = 1f;

    [ModdedNumberOption("Gravity Field Radius", 0.5f, 10f, 0.5f, suffixType: MiraNumberSuffixes.None)]
    public float FieldRadius { get; set; } = 2f;
}