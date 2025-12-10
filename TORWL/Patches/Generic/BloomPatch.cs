using HarmonyLib;
using TORWL.Features;
using MiraAPI.LocalSettings;

namespace TORWL.Patches.Generic;

[HarmonyPatch(typeof(FollowerCamera), nameof(FollowerCamera.SnapToTarget))]
public static class BloomPatch
{
    public static void Postfix()
    {
        LaunchpadSettings.SetBloom(LocalSettingsTabSingleton<LaunchpadSettings>.Instance.Bloom.Value);
    }
}