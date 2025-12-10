using TORWL.Roles.Crewmate;
using TORWL.Utilities;
using Reactor.Networking.Attributes;
using Reactor.Utilities;
using Helpers = MiraAPI.Utilities.Helpers;

namespace TORWL.Networking;
public static class GenericRpc
{
    [MethodRpc((uint)LaunchpadRpc.Revive)]
    public static void RpcRevive(this PlayerControl playerControl, byte bodyId)
    {
        if (playerControl.Data.Role is not MedicRole)
        {
            playerControl.KickForCheating();
            return;
        }

        var body = Helpers.GetBodyById(bodyId);
        if (body != null)
        {
            body.Revive(playerControl);
        }
        else
        {
            Logger<TORWLPlugin>.Warning($"Body for id {bodyId} not found");
        }
    }
}