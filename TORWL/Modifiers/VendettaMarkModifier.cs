using MiraAPI.Modifiers;
using MiraAPI.PluginLoading;

namespace TORWL.Modifiers;

[MiraIgnore]
public class VendettaMarkModifier(byte vendettaPlayer) : BaseModifier
{
    public override string ModifierName => "Vendetta";
    public override bool HideOnUi => true;
    public PlayerControl Vendetta { get; private set; } = GameData.Instance.GetPlayerById(vendettaPlayer).Object;

    public override void OnDeath(DeathReason reason)
    {
        ModifierComponent!.RemoveModifier(this);
    }
}
