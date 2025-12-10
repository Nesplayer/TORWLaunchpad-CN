using MiraAPI.Utilities.Assets;
using UnityEngine;

namespace TORWL.Features;

public static class LaunchpadAudio
{
    // THIS FILE SHOULD ONLY HOLD AUDIO
    public static LoadableAudioResourceAsset MagicWhoosh { get; } = new LoadableAudioResourceAsset("TORWLaunchpad.Resources.Sounds.Whoosh.wav");
    public static LoadableAudioResourceAsset Potion { get; } = new LoadableAudioResourceAsset("TORWLaunchpad.Resources.Sounds.Potion.wav");
    public static LoadableAudioResourceAsset Curse { get; } = new LoadableAudioResourceAsset("TORWLaunchpad.Resources.Sounds.Curse.wav");
}