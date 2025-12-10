using HarmonyLib;
using TORWL.Components;

namespace TORWL.Patches.Generic;

[HarmonyPatch(typeof(GameManager), nameof(GameManager.Awake))]
public static class GameManagerPatch
{
    public static void Postfix(GameManager __instance)
    {
        foreach (var deadBody in __instance.deadBodyPrefab)
        {
            deadBody.gameObject.AddComponent<DeadBodyCacheComponent>();
        }
    }
}