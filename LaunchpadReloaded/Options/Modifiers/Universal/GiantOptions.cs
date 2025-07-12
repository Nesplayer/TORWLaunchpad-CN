using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers.Game.Universal;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using UnityEngine;
using MiraAPI.Utilities;
using System;

namespace LaunchpadReloaded.Options.Modifiers.Universal
{
    public class GiantOptions : AbstractOptionGroup<GiantModifier>
    {
        public override string GroupName => "Giant Options";
        public override Color GroupColor => LaunchpadPalette.GiantMenu;
        public override Func<bool> GroupVisible =>
            () => OptionGroupSingleton<UniversalModifierOptions>.Instance.GiantChance > 0;

        [ModdedNumberOption("Amount", 0f, 5f, 1f, suffixType: MiraNumberSuffixes.None, zeroInfinity: true)]
        public float GiantAmount { get; set; } = 1f;
    }
}