using LaunchpadReloaded.Features;
using LaunchpadReloaded.Options.Modifiers;
using LaunchpadReloaded.Options.Modifiers.Crewmate;
using LaunchpadReloaded.Utilities;
using MiraAPI.GameOptions;
using MiraAPI.Networking;
using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace LaunchpadReloaded.Modifiers.Game.Crewmate;

public class BurstModifier : LPModifier
{
    public override string ModifierName => "Burst";
    public override LoadableAsset<Sprite>? ModifierIcon => LaunchpadAssets.BurstIcon;
    public override Color FreeplayFileColor => new Color32(255, 77, 77, 255);

    public override string GetDescription() =>
        "When you die, players near you also explode!";

    public override int GetAssignmentChance() =>
        (int)OptionGroupSingleton<CrewmateModifierOptions>.Instance.BurstChance;

    public override int GetAmountPerGame() =>
        (int)OptionGroupSingleton<BurstOptions>.Instance.BurstAmount;

    public override bool ShowInFreeplay => true;

    public override void OnDeath(DeathReason deathReason)
    {
        var killer = Utils.GetKiller(Player);
        if (killer == null) return;

        float radius = OptionGroupSingleton<BurstOptions>.Instance.BurstRadius;

        var nearbyPlayers = Utils.GetClosestPlayers(Player.GetTruePosition(), radius, includeDead: false);

        foreach (var target in nearbyPlayers)
        {
            if (target.PlayerId == Player.PlayerId) continue;
            if (target.Data.IsDead || target.Data.Disconnected) continue;

            killer.RpcCustomMurder(
                target,
                createDeadBody: true,
                didSucceed: true,
                showKillAnim: false,
                playKillSound: true,
                teleportMurderer: false
            );
        }
    }
}