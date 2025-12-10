using System.Collections.Generic;
using UnityEngine;

namespace TORWL.Utilities
{
    public static partial class Utils
    {
        /// <summary>
        /// Maps a victim player to their killer.
        /// </summary>
        public static Dictionary<PlayerControl, PlayerControl> PlayerKiller = new Dictionary<PlayerControl, PlayerControl>();

        /// <summary>
        /// Records a kill event by mapping a victim to its killer.
        /// </summary>
        /// <param name="killer">The player who performed the kill.</param>
        /// <param name="victim">The player who was killed.</param>
        public static void RecordOnKill(PlayerControl killer, PlayerControl victim)
        {
            if (PlayerKiller.ContainsKey(victim))
            {
                PlayerKiller[victim] = killer;
            }
            else
            {
                PlayerKiller.Add(victim, killer);
            }
        }

        /// <summary>
        /// Retrieves the killer of the specified victim.
        /// </summary>
        /// <param name="victim">The player who was killed.</param>
        /// <returns>The player who killed the victim, or null if not found.</returns>
        public static PlayerControl? GetKiller(PlayerControl victim)
        {
            return PlayerKiller.TryGetValue(victim, out var killer) ? killer : null;
        }
        
        /// <summary>
        /// Returns a list of living players within a given radius from a position.
        /// </summary>
        /// <param name="position">The center position to check from.</param>
        /// <param name="radius">The radius around the position to search for players.</param>
        /// <param name="includeDead">Whether to include dead players in the results.</param>
        /// <returns>List of nearby PlayerControl instances.</returns>
        public static List<PlayerControl> GetClosestPlayers(Vector2 position, float radius, bool includeDead = false)
        {
            List<PlayerControl> nearbyPlayers = new();

            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (player == null || player.Data == null) continue;
                if (!includeDead && player.Data.IsDead) continue;
                if (player.Data.Disconnected) continue;

                float distance = Vector2.Distance(player.GetTruePosition(), position);
                if (distance <= radius)
                {
                    nearbyPlayers.Add(player);
                }
            }

            return nearbyPlayers;
        }
    }
}