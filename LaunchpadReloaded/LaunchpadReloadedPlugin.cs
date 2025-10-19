using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using LaunchpadReloaded.Features;
using LaunchpadReloaded.Patches;
using MiraAPI;
using MiraAPI.PluginLoading;
using MiraAPI.Utilities;
using System.Reflection;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using Reactor.Utilities;

namespace LaunchpadReloaded;

[BepInAutoPlugin("mod.angel.launchpad", "TOR-W: L", "2.0.0-r")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency(MiraApiPlugin.Id)]
[BepInDependency(CrowdedModPatch.CrowdedId, BepInDependency.DependencyFlags.SoftDependency)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class LaunchpadReloadedPlugin : BasePlugin, IMiraPlugin
{
    private Harmony Harmony { get; } = new(Id);

    public ConfigFile GetConfigFile()
    {
        return Config;
    }

    public string OptionsTitleText => "TOR-W:\nLaunchpad";
    public static string ModVersion
    {
        get
        {
            var full = Assembly.GetExecutingAssembly()
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion ?? "Unknown";

            // Keep pre-release tag (e.g. -Dev-1), but remove metadata (+...)
            var clean = full.Split('+')[0];
            return clean;
        }
    }

    public override void Load()
    {
        Harmony.PatchAll();

        ReactorCredits.Register<LaunchpadReloadedPlugin>(ReactorCredits.AlwaysShow);

        IL2CPPChainloader.Instance.Finished +=
            ModNewsFetcher.CheckForNews;

        Config.Save();
    }
}