using System.Collections;
using System.Linq;
using LaunchpadReloaded.Options.Roles.Coven;
using MiraAPI.GameOptions;
using MiraAPI.Modifiers;
using MiraAPI.Modifiers.Types;
using Reactor.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace LaunchpadReloaded.Modifiers;

public class RoleBlockedModifier : TimedModifier
{
    public override string ModifierName => "Role Blocked";
    public override float Duration => OptionGroupSingleton<TavernKeeperOptions>.Instance.RoleBlockDuration;

    public override void OnMeetingStart()
    {
        Player.RpcRemoveModifier<RoleBlockedModifier>();
    }

    public override void OnActivate()
    {
        if (Player == PlayerControl.LocalPlayer)
        {
            Coroutines.Start(coroutine: DoAnimation(true));
            PlayerControl.LocalPlayer.cosmetics.SetOutline(true, new Il2CppSystem.Nullable<Color>(new Color(1f, 0f, 1f, 1f)));
        }
    }
    public IEnumerator DoAnimation(bool Show)
    {
        foreach (ActionButton button in Object.FindObjectsOfType<ActionButton>())
        {
            if (Show)
            {
                HudManager.Instance.StartCoroutine(Effects.ScaleIn(button.transform, 0.7f, 0f, 1.5f));

                yield return HudManager.Instance.StartCoroutine(Effects.ColorFade(button.graphic, Palette.White, Palette.Black, 1f));
                button.SetDisabled();
            }
            if (!Show)
            {
                button.SetEnabled();
                HudManager.Instance.StartCoroutine(Effects.ScaleIn(button.transform, 0f, 0.7f, 1.5f));

                HudManager.Instance.StartCoroutine(Effects.ColorFade(button.graphic, Palette.Black, Palette.White, 1f));
            }
        }
        yield break;
    }
    public override void OnDeactivate()
    {
        if (Player == PlayerControl.LocalPlayer)
        {
            Coroutines.Start(DoAnimation(false));
            PlayerControl.LocalPlayer.cosmetics.SetOutline(false, new Il2CppSystem.Nullable<Color>(new Color(1f, 0f, 1f, 1f)));
        }
    }
}