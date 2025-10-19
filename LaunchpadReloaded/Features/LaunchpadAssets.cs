using MiraAPI.Utilities.Assets;
using Reactor.Utilities;
using UnityEngine;

namespace LaunchpadReloaded.Features;

public static class LaunchpadAssets
{
    public static readonly AssetBundle Bundle = AssetBundleManager.Load("launchpad-assets");
    public static readonly AssetBundle Icons = AssetBundleManager.Load("icons");
    public static readonly AssetBundle Ability = AssetBundleManager.Load("ability");

    // Shaders
    public static readonly LoadableAsset<Shader> BloomShader = new LoadableBundleAsset<Shader>("Bloom.shader", Bundle);

    // Materials
    public static readonly LoadableAsset<Material> GradientMaterial = new LoadableBundleAsset<Material>("GradientPlayerMaterial", Bundle);
    public static readonly LoadableAsset<Material> MaskedGradientMaterial = new LoadableBundleAsset<Material>("MaskedGradientMaterial", Bundle);

    // Sprites
    public static readonly LoadableAsset<Sprite> BlankButton = new LoadableBundleAsset<Sprite>("BlankButton", Bundle);
    public static readonly LoadableAsset<Sprite> CallButton = new LoadableBundleAsset<Sprite>("CallMeeting.png", Bundle);
    public static readonly LoadableAsset<Sprite> DissectButton = new LoadableBundleAsset<Sprite>("Dissect.png", Bundle);
    public static readonly LoadableAsset<Sprite> DragButton = new LoadableBundleAsset<Sprite>("Drag.png", Bundle);
    public static readonly LoadableAsset<Sprite> DropButton = new LoadableBundleAsset<Sprite>("Drop.png", Bundle);
    public static readonly LoadableAsset<Sprite> HackButton = new LoadableBundleAsset<Sprite>("Hack.png", Bundle);
    public static readonly LoadableAsset<Sprite> HideButton = new LoadableBundleAsset<Sprite>("Clean.png", Bundle);
    public static readonly LoadableAsset<Sprite> InjectButton = new LoadableBundleAsset<Sprite>("Inject.png", Bundle);
    public static readonly LoadableAsset<Sprite> DigVentButton = new LoadableBundleAsset<Sprite>("DigVent.png", Bundle);
    public static readonly LoadableAsset<Sprite> JesterIcon = new LoadableBundleAsset<Sprite>("Jester.png", Icons);
    public static readonly LoadableAsset<Sprite> TraitorIcon = new LoadableBundleAsset<Sprite>("Traitor.png", Icons);
    public static readonly LoadableAsset<Sprite> TeleportButton = new LoadableBundleAsset<Sprite>("TeleportButton.png", Icons);
    public static readonly LoadableAsset<Sprite> KillButton = new LoadableBundleAsset<Sprite>("Kill.png", Icons);
    public static readonly LoadableAsset<Sprite> NeutralKillerIcon = new LoadableBundleAsset<Sprite>("Kill.png", Icons);
    public static readonly LoadableAsset<Sprite> RoleBlockButton = new LoadableBundleAsset<Sprite>("RoleBlock.png", Icons);
    public static readonly LoadableAsset<Sprite> ExecutionerIcon = new LoadableBundleAsset<Sprite>("Executioner.png", Icons);
    public static readonly LoadableAsset<Sprite> NewsIcon = new LoadableBundleAsset<Sprite>("VIP.png", Icons);
    public static readonly LoadableAsset<Sprite> ReviveButton = new LoadableBundleAsset<Sprite>("Revive.png", Bundle);
    public static readonly LoadableAsset<Sprite> ShootButton = new LoadableBundleAsset<Sprite>("Shoot.png", Bundle);
    public static readonly LoadableAsset<Sprite> ZoomButton = new LoadableBundleAsset<Sprite>("Zoom.png", Bundle);
    public static readonly LoadableAsset<Sprite> SealButton = new LoadableBundleAsset<Sprite>("SealVent.png", Bundle);
    public static readonly LoadableAsset<Sprite> SwapButton = new LoadableBundleAsset<Sprite>("Swap.png", Bundle);
    public static readonly LoadableAsset<Sprite> FreezeButton = new LoadableBundleAsset<Sprite>("Freeze.png", Bundle);
    public static readonly LoadableAsset<Sprite> SoulButton = new LoadableBundleAsset<Sprite>("StealSoul.png", Bundle);
    public static readonly LoadableAsset<Sprite> GambleButton = new LoadableBundleAsset<Sprite>("Gamble.png", Bundle);
    public static readonly LoadableAsset<Sprite> DeadlockButton = new LoadableBundleAsset<Sprite>("Deadlock.png", Bundle);
    public static readonly LoadableAsset<Sprite> Silencer = new LoadableResourceAsset("TORWLaunchpad.Resources.Silencer.png");

