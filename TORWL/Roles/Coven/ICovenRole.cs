using TORWL.Features;
using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace TORWL.Roles.Coven
{
    public interface ICovenRole : ICustomRole, IOptionable
    {
        ModdedRoleTeams ICustomRole.Team => ModdedRoleTeams.Custom;

        RoleOptionsGroup ICustomRole.RoleOptionsGroup =>
            new RoleOptionsGroup("♦ Coven Roles ♦", new Color32(153, 50, 204, byte.MaxValue), 1);

        TeamIntroConfiguration? ICustomRole.IntroConfiguration =>
            new TeamIntroConfiguration(new Color32(138, 43, 226, 255), "COVEN", 
                "You are a Coven. You're a magical role.");
    }

    public static class CovenRoleExtensions
    {
        public static void SpawnCovenTaskHeader(this PlayerControl playerControl)
        {
            if (playerControl != PlayerControl.LocalPlayer) return;

            var orCreateTask = PlayerTask.GetOrCreateTask<ImportantTextTask>(playerControl);
            orCreateTask.Text = string.Concat([
                LaunchpadPalette.Coven.ToTextColor(),
                "You're a magical role. Either stop the\ncrew from winning, or form a group to win together!",
                "</color>"
            ]);
        }
    }
}