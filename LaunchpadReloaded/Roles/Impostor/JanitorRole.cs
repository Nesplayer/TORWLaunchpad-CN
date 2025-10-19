using LaunchpadReloaded.Features;
using LaunchpadReloaded.Modifiers;
using MiraAPI.Roles;
using System;
using MiraAPI.Modifiers;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Impostor;

public class JanitorRole(IntPtr ptr) : ImpostorRole(ptr), IImpostorRole
{
    public string RoleName => "Janitor";
    public string RoleDescription => "Drag bodies and hide them in vents";
    public string RoleLongDescription => "You can drag bodies and hide them in vents\nWhich will cause them to disappear unless the vent is used.";
    public Color RoleColor => LaunchpadPalette.JanitorColor;
    public ModdedRoleTeams Team => ModdedRoleTeams.Impostor;
    public CustomRoleConfiguration Configuration => new(this)
    {
        Icon = LaunchpadAssets.DragButton,
    };

    public override void SpawnTaskHeader(PlayerControl playerControl)
    {
        playerControl.SpawnImpostorTaskHeader();
    }

    public override bool CanUse(IUsable usable)
    {
        if (!GameManager.Instance.LogicUsables.CanUse(usable, Player))
        {
            return false;
        }
        var console = usable.TryCast<Console>();
        return !(console != null) || console.AllowImpostor && !PlayerControl.LocalPlayer.HasModifier<DragBodyModifier>();
    }
}