    // Ability Counter Sprites
    public static readonly LoadableAsset<Sprite> Basic = new LoadableBundleAsset<Sprite>("Basic.png", Ability);
    public static readonly LoadableAsset<Sprite> Player = new LoadableBundleAsset<Sprite>("Player.png", Ability);
    public static readonly LoadableAsset<Sprite> Body = new LoadableBundleAsset<Sprite>("Body.png", Ability);
    public static readonly LoadableAsset<Sprite> Vent = new LoadableBundleAsset<Sprite>("Vent.png", Ability);
    
    // Modifier Icons
    public static readonly LoadableAsset<Sprite> BaitIcon = new LoadableBundleAsset<Sprite>("Bait.png", Icons);
    public static readonly LoadableAsset<Sprite> FlashIcon = new LoadableBundleAsset<Sprite>("Flash.png", Icons);
    public static readonly LoadableAsset<Sprite> MiniIcon = new LoadableBundleAsset<Sprite>("Mini.png", Icons);
    public static readonly LoadableAsset<Sprite> GiantIcon = new LoadableBundleAsset<Sprite>("Giant.png", Icons);
    public static readonly LoadableAsset<Sprite> VIPIcon = new LoadableBundleAsset<Sprite>("VIP.png", Icons);
    public static readonly LoadableAsset<Sprite> TorchIcon = new LoadableBundleAsset<Sprite>("Torch.png", Icons);
    public static readonly LoadableAsset<Sprite> GravityFieldIcon = new LoadableBundleAsset<Sprite>("GravityField.png", Icons);
    public static readonly LoadableAsset<Sprite> BurstIcon = new LoadableBundleAsset<Sprite>("Burst.png", Icons);
    public static readonly LoadableAsset<Sprite> MayorIcon = new LoadableBundleAsset<Sprite>("Mayor.png", Icons);
    
    // UI Buttons
    public static readonly LoadableAsset<Sprite> PListActive = new LoadableResourceAsset("TORWLaunchpad.Resources.PlayerListActive.png");
    public static readonly LoadableAsset<Sprite> PListInactive = new LoadableResourceAsset("TORWLaunchpad.Resources.PlayerListInactive.png");
    public static readonly LoadableAsset<Sprite> NotepadSprite = new LoadableBundleAsset<Sprite>("NotepadButton.png", Bundle);
    public static readonly LoadableAsset<Sprite> NotepadActiveSprite = new LoadableBundleAsset<Sprite>("NotepadButtonActive.png", Bundle);

    // Object Sprites
    public static readonly LoadableAsset<Sprite> Bone = new LoadableBundleAsset<Sprite>("Bone.png", Bundle);
    public static readonly LoadableAsset<Sprite> Footstep = new LoadableBundleAsset<Sprite>("Footstep.png", Bundle);
    public static readonly LoadableAsset<Sprite> VentTape = new LoadableBundleAsset<Sprite>("VentTape.png", Bundle);
    public static readonly LoadableAsset<Sprite> VentTapePolus = new LoadableBundleAsset<Sprite>("VentTapePolus.png", Bundle);
    public static readonly LoadableAsset<Sprite> KnifeHandSprite = new LoadableBundleAsset<Sprite>("KnifeHand.png", Bundle);
    public static readonly LoadableAsset<Sprite> NodeSprite = new LoadableBundleAsset<Sprite>("Node.png", Bundle);
    
