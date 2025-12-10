using TORWL.Roles.Impostor;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;

namespace TORWL.Options.Roles.Impostor;

public class ToxifierOptions : AbstractOptionGroup<ToxifierRole>
{
    public override string GroupName => "Toxifier";

    [ModdedNumberOption("Toxify Cooldown", 0, 60, 5, MiraNumberSuffixes.Seconds)]
    public float ToxifyCooldown { get; set; } = 10f;

    [ModdedNumberOption("Toxify Uses", 0, 10, zeroInfinity: true)]
    public float ToxifyUses { get; set; } = 0;

    [ModdedNumberOption("Toxified Death Delay", 5, 60, 5, MiraNumberSuffixes.Seconds)]
    public float ToxifiedDelay { get; set; } = 10;
}