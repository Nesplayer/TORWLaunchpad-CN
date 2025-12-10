using TORWL.Features;
using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace TORWL.Roles.Crewmate
{
    public interface ICrewmateRole : ICustomRole, IOptionable
    {
        ModdedRoleTeams ICustomRole.Team => ModdedRoleTeams.Crewmate;

        RoleOptionsGroup ICustomRole.RoleOptionsGroup => 
            new RoleOptionsGroup("♦ Crewmate Roles ♦", new Color32(120, 204, 236, byte.MaxValue), -2);

        TeamIntroConfiguration? ICustomRole.IntroConfiguration => 
            new TeamIntroConfiguration(Color.cyan, "CREWMATE", 
                "You are a Crewmate. Do tasks and vote off the " + 
                Extensions.ToTextColor(Palette.ImpostorRed) + "Impostor</color>.");
    }
    public static class CrewmateRoleExtensions
    {
        public static void SpawnCrewmateTaskHeader(this PlayerControl playerControl)
        {
            if (playerControl != PlayerControl.LocalPlayer) return;

            var orCreateTask = PlayerTask.GetOrCreateTask<ImportantTextTask>(playerControl);
            orCreateTask.Text = string.Concat([
                LaunchpadPalette.Crewmate.ToTextColor(),
                "Do tasks and vote off the " +
                Extensions.ToTextColor(Palette.ImpostorRed) + "Impostor(s)</color>" +
                " to win!</color>"
            ]);
        }
    }
}