using HarmonyLib;
using LaunchpadReloaded.Features;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Rewired.Platforms.Custom;

namespace LaunchpadReloaded.Patches
{
    [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
    public static class MainMenuPatch
    {
        public static void Postfix(MainMenuManager __instance)
        {
            SetButtonColor(__instance.playButton, true);
            SetButtonColor(__instance.inventoryButton, true);
            SetButtonColor(__instance.shopButton, true);
            SetButtonColor(__instance.newsButton, false);
            SetButtonColor(__instance.myAccountButton, false);
            SetButtonColor(__instance.accountCTAButton, true);
            SetButtonColor(__instance.accountStatsButton, true);
            SetButtonColor(__instance.settingsButton, false);
            SetButtonColor(__instance.creditsButton, false);
            SetButtonColor(__instance.quitButton, false);
        }

        private static void SetButtonColor(PassiveButton Button, bool shine)
        {
            Button.activeSprites.GetComponent<SpriteRenderer>().color = Palette.AcceptedGreen;
            Button.inactiveSprites.GetComponent<SpriteRenderer>().color = Palette.ImpostorRoleRed;
            Button.activeTextColor = Palette.ImpostorRoleRed;
            Button.inactiveTextColor = Palette.AcceptedGreen;
            if (shine)
            {
                Button.activeSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;
                Button.inactiveSprites.transform.GetChild(1).GetComponent<SpriteRenderer>().color = Color.clear;  
            }
        }
    }
}