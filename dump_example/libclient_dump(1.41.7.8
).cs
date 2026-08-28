// # Linux Shitical-Strike 2 Dumper by @islavikfx (Beta)
// # github.com/islavikfx
// # MIT License

// # 2026 August 28, 04:34AM
// # Runtime PID: 6442
// # Game version: 1.41.7.8

// # Parsed classes: 343;
// # Dumping only libclient.so;
return libclient_so (0x718b67553000) {

    // Address: 0x454cc08
    public class CAnimGraph2InstancePtr
    {
        // Fields (14):
        public readonly int m_text = 0x0;
        public readonly int m_dataType = 0x8;
        public readonly uint m_userFlags = 0xc;
        public readonly uint m_userData = 0x10;
        public readonly uint m_userVector = 0x14;
        public readonly uint m_userTransform = 0x20;
        public readonly uint m_userShape = 0x40;
        public readonly int m_drawColor = 0xd8;
        public readonly Vector3 m_vecDebugOverlayData = 0xe0;
        public readonly IntPtr m_pStructuredData = 0xf8;
        public readonly CHandle m_hEntity = 0x100;
        public readonly string m_sEntityName = 0x108;
        public readonly int m_nEntityIndex = 0x110;
        public readonly int m_children = 0x120;
    }

    // Address: 0x454d1c8
    public class CAnimGraphControllerPtr
    {
        // Fields (5):
        public readonly int m_nInitialMovementId = 0x0;
        public readonly int m_nCurrentMovementId = 0x8;
        public readonly int m_nMode = 0x10;
        public readonly int m_nType = 0x18;
        public readonly int m_nState = 0x20;
    }

    // Address: 0x454d460
    public class CAnimGraphParamAutoResetRef
    {
        // Fields (5):
        static readonly int s_current_schedule = 0x18;
        static readonly int s_current_task = 0x20;
        static readonly int s_prev_schedule = 0x28;
        static readonly int s_npc_current_movement = 0x30;
        static readonly int s_last_task_end_location = 0x38;
    }

    // Address: 0x457e6e8
    public class CBaseModelEntityAPI
    {
        // Fields (3):
        public readonly bool m_bNegated = 0x77c;
        public readonly int m_OnPass = 0x780;
        public readonly int m_OnFail = 0x798;
    }

    // Address: 0x457e5e0
    internal class CBaseModelEntityAPI::Alpha
    {
        // Fields (3):
        public readonly int m_nFilterType = 0x7b0;
        public readonly int m_iFilterName = 0x7b8;
        public readonly CHandle m_hFilter = 0x808;
    }

    // Address: 0x454b788
    public class CBaseProp
    {
        // Fields (5):
        public readonly int m_nMaxCarry = 0x10;
        public readonly int m_nSplashSize = 0x1c;
        public readonly int m_nFlags = 0x24;
        public readonly float m_flMass = 0x28;
        public readonly float m_flSpeed = 0x2c;
    }

    // Address: 0x454c668
    public class CBodyComponentBaseAnimGraph
    {
        // Fields (10):
        public readonly string m_sName = 0x0;
        public readonly string m_sBreakablePieceName = 0x8;
        public readonly int m_nBodyGroupValue = 0x10;
        public readonly int m_nHealth = 0x14;
        public readonly float m_flCriticalDamagePercent = 0x24;
        public readonly int m_nDamagePassthroughType = 0x28;
        public readonly int m_nDestructionDeathBehavior = 0x2c;
        public readonly string m_sCustomDeathHandshake = 0x30;
        public readonly bool m_bShouldDestroyOnDeath = 0x38;
        public readonly float m_flDeathDestroyTime = 0x3c;
    }

    // Address: 0x454c308
    public class CBodyComponentBaseModelEntity
    {
        // Fields (4):
        private readonly IntPtr __m_pChainEntity = 0x0;
        public readonly Vector3 m_vecDamageTakenByHitGroup = 0x48;
        public readonly CHandle m_hOwner = 0x60;
        public readonly IntPtr m_pAnimGraphDestructibleGraphController = 0x68;
    }

    // Address: 0x4578ad0
    public class CCSObserver_CameraServices
    {
        // Fields (5):
        public readonly CHandle m_hPlayer = 0x7b0;
        public readonly CHandle m_hPingedEntity = 0x7b4;
        public readonly int m_iType = 0x7b8;
        public readonly bool m_bUrgent = 0x7bc;
        public readonly string m_szPlaceName = 0x7bd;
    }

    // Address: 0x4578770
    public class CCSObserver_UseServices
    {
        // Fields (10):
        public readonly bool m_bHostageAlive = 0x77c;
        public readonly int m_isHostageFollowingSomeone = 0x788;
        public readonly int m_iHostageEntityIDs = 0x794;
        public readonly bool m_bombsiteCenterA = 0x7c4;
        public readonly bool m_bombsiteCenterB = 0x7d0;
        public readonly CHandle m_hostageRescueX = 0x7dc;
        public readonly CHandle m_hostageRescueY = 0x7ec;
        public readonly CHandle m_hostageRescueZ = 0x7fc;
        public readonly bool m_bEndMatchNextMapAllVoted = 0x80c;
        public readonly int m_foundGoalPositions = 0x80d;
    }

    // Address: 0x4579fd0
    public class CCSPlayerAnimationState
    {
        // Fields (2):
        public readonly bool m_bOldJumpPressed = 0x10;
        public readonly float m_flJumpPressedTime = 0x14;
    }

    // Address: 0x457a2e8
    internal class CCSPlayerAnimationState::AirAction_t
    {
        // Fields (9):
        public readonly Vector3 m_vecNetworkableLoadout = 0x40;
        public readonly uint m_unMusicID = 0x58;
        public readonly int m_rank = 0x5c;
        public readonly int m_nPersonaDataPublicLevel = 0x74;
        public readonly int m_nPersonaDataPublicCommendsLeader = 0x78;
        public readonly int m_nPersonaDataPublicCommendsTeacher = 0x7c;
        public readonly int m_nPersonaDataPublicCommendsFriendly = 0x80;
        public readonly int m_nPersonaDataXpTrailLevel = 0x84;
        public readonly Vector3 m_vecServerAuthoritativeWeaponSlots = 0x88;
    }

    // Address: 0x457a288
    internal class CCSPlayerAnimationState::GroundMoveState_t
    {
        // Fields (2):
        public readonly bool m_bHasDefuser = 0x48;
        public readonly bool m_bHasHelmet = 0x49;
    }

    // Address: 0x45798d0
    public class CCSPlayerController
    {
        // Fields (49):
        public readonly int m_AnimationState = 0x310;
        public readonly bool m_bUsingGroundTopologyOffset = 0x3f0;
        public readonly float m_flUsingGroundTopologyOffsetTransitionSmoothing = 0x3f4;
        public readonly Vector3 m_vecLadderNormal = 0x3f8;
        public readonly int m_nLadderSurfacePropIndex = 0x404;
        public readonly bool m_bDucked = 0x408;
        public readonly float m_flDuckAmount = 0x40c;
        public readonly float m_flDuckSpeed = 0x410;
        public readonly bool m_bDuckOverride = 0x414;
        public readonly bool m_bDesiresDuck = 0x415;
        public readonly bool m_bDucking = 0x416;
        public readonly float m_flDuckRootOffset = 0x418;
        public readonly float m_flDuckViewOffset = 0x41c;
        public readonly float m_flLastDuckTime = 0x420;
        public readonly float m_flBombPlantViewOffset = 0x424;
        public readonly Vector3 m_vecLastPositionAtFullCrouchSpeed = 0x430;
        public readonly int m_duckUntilOnGround = 0x438;
        public readonly bool m_bHasWalkMovedSinceLastJump = 0x439;
        public readonly bool m_bInStuckTest = 0x43a;
        public readonly int m_nTraceCount = 0x648;
        public readonly int m_StuckLast = 0x64c;
        public readonly bool m_bSpeedCropped = 0x650;
        public readonly int m_nOldWaterLevel = 0x654;
        public readonly float m_flWaterEntryTime = 0x658;
        public readonly Vector3 m_vecForward = 0x65c;
        public readonly Vector3 m_vecLeft = 0x668;
        public readonly Vector3 m_vecUp = 0x674;
        public readonly int m_nGameCodeHasMovedPlayerAfterCommand = 0x680;
        public readonly int m_fStashGrenadeParameterWhen = 0x684;
        public readonly bool m_bUseFrictionStashedSpeed = 0x688;
        public readonly float m_flUseFrictionStashedSpeedUntilFrac = 0x68c;
        public readonly float m_flFrictionStashedSpeed = 0x690;
        public readonly float m_flStamina = 0x694;
        public readonly float m_flHeightAtJumpStart = 0x698;
        public readonly float m_flMaxJumpHeightThisJump = 0x69c;
        public readonly float m_flMaxJumpHeightLastJump = 0x6a0;
        public readonly float m_flStaminaAtJumpStart = 0x6a4;
        public readonly float m_flVelMulAtJumpStart = 0x6a8;
        public readonly float m_flAccumulatedJumpError = 0x6ac;
        public readonly int m_LegacyJump = 0x6b0;
        public readonly int m_ModernJump = 0x6c8;
        public readonly int m_nLastJumpTick = 0x700;
        public readonly float m_flLastJumpFrac = 0x704;
        public readonly float m_flLastJumpVelocityZ = 0x708;
        public readonly bool m_bJumpApexPending = 0x70c;
        public readonly float m_flTicksSinceLastSurfingDetected = 0x710;
        public readonly bool m_bWasSurfing = 0x714;
        public readonly Vector3 m_vecWalkWishVel = 0x7a4;
        public readonly bool m_bHasEverProcessedCommand = 0xfd0;
    }

    // Address: 0x457bed0
    public class CCSPlayerModernJump
    {
        // Fields (17):
        public readonly int m_CommandContext = 0x788;
        public readonly int m_nInButtonsWhichAreToggles = 0x830;
        public readonly int m_nTickBase = 0x838;
        public readonly CHandle m_hPawn = 0x83c;
        public readonly bool m_bKnownTeamMismatch = 0x840;
        public readonly CHandle m_hPredictedPawn = 0x844;
        public readonly int m_nSplitScreenSlot = 0x848;
        public readonly CHandle m_hSplitOwner = 0x84c;
        public readonly CHandle m_hSplitScreenPlayers = 0x850;
        public readonly bool m_bIsHLTV = 0x868;
        public readonly int m_iConnected = 0x86c;
        public readonly int m_iMostConnected = 0x870;
        public readonly int m_iszPlayerName = 0x874;
        public readonly string m_steamID = 0x900;
        public readonly bool m_bIsLocalPlayerController = 0x908;
        public readonly bool m_bNoClipEnabled = 0x909;
        public readonly int m_iDesiredFOV = 0x90c;
    }

    // Address: 0x4579db0
    public class CCSPlayer_BulletServices
    {
        // Fields (9):
        public readonly int m_nLastActualJumpPressTick = 0x10;

// ** 5K+ Lines (deleted)..