using System;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers.Game.Crewmate;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.PluginLoading;
using MiraAPI.Utilities;
using UnityEngine;

namespace LaunchpadReloaded.Options.Modifiers.Crewmate;

[MiraIgnore]
public class VendettaOptions : AbstractOptionGroup<VendettaModifier>
{
    public override string GroupName => "Vendetta";
    public override Color GroupColor => LaunchpadPalette.VendettaMenu;
    public override Func<bool> GroupVisible =>
        () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.VendettaChance > 0;
    
    [ModdedNumberOption("Amount", 0f, 5f, 1f, suffixType: MiraNumberSuffixes.None, zeroInfinity: true)]
    public float VendettaAmount { get; set; } = 1;

    [ModdedNumberOption("Mark Cooldown", 5, 40, 2.5f, MiraNumberSuffixes.Seconds)]
    public float MarkCooldown { get; set; } = 15;
    
    [ModdedNumberOption("Marks Per Round", 1, 3, 1f)]
    public float MarkUses { get; set; } = 1;
}