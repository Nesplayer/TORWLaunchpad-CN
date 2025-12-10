/*using System;
using UnityEngine;
using Reactor.Utilities.Extensions;

namespace TORWL.Features
{
    public static class ConfirmExitDialog
    {
        private static bool _shown = false;

        /// <summary>
        /// Call this once the game has finished loading.
        /// </summary>
        public static void OnGameLoaded()
        {
            if (_shown) return; // prevent multiple popups
            _shown = true;

            // Determine version type
            bool isBeta = TORWLPlugin.IsBetaBuild; // Replace with your actual beta check

            // You could modify title or behavior depending on release/beta
            string titleText = isBeta
                ? "DebugWindow has been <b>enabled</b>!"
                : "DebugWindow has been <b>disabled</b>!";

            ShowDialog(titleText);
        }

        private static void ShowDialog(string title)
        {
            var hud = DestroyableSingleton<HudManager>.Instance;
            if (hud == null || hud.LobbyTimerExtensionUI?.popup == null) return;

            // Instantiate popup
            InfoTextBox infoTextBox = UnityEngine.Object.Instantiate(
                hud.LobbyTimerExtensionUI.popup,
                hud.transform
            );
            infoTextBox.gameObject.SetActive(true);
            infoTextBox.gameObject.transform.localPosition = new Vector3(0f, 0f, -1000f);

            // Set title
            infoTextBox.titleTexxt.gameObject.GetComponent<TextTranslatorTMP>()?.DestroyImmediate();
            infoTextBox.titleTexxt.text = title;

            // Button 1 (Close)
            infoTextBox.button1Text.gameObject.GetComponent<TextTranslatorTMP>()?.DestroyImmediate();
            infoTextBox.button1Text.text = "Close";

            // Remove Button 2 completely
            infoTextBox.button2.gameObject.SetActive(false);

            // Button 1 listener
            infoTextBox.button1.OnClick.AddListener(CreateButtonAction(infoTextBox));
        }

        private static Action CreateButtonAction(InfoTextBox popup)
        {
            return new Action(() =>
            {
                if (popup != null)
                    UnityEngine.Object.Destroy(popup.gameObject);
            });
        }
    }
}
*/