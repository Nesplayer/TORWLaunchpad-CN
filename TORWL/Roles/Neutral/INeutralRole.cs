using TORWL.Features;
using MiraAPI.GameOptions;
using MiraAPI.Roles;
using UnityEngine;

namespace TORWL.Roles.Neutral
{
    public interface INeutralRole : ICustomRole, IOptionable
    {
        ModdedRoleTeams ICustomRole.Team => ModdedRoleTeams.Custom;

        RoleOptionsGroup ICustomRole.RoleOptionsGroup =>
            new RoleOptionsGroup("♦ Neutral Roles ♦", Color.gray, 0);

        TeamIntroConfiguration? ICustomRole.IntroConfiguration =>
            new TeamIntroConfiguration(Color.gray, "NEUTRAL", 
                "You are a Neutral. You do not have a team.");
    }
    public static class NeutralRoleExtensions
    {
        public static void SpawnNeutralTaskHeader(this PlayerControl playerControl)
        {
            if (playerControl != PlayerControl.LocalPlayer) return;

            var orCreateTask = PlayerTask.GetOrCreateTask<ImportantTextTask>(playerControl);
            orCreateTask.Text = string.Concat([
                LaunchpadPalette.Neutral.ToTextColor(),
                "You have no team. Work alone to win",
                "</color>"
            ]);
        }
    }
}