    public static readonly LoadableAsset<Sprite> DeadlockHonor = new LoadableBundleAsset<Sprite>("DeadlockHonor.png", Bundle);
    public static readonly LoadableAsset<Sprite> DeadlockTarget = new LoadableBundleAsset<Sprite>("DeadlockTarget.png", Bundle);
    public static readonly LoadableAsset<Sprite> DeadlockVignette = new LoadableBundleAsset<Sprite>("DeadlockVignette.png", Bundle);
    public static readonly LoadableAsset<Sprite> FrozenBodyOverlay = new LoadableBundleAsset<Sprite>("BodyFrozenOverlay.png", Bundle);

    // Sounds
    public static readonly LoadableAsset<AudioClip> BeepSound = new LoadableBundleAsset<AudioClip>("Beep.wav", Bundle);
    public static readonly LoadableAsset<AudioClip> InjectSound = new LoadableBundleAsset<AudioClip>("Inject.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> DissectSound = new LoadableBundleAsset<AudioClip>("Dissect.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> HackingSound = new LoadableBundleAsset<AudioClip>("HackAmbience.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> PingSound = new LoadableBundleAsset<AudioClip>("Ping.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> MoneySound = new LoadableBundleAsset<AudioClip>("MoneySound.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> BuzzerSound = new LoadableBundleAsset<AudioClip>("Buzzer.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> DigSound = new LoadableBundleAsset<AudioClip>("Dig.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> TapeSound = new LoadableBundleAsset<AudioClip>("Tape.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> SwooshSound = new LoadableBundleAsset<AudioClip>("Swoosh.mp3", Bundle);
    public static readonly LoadableAsset<AudioClip> ReaperSound = new LoadableBundleAsset<AudioClip>("CollectSoul.mp3", Bundle);

    // Deadlock Sounds
    public static readonly LoadableAsset<AudioClip> DeadlockAmbience = new LoadableBundleAsset<AudioClip>("DeadlockAmbience.wav", Bundle);
    public static readonly LoadableAsset<AudioClip> DeadlockFadeIn = new LoadableBundleAsset<AudioClip>("DeadlockFadeIn.wav", Bundle);
    public static readonly LoadableAsset<AudioClip> DeadlockFadeOut = new LoadableBundleAsset<AudioClip>("DeadlockFadeOut.wav", Bundle);
    public static readonly LoadableAsset<AudioClip> DeadlockClockLeft = new LoadableBundleAsset<AudioClip>("DeadlockClockLeft.wav", Bundle);
    public static readonly LoadableAsset<AudioClip> DeadlockClockRight = new LoadableBundleAsset<AudioClip>("DeadlockClockRight.wav", Bundle);
    public static readonly LoadableAsset<AudioClip> DeadlockMark = new LoadableBundleAsset<AudioClip>("DeadlockMark.wav", Bundle);
    public static readonly LoadableAsset<AudioClip> DeadlockKillConfirmal = new LoadableBundleAsset<AudioClip>("DeadlockKillConfirmal.wav", Bundle);

    // Other
    public static readonly LoadableAsset<GameObject> DetectiveGame = new LoadableBundleAsset<GameObject>("JournalMinigame", Bundle);
    public static readonly LoadableAsset<GameObject> RoleMinigame = new LoadableBundleAsset<GameObject>("RoleGuessingMinigame", Bundle);
    public static readonly LoadableAsset<GameObject> ReaperDisplay = new LoadableBundleAsset<GameObject>("ReaperSoulDisplay", Bundle);
    public static readonly LoadableAsset<GameObject> Notepad = new LoadableBundleAsset<GameObject>("Notepad", Bundle);
    public static readonly LoadableAsset<GameObject> NodeGame = new LoadableBundleAsset<GameObject>("NodeMinigame", Bundle);

    public static readonly LoadableAsset<GameObject> PlayerTags = new LoadableBundleAsset<GameObject>("PlayerTags", Bundle);
}