// Insiration from https://github.com/CallOfCreator/NewMod/blob/main/NewMod/DiscordStatus.cs

using System;
using Discord;
using HarmonyLib;
using MiraAPI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LaunchpadReloaded.Patches.Generic;

/// <summary>
/// Custom Discord RPC
/// </summary>
[HarmonyPatch]
public static class DiscordManagerPatch
{
    private const long ClientId = 1358783916827344902;
    private const uint SteamAppId = 945360;

    [HarmonyPrefix]
    [HarmonyPatch(typeof(DiscordManager), nameof(DiscordManager.Start))]
    public static bool DiscordManagerStartPrefix(DiscordManager __instance)
    {
        DiscordManager.ClientId = ClientId;
        if (Application.platform == RuntimePlatform.Android)
        {
            return true;
        }

        InitializeDiscord(__instance);
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ActivityManager), nameof(ActivityManager.UpdateActivity))]
    public static void ActivityManagerUpdateActivityPrefix(ActivityManager __instance, [HarmonyArgument(0)] Activity activity)
    {
        // Always set base state info
        activity.State = (activity.State ?? "") + " | dsc.gg/tor-w";
        activity.Assets = new ActivityAssets()
        {
            LargeImage = "background",
            SmallImage = "background",
            SmallText = "Made with MiraAPI"
        };

        try
        {
            if (activity.State.Contains("In Lobby"))
            {
                // Replace details completely when in a lobby
                int maxPlayers = GameOptionsManager.Instance?.currentNormalGameOptions?.MaxPlayers ?? 10;
                var lobbyCode = GameStartManager.Instance?.GameRoomNameCode?.text ?? "N/A";
                var lobbyRegion = ServerManager.Instance?.CurrentRegion?.Name ?? "Unknown";
                var miraVersion = MiraApiPlugin.Version;
                var platform = Application.platform;

                activity.Details = $"Lobby: {lobbyCode} | Region: {lobbyRegion} | Max: {maxPlayers} | MiraAPI: {miraVersion} | {platform}";
            }
            if (activity.State.Contains("Freeplay"))
            {
                activity.State = "Freeplay Lobby";
            }
            else
            {
                // Default details outside lobby
                activity.Details = $"TOR-W: L v{LaunchpadReloadedPlugin.ModVersion}";
            }

            if (MeetingHud.Instance)
            {
                activity.Details += " | In Meeting";
            }
        }
        catch (Exception e)
        {
            Debug.LogError($"Discord RPC activity update failed: {e.Message}\n{e.StackTrace}");
        }
    }

    private static void InitializeDiscord(DiscordManager __instance)
    {
        __instance.presence = new Discord.Discord(ClientId, 1UL);
        var activityManager = __instance.presence.GetActivityManager();

        activityManager.RegisterSteam(SteamAppId);
        activityManager.add_OnActivityJoin((Action<string>)__instance.HandleJoinRequest);
        SceneManager.add_sceneLoaded((Action<Scene, LoadSceneMode>)((scene, _) =>
        {
            __instance.OnSceneChange(scene.name);
        }));
        __instance.SetInMenus();
    }
}
