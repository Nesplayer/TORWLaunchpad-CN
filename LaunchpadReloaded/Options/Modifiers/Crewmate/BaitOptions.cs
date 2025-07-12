using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using UnityEngine;
using MiraAPI.Utilities;
using System;

namespace LaunchpadReloaded.Options.Modifiers.Crewmate;

	public class BaitOptions : AbstractOptionGroup<BaitModifier>
	{
		public override string GroupName => "Bait Options";
		public override Color GroupColor => LaunchpadPalette.BaitMenu;
		
		public override Func<bool> GroupVisible =>
			() => OptionGroupSingleton<CrewmateModifierOptions>.Instance.BaitChance > 0;

		[ModdedNumberOption("Amount", 0f, 5f, 1f, suffixType: MiraNumberSuffixes.None, zeroInfinity: true)]
		public float BaitAmount { get; set; } = 1;
	}

