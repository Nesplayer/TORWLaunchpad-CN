using LaunchpadReloaded.Buttons.Crewmate;
using LaunchpadReloaded.Features;
using MiraAPI.Roles;
using System;
using UnityEngine;

namespace LaunchpadReloaded.Roles.Crewmate;

public class TeleporterRole(IntPtr ptr) : CrewmateRole(ptr), ICrewmateRole
{
    public string RoleName => "Teleporter";
    public string RoleLongDescription => "Zoom out and teleport across the map!";
    public string RoleDescription => RoleLongDescription;
    public Color RoleColor => LaunchpadPalette.TeleporterColor;
    public ModdedRoleTeams Team => ModdedRoleTeams.Crewmate;

    public CustomRoleConfiguration Configuration => new CustomRoleConfiguration(this)
    {
        Icon = LaunchpadAssets.TeleportButton,
    };
    public override void SpawnTaskHeader(PlayerControl playerControl)
        {
            playerControl.SpawnCrewmateTaskHeader();
        }
}