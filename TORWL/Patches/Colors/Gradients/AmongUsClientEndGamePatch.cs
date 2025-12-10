using System.Collections.Generic;
using HarmonyLib;
using TORWL.Features.Managers;

namespace TORWL.Patches.Colors.Gradients;

[HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnGameEnd))]
public static class AmongUsClientEndGamePatch
{
    public static Dictionary<string, byte> PlayerGradientCache { get; } = [];

    public static void Prefix()
    {
        foreach (var player in GameData.Instance.AllPlayers)
        {
            if (GradientManager.TryGetColor(player.PlayerId, out var color))
            {
                PlayerGradientCache[player.PlayerName] = color;
            }
        }
    }
}