using System;
using TORWL.Options.Roles.Impostor;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers.Types;
using MiraAPI.Utilities.Assets;
using TORWL.Components;
using TORWL.Features;
using TORWL.Utilities;
using UnityEngine;

namespace TORWL.Modifiers;

public class ToxifiedModifier : TimedModifier
{
    public override string ModifierName => "Toxified";

    public override string GetDescription() => $"You are toxified and will die in: " +
                                               $"{Math.Round(TimeRemaining, 0)}s/{OptionGroupSingleton<ToxifierOptions>.Instance.ToxifiedDelay}s";
    
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.Toxifier;

    public override float Duration => OptionGroupSingleton<ToxifierOptions>.Instance.ToxifiedDelay;
    
    private readonly PlayerTag _toxifiedTag = new()
    {
        Name = "ToxifiedTag",
        Text = "Toxified",
        Color = LaunchpadPalette.ToxifiedColor,
        IsLocallyVisible = _ => true,
    };

    public override void OnActivate()
    {
        var tagManager = Player!.GetTagManager();

        if (tagManager != null)
        {
            var existingTag = tagManager.GetTagByName(_toxifiedTag.Name);
            if (existingTag.HasValue)
            {
                tagManager.RemoveTag(existingTag.Value);
            }

            tagManager.AddTag(_toxifiedTag);
        }

        NotifyOfToxified();
    }

    public override void OnDeath(DeathReason reason)
    {
        ModifierComponent!.RemoveModifier(this);

        NotifyOfToxifiedDeath();
    }

    public void NotifyOfToxified()
    {
        MiraAPI.Utilities.Helpers.CreateAndShowNotification(
            $"{Player.Data.PlayerName} has been Toxified, and will die soon!",
            LaunchpadPalette.ToxifiedColor,
            null,
            LaunchpadAssets.Toxifier.LoadAsset()
        ).transform.localPosition = new Vector3(0f, 1f, -20f);
    }

    public void NotifyOfToxifiedDeath()
    {
        MiraAPI.Utilities.Helpers.CreateAndShowNotification(
            $"{Player.Data.PlayerName} has died to a deadly toxin!",
            LaunchpadPalette.ToxifiedColor,
            null,
            LaunchpadAssets.Toxifier.LoadAsset()
        ).transform.localPosition = new Vector3(0f, 1f, -20f);
    }
}