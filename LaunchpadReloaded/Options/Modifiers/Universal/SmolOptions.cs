using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers.Game.Universal;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using UnityEngine;
using MiraAPI.Utilities;
using System;

namespace LaunchpadReloaded.Options.Modifiers.Universal
{
    public class SmolOptions : AbstractOptionGroup<SmolModifier>
    {
        public override string GroupName => "Smol Options";
        public override Color GroupColor => LaunchpadPalette.SmolMenu;
        public override Func<bool> GroupVisible =>
            () => OptionGroupSingleton<UniversalModifierOptions>.Instance.SmolChance > 0;

        [ModdedNumberOption("Amount", 0f, 5f, 1f, suffixType: MiraNumberSuffixes.None, zeroInfinity: true)]
        public float SmolAmount { get; set; } = 1f;
    }
}