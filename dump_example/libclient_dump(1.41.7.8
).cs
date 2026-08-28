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
        public readonly float m_flLastActualJumpPressFrac = 0x14;
        public readonly int m_nLastUsableJumpPressTick = 0x18;
        public readonly float m_flLastUsableJumpPressFrac = 0x1c;
        public readonly int m_nLastLandedTick = 0x20;
        public readonly float m_flLastLandedFrac = 0x24;
        public readonly float m_flLastLandedVelocityX = 0x28;
        public readonly float m_flLastLandedVelocityY = 0x2c;
        public readonly float m_flLastLandedVelocityZ = 0x30;
    }

    // Address: 0x4579990
    public class CCSPlayer_CameraServices
    {
        // Fields (2):
        public readonly string m_source = 0x1020;
        public readonly int m_destination = 0x1028;
    }

    // Address: 0x4578ce8
    public class CCSPlayer_HostageServices
    {
        // Fields (28):
        public readonly bool m_bIsDefusing = 0x2a0;
        public readonly int m_moveType = 0x2b8;
        public readonly int m_moveDirectionID = 0x2d0;
        public readonly float m_flMoveSpeedX = 0x2e8;
        public readonly float m_flMoveSpeedY = 0x300;
        public readonly float m_flMoveSpeedHorizontal = 0x318;
        public readonly float m_flPreviousMoveSpeedHorizontal = 0x330;
        public readonly float m_flCrouchAmount = 0x348;
        public readonly bool m_bIsWalking = 0x360;
        public readonly float m_flWeaponDropAmount = 0x378;
        public readonly int m_groundAction = 0x390;
        public readonly int m_groundActionDirectionID = 0x3a8;
        public readonly float m_flGroundTurnAngleOrVelocity = 0x3c0;
        public readonly float m_flLadderCycle = 0x3d8;
        public readonly float m_flLadderYaw = 0x3f0;
        public readonly float m_flLadderYawBackwards = 0x408;
        public readonly int m_airAction = 0x420;
        public readonly float m_flAirHeightAboveGround = 0x438;
        public readonly int m_leftFootTarget = 0x450;
        public readonly int m_rightFootTarget = 0x468;
        public readonly float m_flFlashedAmount = 0x480;
        public readonly float m_flAimPitchAngle = 0x498;
        public readonly float m_flAimYawAngle = 0x4b0;
        public readonly float m_flinchHead = 0x4c8;
        public readonly float m_flinchHeadRestart = 0x4e0;
        public readonly float m_flinchBody = 0x4f8;
        public readonly float m_flinchBodyRestart = 0x510;
        public readonly float m_flinchIsOnFire = 0x528;
    }

    // Address: 0x457afd0
    public class CCSPlayer_MovementServices
    {
        // Fields (20):
        public readonly int m_action = 0x88;
        public readonly bool m_bActionReset = 0xa0;
        public readonly float m_flWeaponActionSpeedScale = 0xb8;
        public readonly int m_weaponCategory = 0xd0;
        public readonly int m_weaponType = 0xe8;
        public readonly int m_weaponExtraInfo = 0x100;
        public readonly float m_flWeaponAmmo = 0x118;
        public readonly float m_flWeaponAmmoMax = 0x130;
        public readonly float m_flWeaponAmmoReserve = 0x148;
        public readonly bool m_bWeaponIsSilenced = 0x160;
        public readonly float m_flWeaponIronsightAmount = 0x178;
        public readonly bool m_bIsUsingLegacyModel = 0x190;
        public readonly int m_idleVariation = 0x1a8;
        public readonly int m_deployVariation = 0x1c0;
        public readonly int m_attackType = 0x1d8;
        public readonly int m_attackThrowStrength = 0x1f0;
        public readonly float m_flAttackVariation = 0x208;
        public readonly int m_inspectVariation = 0x220;
        public readonly int m_inspectExtraInfo = 0x238;
        public readonly int m_reloadStage = 0x250;
    }

    // Address: 0x457aaf0
    public class CCSPlayer_PingServices
    {
        // Fields (5):
        public readonly IntPtr m_perRoundStats = 0x40;
        public readonly int m_matchStats = 0xa8;
        public readonly int m_iNumRoundKills = 0x120;
        public readonly int m_iNumRoundKillsHeadshots = 0x124;
        public readonly float m_flTotalRoundDamageDealt = 0x128;
    }

    // Address: 0x4576468
    external class CCSWeaponBase_API
    {
        // Fields (4):
        public readonly CHandle m_hLastWeaponBeforeC4AutoSwitch = 0x48;
        public readonly bool m_bIsRescuing = 0x4c;
        public readonly int m_weaponPurchasesThisMatch = 0x50;
        public readonly int m_weaponPurchasesThisRound = 0xc0;
    }

    // Address: 0x45935e8
    public class CCitadelSoundOpvarSetOBB
    {
        // Fields (14):
        public readonly float m_flZFar = 0x77c;
        public readonly float m_flZNear = 0x780;
        public readonly bool m_bLoop = 0x784;
        public readonly bool m_bVerticalFOV = 0x785;
        public readonly bool m_bConstantSpeed = 0x786;
        public readonly float m_flDuration = 0x788;
        public readonly float m_flPathLength = 0x7d0;
        public readonly float m_flPathDuration = 0x7d4;
        public readonly bool m_bDofEnabled = 0x7ec;
        public readonly float m_flDofNearBlurry = 0x7f0;
        public readonly float m_flDofNearCrisp = 0x7f4;
        public readonly float m_flDofFarCrisp = 0x7f8;
        public readonly float m_flDofFarBlurry = 0x7fc;
        public readonly float m_flDofTiltToGround = 0x800;
    }

    // Address: 0x4542950
    public class CCollisionProperty
    {
        // Fields (6):
        public readonly int m_iszStackName = 0x780;
        public readonly int m_iszOperatorName = 0x788;
        public readonly int m_iszOpvarName = 0x790;
        public readonly int m_iOpvarIndex = 0x798;
        public readonly bool m_bUseAutoCompare = 0x79c;
        public readonly bool m_bFastRefresh = 0x79d;
    }

    // Address: 0x45c2aa0
    public class CColorGradient
    {
        // Fields (4):
        public readonly CHandle m_hBlackboardResource = 0x0;
        public readonly int m_BlackboardResource = 0x8;
        public readonly int m_nNodeID = 0x18;
        public readonly int m_NodeName = 0x20;
    }

    // Address: 0x45cf488
    public class CCompositeMaterialEditorDoc
    {
        // Fields (37):
        public readonly string m_strName = 0x0;
        public readonly bool m_bExposeExternally = 0x8;
        public readonly string m_strExposedFriendlyName = 0x10;
        public readonly string m_strExposedFriendlyGroupName = 0x18;
        public readonly bool m_bExposedVariableIsFixedRange = 0x20;
        public readonly string m_strExposedVisibleWhenTrue = 0x28;
        public readonly string m_strExposedHiddenWhenTrue = 0x30;
        public readonly string m_strExposedValueList = 0x38;
        public readonly int m_nVariableType = 0x40;
        public readonly bool m_bValueBoolean = 0x44;
        public readonly int m_nValueIntX = 0x48;
        public readonly int m_nValueIntY = 0x4c;
        public readonly int m_nValueIntZ = 0x50;
        public readonly int m_nValueIntW = 0x54;
        public readonly bool m_bHasFloatBounds = 0x58;
        public readonly float m_flValueFloatX = 0x5c;
        public readonly float m_flValueFloatX_Min = 0x60;
        public readonly float m_flValueFloatX_Max = 0x64;
        public readonly float m_flValueFloatY = 0x68;
        public readonly float m_flValueFloatY_Min = 0x6c;
        public readonly float m_flValueFloatY_Max = 0x70;
        public readonly float m_flValueFloatZ = 0x74;
        public readonly float m_flValueFloatZ_Min = 0x78;
        public readonly float m_flValueFloatZ_Max = 0x7c;
        public readonly float m_flValueFloatW = 0x80;
        public readonly float m_flValueFloatW_Min = 0x84;
        public readonly float m_flValueFloatW_Max = 0x88;
        public readonly int m_cValueColor4 = 0x8c;
        public readonly int m_nValueSystemVar = 0x90;
        public readonly string m_strResourceMaterial = 0x98;
        public readonly string m_strTextureContentAssetPath = 0x178;
        public readonly string m_strTextureRuntimeResourcePath = 0x180;
        public readonly string m_strTextureCompilationVtexTemplate = 0x260;
        public readonly int m_nTextureType = 0x268;
        public readonly string m_strString = 0x270;
        public readonly string m_strPanoramaPanelPath = 0x278;
        public readonly int m_nPanoramaRenderRes = 0x280;
    }

    // Address: 0x454eb88
    public class CDebugDrawHistoryData
    {
        // Fields (13):
        public readonly bool m_bIsPlayingBack = 0x788;
        public readonly bool m_bPaused = 0x789;
        public readonly bool m_bMultiplayer = 0x78a;
        public readonly bool m_bAutogenerated = 0x78b;
        public readonly bool m_bAllRequirementsComplete = 0x78c;
        public readonly float m_flForceClientTime = 0x790;
        public readonly int m_nSceneStringIndex = 0x794;
        public readonly bool m_bClientOnly = 0x796;
        public readonly CHandle m_hOwner = 0x798;
        public readonly CHandle m_hActorList = 0x7a0;
        public readonly bool m_bWasPlaying = 0x7b8;
        public readonly int m_QueuedEvents = 0x7c8;
        public readonly float m_flCurrentTime = 0x7e0;
    }

    // Address: 0x454fe88
    public class CDebugOverlayCombinedTypes_t
    {
        // Fields (37):
        public readonly bool m_bEndPointAttachmentPositionsDirty = 0x0;
        public readonly int m_LinksTouchingSomething = 0xf40;
        public readonly int m_nLinksTouchingSomething = 0xf44;
        public readonly bool m_bApplyWind = 0xf48;
        public readonly int m_fPrevLockedPoints = 0xf4c;
        public readonly int m_iForcePointMoveCounter = 0xf50;
        public readonly bool m_bPrevEndPointPos = 0xf54;
        public readonly int m_vPrevEndPointPos = 0xf58;
        public readonly float m_flCurScroll = 0xf70;
        public readonly float m_flScrollSpeed = 0xf74;
        public readonly int m_RopeFlags = 0xf78;
        public readonly int m_iRopeMaterialModelIndex = 0xf80;
        public readonly int m_nSegments = 0x11f8;
        public readonly CHandle m_hStartPoint = 0x11fc;
        public readonly CHandle m_hEndPoint = 0x1200;
        public readonly int m_iStartAttachment = 0x1204;
        public readonly int m_iEndAttachment = 0x1205;
        public readonly int m_Subdiv = 0x1206;
        public readonly int m_RopeLength = 0x1208;
        public readonly int m_Slack = 0x120a;
        public readonly int m_TextureScale = 0x120c;
        public readonly int m_fLockedPoints = 0x1210;
        public readonly int m_nChangeCount = 0x1211;
        public readonly int m_Width = 0x1214;
        public readonly int m_PhysicsDelegate = 0x1218;
        public readonly CHandle m_hMaterial = 0x1228;
        public readonly int m_TextureHeight = 0x1230;
        public readonly Vector3 m_vecImpulse = 0x1234;
        public readonly Vector3 m_vecPreviousImpulse = 0x1240;
        public readonly float m_flCurrentGustTimer = 0x124c;
        public readonly float m_flCurrentGustLifetime = 0x1250;
        public readonly float m_flTimeToNextGust = 0x1254;
        public readonly int m_vWindDir = 0x1258;
        public readonly int m_vColorMod = 0x1264;
        public readonly int m_vCachedEndPointAttachmentPos = 0x1270;
        public readonly int m_vCachedEndPointAttachmentAngle = 0x1288;
        public readonly bool m_bConstrainBetweenEndpoints = 0x12a0;
    }

    // Address: 0x454e308
    public class CDestructiblePartsSystemData
    {
        // Fields (13):
        public readonly int m_gravityScale = 0x1020;
        public readonly int m_linearLimit = 0x1024;
        public readonly int m_linearDamping = 0x1028;
        public readonly QAngle m_angularLimit = 0x102c;
        public readonly QAngle m_angularDamping = 0x1030;
        public readonly int m_linearForce = 0x1034;
        public readonly float m_flFrequency = 0x1038;
        public readonly float m_flDampingRatio = 0x103c;
        public readonly Vector3 m_vecLinearForcePointAt = 0x1040;
        public readonly bool m_bCollapseToForcePoint = 0x104c;
        public readonly Vector3 m_vecLinearForcePointAtWorld = 0x1050;
        public readonly Vector3 m_vecLinearForceDirection = 0x105c;
        public readonly bool m_bConvertToDebrisWhenPossible = 0x1068;
    }

    // Address: 0x4546240
    public class CEmbeddedSubclassGeneric
    {
        // Fields (3):
        public readonly float m_flDamage = 0x0;
        public readonly float m_flNPCDamageScalarVsNPC = 0x10;
        public readonly float m_flPhysicsForceDamage = 0x14;
    }

    // Address: 0x454d328
    public class CEmptyGraphController
    {
        // Fields (3):
        static readonly int s_npc_current_ability = 0x8;
        static readonly int s_npc_tactic_current = 0x10;
        static readonly int s_npc_tactic_phase = 0x18;
    }

    // Address: 0x45cd5a8
    public class CEntityIOOutput
    {
        // Fields (3):
        public readonly int m_nVersion = 0x8;
        public readonly int m_Points = 0x10;
        public readonly int m_KVthumbnail = 0x28;
    }

    // Address: 0x4545708
    public class CEntitySubclassVDataBase
    {
        // Fields (2):
        public readonly CHandle m_hScriptScope = 0x8;
        public readonly int m_nInitialSeed = 0x9c;
    }

    // Address: 0x4548608
    internal class CEnvSoundscapeProxyAlias_snd_soundscape_proxy
    {
        // Fields (82):
        public readonly int m_CBodyComponent = 0x30;
        public readonly int m_NetworkTransmitComponent = 0x38;
        public readonly int m_nLastThinkTick = 0x498;
        public readonly IntPtr m_pGameSceneNode = 0x4a0;
        public readonly IntPtr m_pRenderComponent = 0x4a8;
        public readonly IntPtr m_pCollision = 0x4b0;
        public readonly int m_iMaxHealth = 0x4b8;
        public readonly int m_iHealth = 0x4bc;
        public readonly float m_flDamageAccumulator = 0x4c0;
        public readonly int m_lifeState = 0x4c4;
        public readonly bool m_bTakesDamage = 0x4c5;
        public readonly int m_nTakeDamageFlags = 0x4c8;
        public readonly int m_nPlatformType = 0x4d0;
        public readonly uint m_ubInterpolationFrame = 0x4d1;
        public readonly CHandle m_hSceneObjectController = 0x4d4;
        public readonly int m_nNoInterpolationTick = 0x4d8;
        public readonly int m_nVisibilityNoInterpolationTick = 0x4dc;
        public readonly float m_flProxyRandomValue = 0x4e0;
        public readonly int m_iEFlags = 0x4e4;
        public readonly int m_nWaterType = 0x4e8;
        public readonly bool m_bInterpolateEvenWithNoModel = 0x4e9;
        public readonly bool m_bPredictionEligible = 0x4ea;
        public readonly bool m_bApplyLayerMatchIDToModel = 0x4eb;
        public readonly int m_tokLayerMatchID = 0x4ec;
        public readonly int m_nSubclassID = 0x4f0;
        public readonly int m_nSimulationTick = 0x500;
        public readonly int m_iCurrentThinkContext = 0x504;
        public readonly int m_aThinkFunctions = 0x508;
        public readonly bool m_bDisabledContextThinks = 0x520;
        public readonly float m_flAnimTime = 0x524;
        public readonly float m_flSimulationTime = 0x528;
        public readonly int m_nSceneObjectOverrideFlags = 0x52c;
        public readonly bool m_bHasSuccessfullyInterpolated = 0x52d;
        public readonly bool m_bHasAddedVarsToInterpolation = 0x52e;
        public readonly bool m_bRenderEvenWhenNotSuccessfullyInterpolated = 0x52f;
        public readonly int m_nInterpolationLatchDirtyFlags = 0x530;
        public readonly int m_ListEntry = 0x538;
        public readonly float m_flCreateTime = 0x550;
        public readonly int m_EntClientFlags = 0x554;
        public readonly bool m_bClientSideRagdoll = 0x556;
        public readonly int m_iTeamNum = 0x557;
        public readonly string m_spawnflags = 0x558;
        public readonly int m_nNextThinkTick = 0x55c;
        public readonly int m_fFlags = 0x564;
        public readonly Vector3 m_vecAbsVelocity = 0x568;
        public readonly Vector3 m_vecServerVelocity = 0x574;
        public readonly Vector3 m_vecVelocity = 0x5a0;
        public readonly Vector3 m_vecBaseVelocity = 0x688;
        public readonly CHandle m_hEffectEntity = 0x694;
        public readonly CHandle m_hOwnerEntity = 0x698;
        public readonly int m_MoveCollide = 0x69c;
        public readonly int m_MoveType = 0x69d;
        public readonly int m_nActualMoveType = 0x69e;
        public readonly float m_flWaterLevel = 0x6a0;
        public readonly int m_fEffects = 0x6a4;
        public readonly CHandle m_hGroundEntity = 0x6a8;
        public readonly int m_nGroundBodyIndex = 0x6ac;
        public readonly float m_flFriction = 0x6b0;
        public readonly float m_flElasticity = 0x6b4;
        public readonly float m_flGravityScale = 0x6b8;
        public readonly float m_flTimeScale = 0x6bc;
        public readonly bool m_bAnimatedEveryTick = 0x6c0;
        public readonly bool m_bGravityDisabled = 0x6c1;
        public readonly float m_flNavIgnoreUntilTime = 0x6c4;
        public readonly CHandle m_hThink = 0x6c8;
        public readonly int m_fBBoxVisFlags = 0x6d8;
        public readonly float m_flActualGravityScale = 0x6dc;
        public readonly bool m_bGravityActuallyDisabled = 0x6e0;
        public readonly bool m_bPredictable = 0x6e1;
        public readonly bool m_bRenderWithViewModels = 0x6e2;
        public readonly int m_nFirstPredictableCommand = 0x6e4;
        public readonly int m_nLastPredictableCommand = 0x6e8;
        public readonly CHandle m_hOldMoveParent = 0x6ec;
        public readonly int m_Particles = 0x6f0;
        public readonly Vector3 m_vecAngVelocity = 0x720;
        public readonly int m_DataChangeEventRef = 0x72c;
        public readonly int m_dependencies = 0x730;
        public readonly int m_nCreationTick = 0x748;
        public readonly bool m_bAnimTimeChanged = 0x761;
        public readonly bool m_bSimulationTimeChanged = 0x762;
        public readonly string m_sUniqueHammerID = 0x770;
        public readonly int m_nBloodType = 0x778;
    }

    // Address: 0x4581310
    public class CFilterMassGreater
    {
        // Fields (2):
        public readonly Vector3 m_vecOptions = 0x0;
        public readonly float m_flTotalProbability = 0x18;
    }

    // Address: 0x4581470
    public class CFilterTeam
    {
        // Fields (6):
        public readonly CHandle m_hMaterial = 0x0;
        public readonly string m_sSequenceName = 0x8;
        public readonly float m_flProbability = 0x10;
        public readonly bool m_bEnableAngleBetweenNormalAndGravityRange = 0x14;
        public readonly float m_flMinAngleBetweenNormalAndGravity = 0x18;
        public readonly float m_flMaxAngleBetweenNormalAndGravity = 0x1c;
    }

    // Address: 0x45539c8
    public class CFlashlightEffect
    {
        // Fields (6):
        public readonly CHandle m_hSequence = 0x0;
        public readonly float m_flSeqStartTime = 0x4;
        public readonly float m_flSeqFixedCycle = 0x8;
        public readonly int m_nSeqLoopMode = 0xc;
        public readonly float m_flPlaybackRate = 0x10;
        public readonly float m_flCyclesPerSecond = 0x14;
    }

    // Address: 0x4566ce8
    public class CFootstepTableHandle
    {
        // Fields (4):
        public readonly int m_nPlatWindowWidth = 0x18;
        public readonly int m_nPlatWindowHeight = 0x1c;
        public readonly int m_nRenderWidth = 0x20;
        public readonly int m_nRenderHeight = 0x24;
    }

    // Address: 0x45c2c68
    public class CFuseProgram
    {
        // Fields (3):
        public readonly int m_nType = 0x0;
        public readonly int m_Value = 0x8;
        public readonly int m_RequiredRuntimeType = 0x10;
    }

    // Address: 0x45c3328
    public class CFuseSymbolTable
    {
        // Fields (5):
        public readonly int m_nReg = 0x0;
        public readonly int m_Type = 0x8;
        public readonly int m_OriginName = 0x20;
        public readonly int m_nWrittenByInstruction = 0x58;
        public readonly int m_nLastReadByInstruction = 0x5c;
    }

    // Address: 0x4552850
    public class CGameSceneNode
    {
        // Fields (2):
        public readonly int m_TimeBetweenEvents = 0x0;
        public readonly int m_fNextEvent = 0x4;
    }

    // Address: 0x4552d68
    public class CGameSceneNodeHandle
    {
        // Fields (13):
        public readonly Vector3 m_vecNormal = 0x1148;
        public readonly float m_flSpriteScale = 0x1154;
        public readonly int m_nFlickerFrame = 0x1158;
        public readonly float m_flFrameRate = 0x115c;
        public readonly float m_flFrame = 0x1160;
        public readonly IntPtr m_pszImpactEffect = 0x1168;
        public readonly IntPtr m_pszParticleEffect = 0x1170;
        public readonly bool m_bParticleCollision = 0x1178;
        public readonly int m_iLastCollisionFrame = 0x117c;
        public readonly int m_vLastCollisionOrigin = 0x1180;
        public readonly Vector3 m_vecTempEntVelocity = 0x118c;
        public readonly Vector3 m_vecPrevAbsOrigin = 0x1198;
        public readonly Vector3 m_vecTempEntAcceleration = 0x11a4;
    }

    // Address: 0x458b530
    public class CGlobalLightBase
    {
        // Fields (14):
        public readonly bool m_bActive = 0x1120;
        public readonly bool m_bWasActive = 0x1121;
        public readonly float m_flEndTime = 0x1124;
        public readonly float m_flStartTime = 0x1128;
        public readonly float m_flStartTimeInCommentary = 0x112c;
        public readonly int m_iszCommentaryFile = 0x1130;
        public readonly int m_iszTitle = 0x1138;
        public readonly int m_iszSpeakers = 0x1140;
        public readonly int m_iNodeNumber = 0x1148;
        public readonly int m_iNodeNumberMax = 0x114c;
        public readonly bool m_bListenedTo = 0x1150;
        public readonly string m_sndCommentary = 0x1158;
        public readonly CHandle m_hViewPosition = 0x1160;
        public readonly bool m_bRestartAfterRestore = 0x1164;
    }

    // Address: 0x45a3090
    public class CGrenadeTracer
    {
        // Fields (2):
        public readonly int m_Attributes = 0x8;
        public readonly IntPtr m_pManager = 0x70;
    }

    // Address: 0x45b4468
    public class CHECK_CONTENT
    {
        // Fields (3):
        public readonly int m_ID = 0x0;
        public readonly IntPtr m_primaryWeightList = 0x8;
        public readonly string m_secondaryWeightLists = 0x118;
    }

    // Address: 0x452d190
    public class CHitboxComponent
    {
        // Fields (29):
        public readonly int m_Entity_Color = 0x17f8;
        public readonly int m_Entity_flBrightness = 0x17fc;
        public readonly int m_Entity_hCubemapTexture = 0x1800;
        public readonly int m_Entity_bCustomCubemapTexture = 0x1808;
        public readonly int m_Entity_hLightProbeTexture_AmbientCube = 0x1810;
        public readonly int m_Entity_hLightProbeTexture_SDF = 0x1818;
        public readonly int m_Entity_hLightProbeTexture_SH2_DC = 0x1820;
        public readonly int m_Entity_hLightProbeTexture_SH2_R = 0x1828;
        public readonly int m_Entity_hLightProbeTexture_SH2_G = 0x1830;
        public readonly int m_Entity_hLightProbeTexture_SH2_B = 0x1838;
        public readonly int m_Entity_hLightProbeDirectLightIndicesTexture = 0x1840;
        public readonly int m_Entity_hLightProbeDirectLightScalarsTexture = 0x1848;
        public readonly int m_Entity_hLightProbeDirectLightShadowsTexture = 0x1850;
        public readonly int m_Entity_vBoxMins = 0x1858;
        public readonly int m_Entity_vBoxMaxs = 0x1864;
        public readonly int m_Entity_bMoveable = 0x1870;
        public readonly int m_Entity_nHandshake = 0x1874;
        public readonly int m_Entity_nEnvCubeMapArrayIndex = 0x1878;
        public readonly int m_Entity_nPriority = 0x187c;
        public readonly int m_Entity_bStartDisabled = 0x1880;
        public readonly int m_Entity_flEdgeFadeDist = 0x1884;
        public readonly int m_Entity_vEdgeFadeDists = 0x1888;
        public readonly int m_Entity_nLightProbeSizeX = 0x1894;
        public readonly int m_Entity_nLightProbeSizeY = 0x1898;
        public readonly int m_Entity_nLightProbeSizeZ = 0x189c;
        public readonly int m_Entity_nLightProbeAtlasX = 0x18a0;
        public readonly int m_Entity_nLightProbeAtlasY = 0x18a4;
        public readonly int m_Entity_nLightProbeAtlasZ = 0x18a8;
        public readonly int m_Entity_bEnabled = 0x18c1;
    }

    // Address: 0x4570828
    public class CHostageRescueZone
    {
        // Fields (7):
        public readonly int m_zoomLevel = 0x2b68;
        public readonly int m_iBurstShotsRemaining = 0x2b6c;
        public readonly int m_iSilencerBodygroup = 0x2b70;
        public readonly string m_silencedModelIndex = 0x2b80;
        public readonly int m_inPrecache = 0x2b84;
        public readonly bool m_bNeedsBoltAction = 0x2b85;
        public readonly int m_nRevolverCylinderIdx = 0x2b88;
    }

    // Address: 0x453d770
    public class CInfoFan
    {
        // Fields (4):
        public readonly bool m_bDisabled = 0x77c;
        public readonly bool m_bWasEnabled = 0x784;
        public readonly int m_iszSoundAreaType = 0x788;
        public readonly int m_vPos = 0x790;
    }

    // Address: 0x45273f0
    public class CInfoOffscreenPanoramaTexture
    {
        // Fields (13):
        public readonly bool m_bCheckCSSClasses = 0xf70;
        public readonly bool m_bIgnoreInput = 0x10e8;
        public readonly float m_flWidth = 0x10ec;
        public readonly float m_flHeight = 0x10f0;
        public readonly float m_flDPI = 0x10f4;
        public readonly float m_flInteractDistance = 0x10f8;
        public readonly float m_flDepthOffset = 0x10fc;
        public readonly uint m_unOwnerContext = 0x1100;
        public readonly uint m_unHorizontalAlign = 0x1104;
        public readonly uint m_unVerticalAlign = 0x1108;
        public readonly uint m_unOrientation = 0x110c;
        public readonly bool m_bAllowInteractionFromAllSceneWorlds = 0x1110;
        public readonly Vector3 m_vecCSSClasses = 0x1118;
    }

    // Address: 0x45c26c8
    public class CLOSE_PAREN
    {
        // Fields (14):
        public readonly int m_DomainIdentifier = 0x8;
        public readonly int m_DomainSubType = 0x18;
        public readonly int m_ParentMapName = 0x30;
        public readonly int m_ParentXmlName = 0x40;
        public readonly int m_Chunks = 0x50;
        public readonly int m_Cells = 0x68;
        public readonly int m_Vars = 0x80;
        public readonly int m_PublicOutputs = 0x98;
        public readonly int m_InvokeBindings = 0xb0;
        public readonly int m_CallInfos = 0xc8;
        public readonly int m_Constants = 0xe0;
        public readonly int m_DomainValues = 0xf8;
        public readonly int m_BlackboardReferences = 0x110;
        public readonly int m_OutputConnections = 0x128;
    }

    // Address: 0x4551c60
    internal class CLogicRelayAPI::Trigger
    {
        // Fields (5):
        public readonly int m_SoundName = 0x0;
        public readonly int m_ParticleEffect = 0x10;
        public readonly bool m_bIsIncindiary = 0xf0;
        public readonly bool m_bHasForces = 0xf1;
        public readonly int m_DecalType = 0xf8;
    }

    // Address: 0x454a4a8
    public class CLogicalEntity
    {
        // Fields (4):
        public readonly int m_Handle = 0x30;
        public readonly int m_Name = 0x38;
        public readonly int m_AssociatedEntities = 0x40;
        public readonly int m_AssociatedEntityNames = 0x58;
    }

    // Address: 0x45b4668
    public class CMS_ENVELOPED_DATA_INIT
    {
        // Fields (13):
        public readonly string m_skeleton = 0x0;
        public readonly int m_nNumFrames = 0x8;
        public readonly float m_flDuration = 0xc;
        public readonly int m_compressedPoseData = 0x10;
        public readonly int m_trackCompressionSettings = 0x20;
        public readonly int m_compressedPoseOffsets = 0x38;
        public readonly string m_secondaryAnimations = 0x78;
        public readonly float m_floatChannelData = 0x98;
        public readonly string m_syncTrack = 0xc0;
        public readonly int m_rootMotion = 0x170;
        public readonly bool m_bIsAdditive = 0x1c0;
        public readonly int m_modelSpaceSamplingChain = 0x1c8;
        public readonly int m_modelSpaceBoneSamplingIndices = 0x1e0;
    }

    // Address: 0x45b4568
    public class CMS_decrypt
    {
        // Fields (3):
        public readonly int m_nBoneIdx = 0x0;
        public readonly int m_nParentBoneIdx = 0x4;
        public readonly int m_nParentChainLinkIdx = 0x8;
    }

    // Address: 0x45b48a8
    public class CMS_set_detached
    {
        // Fields (2):
        public readonly int m_range = 0x0;
        public readonly bool m_bIsStatic = 0x8;
    }

    // Address: 0x45535e8
    public class CNetworkOriginCellCoordQuantizedVectorWS
    {
        // Fields (8):
        public readonly CHandle m_hSequence = 0x8;
        public readonly float m_flPrevCycle = 0xc;
        public readonly float m_flCycle = 0x10;
        public readonly float m_flWeight = 0x14;
        public readonly bool m_bSequenceChangeNetworked = 0x1c;
        public readonly bool m_bDiscontinuity = 0x1d;
        public readonly float m_flPrevCycleFromDiscontinuity = 0x20;
        public readonly float m_flPrevCycleForAnimEventDetection = 0x24;
    }

    // Address: 0x4553348
    public class CNetworkVelocityVector
    {
        // Fields (14):
        public readonly CHandle m_hModel = 0xa0;
        public readonly int m_ModelName = 0xa8;
        public readonly IntPtr m_pVPhysicsAggregate = 0xe0;
        public readonly float m_flRootBoneOffset_x = 0xe8;
        public readonly float m_flRootBoneOffset_y = 0xec;
        public readonly float m_flRootBoneOffset_z = 0xf0;
        public readonly int m_nRootBoneOffsetResetSerialNumber = 0xf4;
        public readonly bool m_bClientClothCreationSuppressed = 0x110;
        public readonly int m_nAnimStateNoInterpSerialNumber = 0x200;
        public readonly int m_MeshGroupMask = 0x208;
        public readonly int m_nBodyGroupChoices = 0x268;
        public readonly int m_nIdealMotionType = 0x2b2;
        public readonly int m_nForceLOD = 0x2b3;
        public readonly int m_nClothUpdateFlags = 0x2b4;
    }

    // Address: 0x4553268
    public class CNetworkViewOffsetVector
    {
        // Fields (7):
        public readonly int m_modelState = 0x140;
        public readonly bool m_bUseParentRenderBounds = 0x400;
        public readonly bool m_bDisableSolidCollisionsForHierarchy = 0x401;
        public readonly bool m_bDirtyMotionType = 0x402;
        public readonly bool m_bIsGeneratingLatchedParentSpaceState = 0x403;
        public readonly int m_materialGroup = 0x408;
        public readonly int m_nHitboxSet = 0x40c;
    }

    // Address: 0x45cddc8
    public class CNewParticleEffect
    {
        // Fields (29):
        public readonly bool m_bEnabled = 0x0;
        public readonly int m_nMutatorCommandType = 0x4;
        public readonly string m_strInitWith_Container = 0x8;
        public readonly string m_strCopyProperty_InputContainerSrc = 0x10;
        public readonly string m_strCopyProperty_InputContainerProperty = 0x18;
        public readonly string m_strCopyProperty_TargetProperty = 0x20;
        public readonly string m_strRandomRollInputVars_SeedInputVar = 0x28;
        public readonly Vector3 m_vecRandomRollInputVars_InputVarsToRoll = 0x30;
        public readonly string m_strCopyMatchingKeys_InputContainerSrc = 0x48;
        public readonly string m_strCopyKeysWithSuffix_InputContainerSrc = 0x50;
        public readonly string m_strCopyKeysWithSuffix_FindSuffix = 0x58;
        public readonly string m_strCopyKeysWithSuffix_ReplaceSuffix = 0x60;
        public readonly int m_nSetValue_Value = 0x68;
        public readonly string m_strGenerateTexture_TargetParam = 0x2f0;
        public readonly string m_strGenerateTexture_InitialContainer = 0x2f8;
        public readonly int m_nResolution = 0x300;
        public readonly bool m_bIsScratchTarget = 0x304;
        public readonly string m_strCompressionFormat = 0x308;
        public readonly bool m_bSplatDebugInfo = 0x310;
        public readonly bool m_bCaptureInRenderDoc = 0x311;
        public readonly Vector3 m_vecTexGenInstructions = 0x318;
        public readonly Vector3 m_vecConditionalMutators = 0x330;
        public readonly string m_strPopInputQueue_Container = 0x348;
        public readonly string m_strDrawText_InputContainerSrc = 0x350;
        public readonly string m_strDrawText_InputContainerProperty = 0x358;
        public readonly Vector3 m_vecDrawText_Position = 0x360;
        public readonly int m_colDrawText_Color = 0x368;
        public readonly string m_strDrawText_Font = 0x370;
        public readonly Vector3 m_vecConditions = 0x378;
    }

    // Address: 0x45b7d68
    public class CNmAdditiveBlendTask
    {
        // Fields (2):
        public readonly bool m_blendRanges = 0x0;
        public readonly IntPtr m_parameterRange = 0x48;
    }

    // Address: 0x45ba7e8
    internal class CNmAndNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_eventConditionRules = 0xc;
        public readonly int m_defaultValue = 0x10;
    }

    // Address: 0x45b6e28
    public class CNmBitFlags
    {
        // Fields (2):
        public readonly int m_animEventClassName = 0x18;
        public readonly int m_KV = 0x20;
    }

    // Address: 0x45b9fc8
    internal class CNmBlend2DNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_infoType = 0xc;
    }

    // Address: 0x45b7e68
    public class CNmBlendTask
    {
        // Fields (3):
        public readonly int m_nInputIdx0 = 0x0;
        public readonly int m_nInputIdx1 = 0x2;
        public readonly IntPtr m_parameterValueRange = 0x4;
    }

    // Address: 0x45b8988
    public class CNmBodyGroupEvent
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_mode = 0xc;
    }

    // Address: 0x45ba3e8
    internal class CNmBoneMaskBlendNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly IntPtr m_phaseCondition = 0xc;
        public readonly int m_eventConditionRules = 0x10;
    }

    // Address: 0x45ba5a8
    internal class CNmBoneMaskNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_eventConditionRules = 0xc;
        public readonly int m_conditions = 0x10;
    }

    // Address: 0x45ba288
    internal class CNmBoneMaskSelectorNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_eventConditionRules = 0xc;
    }

    // Address: 0x45ba148
    internal class CNmBoneMaskSwitchNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_triggerMode = 0xc;
        public readonly string m_syncEventIdx = 0x10;
    }

    // Address: 0x45b63e8
    public class CNmBoneWeightList
    {
        // Fields (12):
        public readonly int m_nLeftEffectorBoneIdx = 0x60;
        public readonly int m_nRightEffectorBoneIdx = 0x64;
        public readonly int m_leftTargetTransform = 0x70;
        public readonly int m_rightTargetTransform = 0x90;
        public readonly int m_nLeftTargetBoneIdx = 0xb0;
        public readonly int m_nRightTargetBoneIdx = 0xb4;
        public readonly int m_leftTarget = 0xc0;
        public readonly int m_rightTarget = 0xf0;
        public readonly bool m_blendMode = 0x120;
        public readonly float m_flBlendWeight = 0x124;
        public readonly bool m_bIsTargetInWorldSpace = 0x128;
        public readonly bool m_bIsRunningFromDeserializedData = 0x129;
    }

    // Address: 0x45b7f68
    public class CNmCachedPoseReadTask
    {
        // Fields (3):
        public readonly string m_sourceNodeIndices = 0x10;
        public readonly int m_nInputParameterValueNodeIdx = 0x28;
        public readonly bool m_bAllowLooping = 0x2a;
    }

    // Address: 0x45ba988
    internal class CNmCachedVectorNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_eventConditionRules = 0xc;
        public readonly int m_eventIDs = 0x10;
    }

    // Address: 0x45bad68
    internal class CNmChainLookatNode::CDefinition
    {
        // Fields (5):
        public readonly int m_conditionNodeIndices = 0x10;
        public readonly int m_values = 0x28;
        public readonly float m_flDefaultValue = 0x48;
        public readonly float m_flEaseTime = 0x4c;
        public readonly int m_easingOp = 0x50;
    }

    // Address: 0x45b8068
    public class CNmChainLookatTask
    {
        // Fields (7):
        public readonly string m_sourceNodeIndices = 0x10;
        public readonly int m_values = 0x28;
        public readonly int m_indices = 0x80;
        public readonly CHandle m_hullIndices = 0xa8;
        public readonly int m_nInputParameterNodeIdx0 = 0xc0;
        public readonly int m_nInputParameterNodeIdx1 = 0xc2;
        public readonly bool m_bAllowLooping = 0xc4;
    }

    // Address: 0x45baf28
    internal class CNmClipNode::CDefinition
    {
        // Fields (5):
        public readonly int m_nSwitchValueNodeIdx = 0xa;
        public readonly int m_nTrueValueNodeIdx = 0xc;
        public readonly int m_nFalseValueNodeIdx = 0xe;
        public readonly float m_flFalseValue = 0x10;
        public readonly float m_flTrueValue = 0x14;
    }

    // Address: 0x45bb0c8
    internal class CNmClipReferenceNode::CDefinition
    {
        // Fields (3):
        public readonly int m_range = 0xc;
        public readonly int m_nInputValueNodeIdx = 0x14;
        public readonly bool m_bIsInclusiveCheck = 0x16;
    }

    // Address: 0x45bb468
    internal class CNmConstBoolNode::CDefinition
    {
        // Fields (5):
        public readonly float m_flStartValue = 0xc;
        public readonly float m_flHertz = 0x10;
        public readonly float m_flDampingRatio = 0x14;
        public readonly int m_nInputValueNodeIdx = 0x18;
        public readonly bool m_bUseStartValue = 0x1a;
    }

    // Address: 0x45bb3a8
    internal class CNmConstIDNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_curve = 0x10;
    }

    // Address: 0x45bb168
    internal class CNmConstTargetNode::CDefinition
    {
        // Fields (5):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_nComparandValueNodeIdx = 0xc;
        public readonly int m_comparison = 0xe;
        public readonly float m_flEpsilon = 0x10;
        public readonly float m_flComparisonValue = 0x14;
    }

    // Address: 0x45bb228
    internal class CNmConstVectorNode::CDefinition
    {
        // Fields (6):
        public readonly int m_nInputValueNodeIdxA = 0xa;
        public readonly int m_nInputValueNodeIdxB = 0xc;
        public readonly bool m_bReturnAbsoluteResult = 0xe;
        public readonly bool m_bReturnNegatedResult = 0xf;
        public readonly int m_operator = 0x10;
        public readonly float m_flValueB = 0x14;
    }

    // Address: 0x45bbc28
    internal class CNmControlParameterBoolNode::CDefinition
    {
        // Fields (8):
        public readonly int m_leftEffectorBoneID = 0x10;
        public readonly int m_rightEffectorBoneID = 0x18;
        public readonly int m_nLeftTargetNodeIdx = 0x20;
        public readonly int m_nRightTargetNodeIdx = 0x22;
        public readonly int m_nEnabledNodeIdx = 0x24;
        public readonly float m_flBlendTimeSeconds = 0x28;
        public readonly bool m_blendMode = 0x2c;
        public readonly bool m_bIsTargetInWorldSpace = 0x2d;
    }

    // Address: 0x45bbae8
    internal class CNmControlParameterFloatNode::CDefinition
    {
        // Fields (4):
        public readonly bool m_bone = 0x10;
        public readonly int m_followTargetBone = 0x18;
        public readonly int m_nEnabledNodeIdx = 0x20;
        public readonly int m_mode = 0x22;
    }

    // Address: 0x45bbfe8
    internal class CNmCurrentSyncEventIDNode::CDefinition
    {
        // Fields (4):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_defaultValue = 0xc;
        public readonly int m_IDs = 0x10;
        public readonly int m_values = 0x40;
    }

    // Address: 0x45bbf08
    internal class CNmCurrentSyncEventNode::CDefinition
    {
        // Fields (5):
        public readonly int m_nSwitchValueNodeIdx = 0xa;
        public readonly int m_nTrueValueNodeIdx = 0xc;
        public readonly int m_nFalseValueNodeIdx = 0xe;
        public readonly int m_falseValue = 0x10;
        public readonly int m_trueValue = 0x18;
    }

    // Address: 0x45b8fc8
    public class CNmEntityAttributeFloatEvent
    {
        // Fields (8):
        public readonly int m_nPlayInReverseValueNodeIdx = 0xa;
        public readonly int m_nResetTimeValueNodeIdx = 0xc;
        public readonly bool m_bSampleRootMotion = 0xe;
        public readonly bool m_bAllowLooping = 0xf;
        public readonly int m_nDataSlotIdx = 0x10;
        public readonly int m_graphEvents = 0x18;
        public readonly float m_flSpeedMultiplier = 0x40;
        public readonly int m_nStartSyncEventOffset = 0x44;
    }

    // Address: 0x45b6ba8
    public class CNmEvent
    {
        // Fields (10):
        public readonly int m_nEffectorBoneIdx = 0x60;
        public readonly int m_nEffectorTargetBoneIdx = 0x64;
        public readonly int m_targetTransform = 0x70;
        public readonly int m_effectorTarget = 0x90;
        public readonly bool m_blendMode = 0xc0;
        public readonly float m_flBlendWeight = 0xc4;
        public readonly bool m_bIsTargetInWorldSpace = 0xc8;
        public readonly bool m_bIsRunningFromDeserializedData = 0xc9;
        public readonly float m_flChainRotationWeight = 0xcc;
        public readonly int m_debugEffectorBoneID = 0xd0;
    }

    // Address: 0x45b6d08
    public class CNmEventRelevance_t
    {
        // Fields (2):
        public readonly int m_ID = 0x18;
        public readonly string m_secondaryID = 0x20;
    }

    // Address: 0x45bcb48
    internal class CNmExternalPoseNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nReferencedGraphIdx = 0xa;
        public readonly int m_nFallbackNodeIdx = 0xc;
    }

    // Address: 0x45ba4e8
    internal class CNmFixedWeightBoneMaskNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly IntPtr m_phaseCondition = 0xc;
        public readonly int m_eventConditionRules = 0x10;
    }

    // Address: 0x45b6ee8
    internal class CNmFloatChannelData::ChannelSettings_t
    {
        // Fields (7):
        public readonly int m_target = 0x18;
        public readonly int m_attributeName = 0x20;
        public readonly int m_attributeNameToken = 0x28;
        public readonly int m_x = 0x30;
        public readonly int m_y = 0x70;
        public readonly int m_z = 0xb0;
        public readonly int m_w = 0xf0;
    }

    // Address: 0x45bd068
    internal class CNmFloatComparisonNode::CDefinition
    {
        // Fields (5):
        public readonly int m_optionNodeIndices = 0x10;
        public readonly int m_optionIDs = 0x28;
        public readonly int m_nParameterNodeIdx = 0x58;
        public readonly int m_nFallbackNodeIdx = 0x5a;
        public readonly bool m_bIgnoreInvalidOptions = 0x5c;
    }

    // Address: 0x45b8a88
    public class CNmFloatCurveEvent
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_mode = 0xc;
    }

    // Address: 0x45bd308
    internal class CNmFloatCurveNode::CDefinition
    {
        // Fields (5):
        public readonly int m_optionNodeIndices = 0x10;
        public readonly int m_optionWeights = 0x28;
        public readonly IntPtr m_parameterNodeIdx = 0x38;
        public readonly bool m_bIgnoreInvalidOptions = 0x3a;
        public readonly bool m_bHasWeightsSet = 0x3b;
    }

    // Address: 0x45bd528
    internal class CNmFloatEaseNode::CDefinition
    {
        // Fields (2):
        public readonly int m_optionNodeIndices = 0x10;
        public readonly int m_conditionNodeIndices = 0x28;
    }

    // Address: 0x45bd1a8
    internal class CNmFloatMathNode::CDefinition
    {
        // Fields (5):
        public readonly int m_optionNodeIndices = 0x10;
        public readonly int m_optionWeights = 0x28;
        public readonly IntPtr m_parameterNodeIdx = 0x38;
        public readonly bool m_bIgnoreInvalidOptions = 0x3a;
        public readonly bool m_bHasWeightsSet = 0x3b;
    }

    // Address: 0x45bd9e8
    internal class CNmFloatMathNode::Operator_t
    {
        // Fields (3):
        public readonly int m_ID = 0x0;
        public readonly float m_flTimeValueSeconds = 0x8;
        public readonly int m_comparisionOperator = 0xc;
    }

    // Address: 0x45bcf68
    internal class CNmFloatRangeComparisonNode::CDefinition
    {
        // Fields (5):
        public readonly int m_optionNodeIndices = 0x10;
        public readonly int m_optionIDs = 0x28;
        public readonly int m_nParameterNodeIdx = 0x58;
        public readonly int m_nFallbackNodeIdx = 0x5a;
        public readonly bool m_bIgnoreInvalidOptions = 0x5c;
    }

    // Address: 0x45bd748
    internal class CNmFloatRemapNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xc;
        public readonly float m_flDefaultInputValue = 0x10;
    }

    // Address: 0x45bd848
    internal class CNmFloatRemapNode::RemapRange_t
    {
        // Fields (11):
        public readonly int m_nChildNodeIdx = 0xa;
        public readonly int m_entryEvents = 0x10;
        public readonly int m_executeEvents = 0x30;
        public readonly int m_exitEvents = 0x50;
        public readonly int m_timedRemainingEvents = 0x70;
        public readonly int m_timedElapsedEvents = 0x88;
        public readonly int m_nLayerWeightNodeIdx = 0xa0;
        public readonly int m_nLayerRootMotionWeightNodeIdx = 0xa2;
        public readonly int m_nLayerBoneMaskNodeIdx = 0xa4;
        public readonly bool m_bIsOffState = 0xa6;
        public readonly bool m_bUseActualElapsedTimeInStateForTimedEvents = 0xa7;
    }

    // Address: 0x45bcc08
    internal class CNmFloatSelectorNode::CDefinition
    {
        // Fields (8):
        public readonly int m_desiredMovingVelocityNodeIdx = 0xc;
        public readonly int m_desiredFacingDirectionNodeIdx = 0xe;
        public readonly int m_linearVelocityLimitNodeIdx = 0x10;
        public readonly QAngle m_angularVelocityLimitNodeIdx = 0x12;
        public readonly int m_enabledNodeIdx = 0x14;
        public readonly int m_maxLinearVelocity = 0x18;
        public readonly int m_maxAngularVelocityRadians = 0x1c;
        public readonly int m_overrideFlags = 0x20;
    }

    // Address: 0x45bd3e8
    internal class CNmFloatSpringNode::CDefinition
    {
        // Fields (2):
        public readonly int m_optionNodeIndices = 0x10;
        public readonly int m_conditionNodeIndices = 0x28;
    }

    // Address: 0x45bce28
    internal class CNmFloatSwitchNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nMaskNodeIdx = 0xc;
        public readonly int m_nEnableNodeIdx = 0xe;
    }

    // Address: 0x45b81e8
    public class CNmFollowBoneTask
    {
        // Fields (5):
        public readonly int m_nSwitchValueNodeIdx = 0xa;
        public readonly int m_nTrueValueNodeIdx = 0xc;
        public readonly int m_nFalseValueNodeIdx = 0xe;
        public readonly float m_flBlendTimeSeconds = 0x10;
        public readonly bool m_bSwitchDynamically = 0x14;
    }

    // Address: 0x45bc388
    internal class CNmFootEventConditionNode::CDefinition
    {
        // Fields (8):
        public readonly int m_nInputNodeIdx = 0x0;
        public readonly int m_nWeightValueNodeIdx = 0x2;
        public readonly int m_nBoneMaskValueNodeIdx = 0x4;
        public readonly int m_nRootMotionWeightValueNodeIdx = 0x6;
        public readonly bool m_bIsSynchronized = 0x8;
        public readonly bool m_bIgnoreEvents = 0x9;
        public readonly bool m_bIsStateMachineLayer = 0xa;
        public readonly bool m_blendMode = 0xb;
    }

    // Address: 0x45bdb68
    internal class CNmFootIKNode::CDefinition
    {
        // Fields (5):
        public readonly string m_sourceStateNodeIdx = 0xa;
        public readonly int m_nInputValueNodeIdx = 0xc;
        public readonly float m_flComparand = 0x10;
        public readonly int m_type = 0x14;
        public readonly int m_operator = 0x15;
    }

    // Address: 0x45bc288
    internal class CNmFootstepEventPercentageThroughNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nBaseNodeIdx = 0xa;
        public readonly bool m_bOnlySampleBaseRootMotion = 0xc;
        public readonly int m_layerDefinition = 0x10;
    }

    // Address: 0x45b8b68
    public class CNmFrameSnapEvent
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_mode = 0xc;
    }

    // Address: 0x45bc588
    internal class CNmGraphEventConditionNode::Condition_t
    {
        // Fields (6):
        public readonly int m_nClipReferenceNodeIdx = 0xa;
        public readonly int m_nTargetValueNodeIdx = 0xc;
        public readonly bool m_bIsOffsetNode = 0xe;
        public readonly bool m_bIsOffsetRelativeToCharacter = 0xf;
        public readonly bool m_bWarpTranslation = 0x10;
        public readonly string m_samplingMode = 0x11;
    }

    // Address: 0x45bef28
    internal class CNmIDBasedSelectorNode::CDefinition
    {
        // Fields (4):
        public readonly int m_inputVectorValueNodeIdx = 0xa;
        public readonly int m_inputValueXNodeIdx = 0xc;
        public readonly int m_inputValueYNodeIdx = 0xe;
        public readonly int m_inputValueZNodeIdx = 0x10;
    }

    // Address: 0x45be068
    internal class CNmIDComparisonNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nStateNodeIdx = 0x0;
        public readonly int m_nEntryConditionNodeIdx = 0x2;
        public readonly int m_transitionDefinitions = 0x8;
    }

    // Address: 0x45be168
    internal class CNmIDComparisonNode::Comparison_t
    {
        // Fields (4):
        public readonly int m_nTargetStateIdx = 0x0;
        public readonly int m_nConditionNodeIdx = 0x2;
        public readonly int m_nTransitionNodeIdx = 0x4;
        public readonly bool m_bCanBeForced = 0x6;
    }

    // Address: 0x45b8c88
    public class CNmIDEvent
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_mode = 0xc;
    }

    // Address: 0x45bc768
    internal class CNmIDEventNode::CDefinition
    {
        // Fields (5):
        public readonly int m_nPoseTimeValueNodeIdx = 0xa;
        public readonly int m_nDataSlotIdx = 0xc;
        public readonly int m_inputTimeRemapRange = 0x10;
        public readonly float m_flUserSpecifiedTime = 0x18;
        public readonly bool m_bUseFramesAsInput = 0x1c;
    }

    // Address: 0x45bde08
    internal class CNmIDSwitchNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_nTransitionDurationOverrideNodeIdx = 0xc;
        public readonly float m_flTransitionDurationSeconds = 0x10;
    }

    // Address: 0x45bdf48
    internal class CNmIDToFloatNode::CDefinition
    {
        // Fields (2):
        public readonly string m_stateDefinitions = 0x10;
        public readonly int m_nDefaultStateIndex = 0x130;
    }

    // Address: 0x45be2c8
    internal class CNmLayerBlendNode::LayerDefinition_t
    {
        // Fields (4):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly bool m_bIsBoneSpaceOffset = 0xc;
        public readonly int m_rotationOffset = 0x10;
        public readonly int m_translationOffset = 0x20;
    }

    // Address: 0x45b8d68
    public class CNmLegacyEvent
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_mode = 0xc;
    }

    // Address: 0x45b8e48
    public class CNmMaterialAttributeEvent
    {
        // Fields (9):
        public readonly int m_endEffectorBoneID = 0x10;
        public readonly int m_endEffectorForwardAxis = 0x18;
        public readonly int m_endEffectorOffset = 0x24;
        public readonly int m_nLookatTargetNodeIdx = 0x30;
        public readonly int m_nEnabledNodeIdx = 0x32;
        public readonly float m_flBlendTimeSeconds = 0x34;
        public readonly int m_chainWeights = 0x38;
        public readonly int m_nChainLength = 0x68;
        public readonly bool m_bIsTargetInWorldSpace = 0x69;
    }

    // Address: 0x45ba668
    internal class CNmNotNode::CDefinition
    {
        // Fields (2):
        public readonly int m_eventID = 0x0;
        public readonly int m_eventTypeCondition = 0x8;
    }

    // Address: 0x45ba728
    internal class CNmOrNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nSourceStateNodeIdx = 0xa;
        public readonly int m_eventConditionRules = 0xc;
        public readonly int m_eventID = 0x10;
    }

    // Address: 0x45be4c8
    internal class CNmOrientationWarpNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_infoType = 0xc;
        public readonly bool m_bIsWorldSpaceTarget = 0x10;
    }

    // Address: 0x45b9dc8
    internal class CNmParameterizedBlendNode::BlendRange_t
    {
        // Fields (4):
        public readonly int m_eventID = 0x10;
        public readonly int m_nDefaultNodeIdx = 0x18;
        public readonly float m_flDefaultValue = 0x1c;
        public readonly int m_eventConditionRules = 0x20;
    }

    // Address: 0x45b9ec8
    internal class CNmParameterizedBlendNode::CDefinition
    {
        // Fields (4):
        public readonly int m_requireRuleID = 0x10;
        public readonly int m_eventConditionRules = 0x18;
        public readonly int m_nSourceStateNodeIdx = 0x1c;
        public readonly int m_ruleCondition = 0x1e;
    }

    // Address: 0x45bf068
    internal class CNmParameterizedClipSelectorNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_desiredInfo = 0xc;
    }

    // Address: 0x45be628
    internal class CNmPassthroughNode::CDefinition
    {
        // Fields (6):
        public readonly int m_optionNodeIndices = 0x10;
        public readonly float m_flOrientationScoreWeight = 0x28;
        public readonly float m_flPositionScoreWeight = 0x2c;
        public readonly IntPtr m_parameterNodeIdx = 0x30;
        public readonly bool m_bIgnoreInvalidOptions = 0x32;
        public readonly bool m_bIsWorldSpaceTarget = 0x33;
    }

    // Address: 0x45c13e8
    internal class CNmPoseNode::CDefinition
    {
        // Fields (6):
        public readonly int m_constants = 0x0;
        public readonly int m_variables = 0x18;
        public readonly int m_functions = 0x30;
        public readonly int m_constantMap = 0x48;
        public readonly int m_variableMap = 0x68;
        public readonly int m_functionMap = 0x88;
    }

    // Address: 0x45be828
    internal class CNmReferencePoseNode::CDefinition
    {
        // Fields (11):
        public readonly int m_nClipReferenceNodeIdx = 0xa;
        public readonly int m_nTargetValueNodeIdx = 0xc;
        public readonly string m_samplingMode = 0xe;
        public readonly int m_targetUpdateRule = 0xf;
        public readonly bool m_bAlignWithTargetAtLastWarpEvent = 0x10;
        public readonly float m_flSamplingPositionErrorThresholdSq = 0x14;
        public readonly float m_flMaxTangentLength = 0x18;
        public readonly float m_flLerpFallbackDistanceThreshold = 0x1c;
        public readonly float m_flTargetUpdateDistanceThreshold = 0x20;
        public readonly float m_flTargetUpdateAngleThresholdRadians = 0x24;
        public readonly int m_alignmentBoneID = 0x28;
    }

    // Address: 0x45bea28
    internal class CNmReferencedGraphNode::CDefinition
    {
        // Fields (11):
        public readonly int m_nTargetStateNodeIdx = 0xa;
        public readonly int m_nDurationOverrideNodeIdx = 0xc;
        public readonly int m_timeOffsetOverrideNodeIdx = 0xe;
        public readonly string m_startBoneMaskNodeIdx = 0x10;
        public readonly float m_flDuration = 0x14;
        public readonly bool m_boneMaskBlendInTimePercentage = 0x18;
        public readonly float m_flTimeOffset = 0x1c;
        public readonly int m_transitionOptions = 0x20;
        public readonly int m_targetSyncIDNodeIdx = 0x24;
        public readonly bool m_blendWeightEasing = 0x26;
        public readonly int m_rootMotionBlend = 0x27;
    }

    // Address: 0x45b71e8
    public class CNmRootMotionData
    {
        // Fields (2):
        public readonly int m_target = 0x18;
        public readonly int m_attributeName = 0x20;
    }

    // Address: 0x45b7328
    internal class CNmRootMotionData::SamplingMode_t
    {
        // Fields (14):
        public readonly int m_relevance = 0x18;
        public readonly int m_type = 0x1c;
        public readonly int m_target = 0x20;
        public readonly CHandle m_hParticleSystem = 0x28;
        public readonly int m_tags = 0x30;
        public readonly bool m_bStopImmediately = 0x38;
        public readonly bool m_bDetachFromOwner = 0x39;
        public readonly bool m_bPlayEndCap = 0x3a;
        public readonly int m_attachmentPoint0 = 0x40;
        public readonly int m_attachmentType0 = 0x48;
        public readonly int m_attachmentPoint1 = 0x50;
        public readonly int m_attachmentType1 = 0x58;
        public readonly int m_config = 0x60;
        public readonly int m_effectForConfig = 0x68;
    }

    // Address: 0x45beca8
    internal class CNmRootMotionOverrideNode::OverrideFlags_t
    {
        // Fields (7):
        public readonly int m_effectorBoneID = 0x10;
        public readonly int m_nEffectorTargetNodeIdx = 0x18;
        public readonly int m_nEnabledNodeIdx = 0x1a;
        public readonly float m_flBlendTimeSeconds = 0x1c;
        public readonly bool m_blendMode = 0x20;
        public readonly bool m_bIsTargetInWorldSpace = 0x21;
        public readonly float m_flChainRotationWeight = 0x24;
    }

    // Address: 0x45b84c8
    public class CNmSampleTask
    {
        // Fields (6):
        public readonly int m_defaultMaskNodeIdx = 0xa;
        public readonly IntPtr m_parameterValueNodeIdx = 0xc;
        public readonly bool m_bSwitchDynamically = 0xe;
        public readonly int m_maskNodeIndices = 0x10;
        public readonly IntPtr m_parameterValues = 0x28;
        public readonly float m_flBlendTimeSeconds = 0x68;
    }

    // Address: 0x45bf688
    internal class CNmSpeedScaleBaseNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nNodeIdx = 0x0;
        public readonly string m_slotID = 0x8;
    }

    // Address: 0x45bf5e8
    internal class CNmSpeedScaleNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nNodeIdx = 0x0;
        public readonly int m_dataSlotIdx = 0x2;
    }

    // Address: 0x45bf768
    internal class CNmStateNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nNodeIdx = 0x0;
        public readonly string m_slotID = 0x8;
    }

    // Address: 0x45bf968
    internal class CNmStateNode::TimedEvent_t
    {
        // Fields (14):
        public readonly int m_variationID = 0x0;
        public readonly string m_skeleton = 0x8;
        public readonly string m_supportedSecondarySkeletons = 0x10;
        public readonly IntPtr m_pUserData = 0x28;
        public readonly IntPtr m_persistentNodeIndices = 0x30;
        public readonly int m_nRootNodeIdx = 0x48;
        public readonly int m_controlParameterIDs = 0x50;
        public readonly int m_virtualParameterIDs = 0x68;
        public readonly int m_virtualParameterNodeIndices = 0x80;
        public readonly int m_referencedGraphSlots = 0x98;
        public readonly int m_externalGraphSlots = 0xb0;
        public readonly int m_externalPoseSlots = 0xc8;
        public readonly int m_nodePaths = 0x150;
        public readonly int m_resources = 0x168;
    }

    // Address: 0x45b7828
    public class CNmSyncTrack
    {
        // Fields (2):
        public readonly int m_rule = 0x18;
        public readonly int m_ID = 0x20;
    }

    // Address: 0x45b7648
    internal class CNmSyncTrack::Event_t
    {
        // Fields (7):
        public readonly int m_relevance = 0x18;
        public readonly int m_name = 0x20;
        public readonly IntPtr m_position = 0x28;
        public readonly int m_attachmentName = 0x30;
        public readonly int m_tags = 0x38;
        public readonly bool m_bContinuePlayingSoundAtDurationEnd = 0x40;
        public readonly float m_flDurationInterruptionThreshold = 0x44;
    }

    // Address: 0x45b7ac8
    public class CNmTarget
    {
        // Fields (2):
        public readonly int m_rule = 0x18;
        public readonly int m_algorithm = 0x19;
    }

    // Address: 0x45c10e8
    internal class CNmTargetValueNode::CDefinition
    {
        // Fields (3):
        public readonly int m_name = 0x0;
        public readonly int m_nameToken = 0x8;
        public readonly float m_flValue = 0xc;
    }

    // Address: 0x45c08e8
    internal class CNmTargetWarpNode::TargetUpdateRule_t
    {
        // Fields (2):
        public readonly int m_vMinBounds = 0x0;
        public readonly int m_vMaxBounds = 0xc;
    }

    // Address: 0x45bbde8
    internal class CNmTransitionEventConditionNode::CDefinition
    {
        // Fields (3):
        public readonly int m_conditionNodeIndices = 0x10;
        public readonly int m_values = 0x28;
        public readonly int m_defaultValue = 0x58;
    }

    // Address: 0x45c0b68
    internal class CNmTransitionNode::TransitionOptions_t
    {
        // Fields (2):
        public readonly int m_nPackedMin = 0x0;
        public readonly int m_nPackedMax = 0x4;
    }

    // Address: 0x45c0e08
    internal class CNmVectorCreateNode::CDefinition
    {
        // Fields (5):
        public readonly int m_name = 0x8;
        public readonly int m_nameToken = 0x10;
        public readonly int m_nParamCount = 0x14;
        public readonly int m_nIndex = 0x18;
        public readonly bool m_bIsPure = 0x1a;
    }

    // Address: 0x45c1008
    internal class CNmVectorInfoNode::Info_t
    {
        // Fields (6):
        public readonly int m_name = 0x0;
        public readonly int m_nameToken = 0x8;
        public readonly int m_nIndex = 0xc;
        public readonly int m_nNumComponents = 0xe;
        public readonly int m_eVarType = 0xf;
        public readonly int m_eAccess = 0x10;
    }

    // Address: 0x45c0d48
    internal class CNmVectorNegateNode::CDefinition
    {
        // Fields (4):
        public readonly IntPtr m_programBuffer = 0x0;
        public readonly int m_variablesRead = 0x18;
        public readonly int m_variablesWritten = 0x30;
        public readonly int m_nMaxTempVarsUsed = 0x48;
    }

    // Address: 0x45bb8e8
    internal class CNmVirtualParameterBoolNode::CDefinition
    {
        // Fields (2):
        public readonly float m_flBegin = 0x0;
        public readonly float m_flEnd = 0x4;
    }

    // Address: 0x45bb768
    internal class CNmVirtualParameterFloatNode::CDefinition
    {
        // Fields (2):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_clampRange = 0xc;
    }

    // Address: 0x45bb828
    internal class CNmVirtualParameterIDNode::CDefinition
    {
        // Fields (3):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_inputRange = 0xc;
        public readonly int m_outputRange = 0x14;
    }

    // Address: 0x45bb5e8
    internal class CNmVirtualParameterTargetNode::CDefinition
    {
        // Fields (5):
        public readonly float m_flEaseTime = 0xc;
        public readonly float m_flStartValue = 0x10;
        public readonly int m_nInputValueNodeIdx = 0x14;
        public readonly int m_easingOp = 0x16;
        public readonly bool m_bUseStartValue = 0x17;
    }

    // Address: 0x45c2720
    public class COMMA
    {
        // Fields (4):
        public readonly int m_SourceOutput = 0x0;
        public readonly int m_TargetEntity = 0x10;
        public readonly int m_TargetInput = 0x20;
        public readonly int m_Param = 0x30;
    }

    // Address: 0x45cdce0
    internal class CParticleCollectionBindingInstance::HACK_UnusedBinding
    {
        // Fields (8):
        public readonly bool m_bEnabled = 0x0;
        public readonly int m_nCompositeMaterialInputContainerSourceType = 0x4;
        public readonly string m_strSpecificContainerMaterial = 0x8;
        public readonly string m_strAttrName = 0xe8;
        public readonly string m_strAlias = 0xf0;
        public readonly Vector3 m_vecLooseVariables = 0xf8;
        public readonly string m_strAttrNameForVar = 0x110;
        public readonly bool m_bExposeExternally = 0x118;
    }

    // Address: 0x4585ce0
    internal class CParticleSystemAPI::Start
    {
        // Fields (18):
        public readonly int m_nImpulse = 0x48;
        public readonly int m_nButtons = 0x50;
        public readonly int m_nQueuedButtonDownMask = 0x70;
        public readonly int m_nQueuedButtonChangeMask = 0x78;
        public readonly int m_nButtonDoublePressed = 0x80;
        public readonly IntPtr m_pButtonPressedCmdNumber = 0x88;
        public readonly int m_nLastCommandNumberProcessed = 0x188;
        public readonly int m_nToggleButtonDownMask = 0x190;
        public readonly float m_flCmdForwardMove = 0x1a0;
        public readonly float m_flCmdLeftMove = 0x1a4;
        public readonly float m_flCmdUpMove = 0x1a8;
        public readonly float m_flMaxspeed = 0x1ac;
        public readonly int m_arrForceSubtickMoveWhen = 0x1b0;
        public readonly float m_flForwardMove = 0x1c0;
        public readonly float m_flLeftMove = 0x1c4;
        public readonly float m_flUpMove = 0x1c8;
        public readonly Vector3 m_vecLastMovementImpulses = 0x1cc;
        public readonly Vector3 m_vecOldViewAngles = 0x240;
    }

    // Address: 0x454c168
    public class CPhysicsBodyGameMarkupData
    {
        // Fields (10):
        public readonly int m_nHitGroup = 0x0;
        public readonly int m_nDamageLevel = 0x4;
        public readonly int m_nDesiredHealth = 0x8;
        public readonly int m_nDestroyFlags = 0xc;
        public readonly int m_nDamageType = 0x10;
        public readonly float m_flBreakDamage = 0x14;
        public readonly float m_flBreakDamageRadius = 0x18;
        public readonly CHandle m_hAttacker = 0x1c;
        public readonly int m_vWsBreakDamageOrigin = 0x20;
        public readonly int m_vWsBreakDamageForce = 0x2c;
    }

    // Address: 0x4566460
    public class CPlainAutoPtr
    {
        // Fields (3):
        public readonly int m_LoopState = 0x0;
        public readonly float m_flRealTime = 0x28;
        public readonly float m_flFrameTime = 0x2c;
    }

    // Address: 0x4599d70
    public class CPlayerSprayDecalRenderHelper
    {
        // Fields (3):
        public readonly float m_flInnerAngle = 0x1248;
        public readonly float m_flOuterAngle = 0x124c;
        public readonly bool m_bShowLight = 0x1250;
    }

    // Address: 0x45879a8
    public class CPlayer_MovementServices_Humanoid
    {
        // Fields (8):
        public readonly bool m_bLoop = 0xf38;
        public readonly float m_flFPS = 0xf3c;
        public readonly CHandle m_hPositionKeys = 0xf40;
        public readonly CHandle m_hRotationKeys = 0xf48;
        public readonly int m_vAnimationBoundsMin = 0xf50;
        public readonly int m_vAnimationBoundsMax = 0xf5c;
        public readonly float m_flStartTime = 0xf68;
        public readonly float m_flStartFrame = 0xf6c;
    }

    // Address: 0x45875d0
    public class CPlayer_UseServices
    {
        // Fields (32):
        public readonly string m_szWorldModel = 0x28;
        public readonly string m_szWorldModelAg2Override = 0x108;
        public readonly string m_sToolsOnlyOwnerModelName = 0x1e8;
        public readonly bool m_bBuiltRightHanded = 0x2c8;
        public readonly bool m_bAllowFlipping = 0x2c9;
        public readonly string m_sMuzzleAttachment = 0x2d0;
        public readonly string m_szMuzzleFlashParticle = 0x2f0;
        public readonly string m_szMuzzleFlashParticleConfig = 0x3d0;
        public readonly string m_szBarrelSmokeParticle = 0x3d8;
        public readonly int m_nMuzzleSmokeShotThreshold = 0x4b8;
        public readonly float m_flMuzzleSmokeTimeout = 0x4bc;
        public readonly float m_flMuzzleSmokeDecrementRate = 0x4c0;
        public readonly bool m_bGenerateMuzzleLight = 0x4c4;
        public readonly bool m_bLinkedCooldowns = 0x4c5;
        public readonly int m_iFlags = 0x4c6;
        public readonly int m_iWeight = 0x4c8;
        public readonly bool m_bAutoSwitchTo = 0x4cc;
        public readonly bool m_bAutoSwitchFrom = 0x4cd;
        public readonly int m_nPrimaryAmmoType = 0x4ce;
        public readonly int m_nSecondaryAmmoType = 0x4cf;
        public readonly int m_iMaxClip1 = 0x4d0;
        public readonly int m_iMaxClip2 = 0x4d4;
        public readonly int m_iDefaultClip1 = 0x4d8;
        public readonly int m_iDefaultClip2 = 0x4dc;
        public readonly bool m_bReserveAmmoAsClips = 0x4e0;
        public readonly bool m_bTreatAsSingleClip = 0x4e1;
        public readonly bool m_bKeepLoadedAmmo = 0x4e2;
        public readonly int m_iRumbleEffect = 0x4e4;
        public readonly float m_flDropSpeed = 0x4e8;
        public readonly int m_iSlot = 0x4ec;
        public readonly int m_iPosition = 0x4f0;
        public readonly int m_aShootSounds = 0x4f8;
    }

    // Address: 0x45c59e0
    internal class CPulseArraylib::ArrayConcatenate
    {
        // Fields (2):
        public readonly int m_OutflowID = 0x0;
        public readonly int m_Connection = 0x8;
    }

    // Address: 0x45c9d68
    internal class CPulseCell_BaseLerp::CursorState_t
    {
        // Fields (3):
        public readonly int m_Condition = 0xd8;
        public readonly int m_WhenTrue = 0x150;
        public readonly int m_WhenFalse = 0x198;
    }

    // Address: 0x45c9fa0
    internal class CPulseCell_BaseYieldingInflow::BaseFlow_CancelAfter
    {
        // Fields (2):
        public readonly int m_Condition = 0xd8;
        public readonly int m_OnTrue = 0x150;
    }

    // Address: 0x45cab88
    public class CPulseCell_FireCursors
    {
        // Fields (2):
        public readonly int m_Attributes = 0x0;
        public readonly int m_Names = 0x28;
    }

    // Address: 0x45ca328
    public class CPulseCell_Inflow_EntOutputHandler
    {
        // Fields (2):
        public readonly bool m_bTagSelfWhenComplete = 0x128;
        public readonly int m_nDesiredKillPriority = 0x12c;
    }

    // Address: 0x45ca428
    public class CPulseCell_Inflow_GraphHook
    {
        // Fields (2):
        public readonly int m_nCursorsAllowedToWait = 0xd8;
        public readonly int m_WaitComplete = 0xe0;
    }

    // Address: 0x45c9940
    internal class CPulseCell_Inflow_Wait::Wait
    {
        // Fields (4):
        public readonly int m_Connection = 0x0;
        public readonly int m_DestinationFlowNodeID = 0x48;
        public readonly int m_RequirementNodeIDs = 0x50;
        public readonly int m_nCursorStateBlockIndex = 0x68;
    }

    // Address: 0x45c9ae8
    public class CPulseCell_Inflow_Yield
    {
        // Fields (2):
        public readonly float m_flTimeFromPrevious = 0x0;
        public readonly int m_EventOutflow = 0x8;
    }

    // Address: 0x45caee0
    internal class CPulseCell_IntervalTimer::Start
    {
        // Fields (7):
        public readonly IntPtr m_pName = 0x0;
        public readonly IntPtr m_pCPPClassname = 0x8;
        public readonly IntPtr m_pNetworkDataReferencedDescription = 0x10;
        public readonly IntPtr m_pNetworkDataReferencedPtrPropDescription = 0x18;
        public readonly int m_nRuntimeIndex = 0x20;
        public readonly int m_nFlags = 0x24;
        public readonly IntPtr m_pBaseClassComponentHelper = 0x60;
    }

    // Address: 0x45cb488
    public class CPulseCell_IsRequirementValid
    {
        // Fields (8):
        public readonly float m_flFireTime = 0x4;
        public readonly int m_targetType = 0x8;
        public readonly IntPtr m_pTarget = 0x10;
        public readonly IntPtr m_pTargetInput = 0x18;
        public readonly CHandle m_hActivator = 0x20;
        public readonly CHandle m_hCaller = 0x24;
        public readonly CHandle m_hEntTarget = 0x28;
        public readonly int m_variantValue = 0x30;
    }

    // Address: 0x45cb388
    internal class CPulseCell_IsRequirementValid::Criteria_t
    {
        // Fields (3):
        public readonly int m_iszPrivateVScripts = 0x8;
        public readonly IntPtr m_pEntity = 0x10;
        public readonly int m_CScriptComponent = 0x28;
    }

    // Address: 0x4538c68
    internal class CPulseCell_LerpCameraSettings::CursorState_t
    {
        // Fields (8):
        public readonly IntPtr m_pOutputOnEntitiesSpawned = 0x780;
        public readonly int m_worldName = 0x798;
        public readonly int m_layerName = 0x7a0;
        public readonly bool m_bWorldLayerVisible = 0x7a8;
        public readonly bool m_bEntitiesSpawned = 0x7a9;
        public readonly bool m_bCreateAsChildSpawnGroup = 0x7aa;
        public readonly CHandle m_hLayerSpawnGroup = 0x7ac;
        public readonly bool m_bWorldLayerActuallyVisible = 0x7b0;
    }

    // Address: 0x45cb0a0
    internal class CPulseCell_PickBestOutflowSelector::ProcessSelector
    {
        // Fields (12):
        public readonly int m_nameStringTableIndex = 0x14;
        public readonly int m_name = 0x18;
        public readonly int m_designerName = 0x20;
        public readonly float m_flags = 0x30;
        public readonly int m_worldGroupId = 0x38;
        public readonly int m_fDataObjectTypes = 0x3c;
        public readonly int m_PathIndex = 0x40;
        public readonly IntPtr m_pAttributes = 0x48;
        public readonly IntPtr m_pPrev = 0x50;
        public readonly IntPtr m_pNext = 0x58;
        public readonly IntPtr m_pPrevByClass = 0x60;
        public readonly IntPtr m_pNextByClass = 0x68;
    }

    // Address: 0x45c91a8
    public class CPulseCell_Step_DebugLog
    {
        // Fields (2):
        public readonly int m_nCheckType = 0x48;
        public readonly int m_OutflowList = 0x50;
    }

    // Address: 0x45c9140
    internal class CPulseCell_Step_DebugLog::Run
    {
        // Fields (2):
        public readonly int m_Completed = 0xd8;
        public readonly int m_OnInterval = 0x120;
    }

    // Address: 0x45c9c08
    public class CPulseCell_Step_PublicOutput
    {
        // Fields (3):
        public readonly int m_TimelineEvents = 0xd8;
        public readonly bool m_bWaitForChildOutflows = 0xf0;
        public readonly int m_OnFinished = 0xf8;
    }

    // Address: 0x45c8f08
    public class CPulseCell_Unknown
    {
        // Fields (5):
        public readonly int m_StartTime = 0x0;
        public readonly int m_EndTime = 0x4;
        public readonly float m_flWaitInterval = 0x8;
        public readonly float m_flWaitIntervalHigh = 0xc;
        public readonly bool m_bCompleteOnNextWake = 0x10;
    }

    // Address: 0x45cace8
    public class CPulseCell_Value_Gradient
    {
        // Fields (4):
        public readonly float m_flags = 0x8;
        public readonly IntPtr m_pInfo = 0x10;
        public readonly int m_nPriority = 0x18;
        public readonly IntPtr m_pNext = 0x20;
    }

    // Address: 0x45c9340
    internal class CPulseCell_Value_RandomInt::Eval
    {
        // Fields (4):
        public readonly int m_nFlowNodeID = 0x48;
        public readonly bool m_bAnd = 0x4c;
        public readonly int m_PassOutflow = 0x50;
        public readonly int m_FailOutflow = 0x68;
    }

    // Address: 0x45cbec0
    internal class CPulseCell_WaitForObservable::Start
    {
        // Fields (17):
        public readonly bool m_bDontRemove = 0x0;
        public readonly IntPtr m_pNext = 0x10;
        public readonly IntPtr m_pPrev = 0x18;
        public readonly IntPtr m_pParticles = 0x20;
        public readonly IntPtr m_pDebugName = 0x28;
        public readonly int m_vSortOrigin = 0x40;
        public readonly float m_flScale = 0x4c;
        public readonly CHandle m_hOwner = 0x50;
        public readonly IntPtr m_pOwningParticleProperty = 0x58;
        public readonly float m_flFreezeTransitionStart = 0x70;
        public readonly float m_flFreezeTransitionDuration = 0x74;
        public readonly float m_flFreezeTransitionOverride = 0x78;
        public readonly int m_LastMin = 0x7c;
        public readonly int m_LastMax = 0x88;
        public readonly int m_nSplitScreenUser = 0x94;
        public readonly Vector3 m_vecAggregationCenter = 0x98;
        public readonly int m_RefCount = 0xd0;
    }

    // Address: 0x45c5d68
    public class CPulseEnumlib
    {
        // Fields (4):
        public readonly int m_SourceOutflowName = 0x0;
        public readonly int m_nDestChunk = 0x10;
        public readonly int m_nInstruction = 0x14;
        public readonly int m_OutflowRegisterMap = 0x18;
    }

    // Address: 0x45c7648
    public class CPulseMathlib
    {
        // Fields (2):
        public readonly int m_Shuffle = 0x0;
        public readonly int m_nNextShuffle = 0x20;
    }

    // Address: 0x45c6000
    internal class CPulseMathlib::Cos
    {
        // Fields (3):
        public readonly int m_Inparams = 0x0;
        public readonly int m_InparamsWhichCanBeMoved = 0x10;
        public readonly int m_Outparams = 0x20;
    }

    // Address: 0x45c7090
    internal class CPulseMathlib::MakeTransform
    {
        // Fields (5):
        public readonly int m_MethodName = 0xd8;
        public readonly int m_nBlackboardIndex = 0xe8;
        public readonly int m_ExpectedArgs = 0xf0;
        public readonly int m_nAsyncCallMode = 0x100;
        public readonly int m_OnFinished = 0x108;
    }

    // Address: 0x45c5de0
    internal class CPulseStringlib::StringsAreEqualCaseSensitive
    {
        // Fields (12):
        public readonly int m_nCode = 0x0;
        public readonly int m_nVar = 0x4;
        public readonly int m_nReg0 = 0x8;
        public readonly int m_nReg1 = 0xa;
        public readonly int m_nReg2 = 0xc;
        public readonly int m_nInvokeBindingIndex = 0x10;
        public readonly int m_nChunk = 0x14;
        public readonly int m_nDestInstruction = 0x18;
        public readonly int m_nCallInfoIndex = 0x1c;
        public readonly int m_nConstIdx = 0x20;
        public readonly int m_nDomainValueIdx = 0x22;
        public readonly int m_nBlackboardReferenceIdx = 0x24;
    }

    // Address: 0x453fc48
    public class CRagdollManager
    {
        // Fields (13):
        public readonly int m_nModelID = 0x8;
        public readonly CHandle m_hMaterialBase = 0x10;
        public readonly CHandle m_hMaterialDamageOverlay = 0x18;
        public readonly string m_solid = 0x20;
        public readonly Vector3 m_vecPanelSize = 0x24;
        public readonly Vector3 m_vecStressPositionA = 0x2c;
        public readonly Vector3 m_vecStressPositionB = 0x34;
        public readonly Vector3 m_vecPanelVertices = 0x40;
        public readonly int m_vInitialPanelVertices = 0x58;
        public readonly float m_flGlassHalfThickness = 0x70;
        public readonly bool m_bHasParent = 0x74;
        public readonly bool m_bParentFrozen = 0x75;
        public readonly int m_SurfacePropStringToken = 0x78;
    }

    // Address: 0x45cd8c8
    public class CRangeInt
    {
        // Fields (4):
        public readonly int m_TargetKVs = 0x8;
        public readonly int m_PreGenerationKVs = 0x18;
        public readonly int m_FinalKVs = 0x58;
        public readonly Vector3 m_vecGeneratedTextures = 0x80;
    }

    // Address: 0x4548108
    public class CRemapFloat
    {
        // Fields (14):
        public readonly bool m_bFadeOut = 0x1108;
        public readonly bool m_bImportant = 0x1109;
        public readonly float m_flEffectTime = 0x110c;
        public readonly int m_gibDespawnTime = 0x1110;
        public readonly int m_iCurrentFriction = 0x1114;
        public readonly int m_iMinFriction = 0x1118;
        public readonly int m_iMaxFriction = 0x111c;
        public readonly int m_iFrictionAnimState = 0x1120;
        public readonly bool m_bReleaseRagdoll = 0x1124;
        public readonly int m_iEyeAttachment = 0x1125;
        public readonly bool m_bFadingOut = 0x1126;
        public readonly float m_flScaleEnd = 0x1128;
        public readonly float m_flScaleTimeStart = 0x1150;
        public readonly float m_flScaleTimeEnd = 0x1178;
    }

    // Address: 0x4566688
    public class CResponseCriteriaSet
    {
        // Fields (4):
        public readonly int m_LoopState = 0x0;
        public readonly float m_flRealTime = 0x28;
        public readonly float m_flTickInterval = 0x2c;
        public readonly float m_flTickStartTime = 0x30;
    }

    // Address: 0x45473a0
    public class CS2CharacterDecalRendererManifest
    {
        // Fields (23):
        public readonly IntPtr m_pos = 0x1108;
        public readonly int m_vel = 0x1114;
        public readonly QAngle m_angles = 0x1120;
        public readonly int m_localLifeState = 0x112c;
        public readonly int m_deathDepth = 0x1130;
        public readonly int m_deathAngle = 0x1134;
        public readonly bool m_buoyancy = 0x1138;
        public readonly int m_wiggleTimer = 0x1140;
        public readonly int m_wigglePhase = 0x1158;
        public readonly int m_wiggleRate = 0x115c;
        public readonly int m_actualPos = 0x1160;
        public readonly int m_actualAngles = 0x116c;
        public readonly IntPtr m_poolOrigin = 0x1178;
        public readonly int m_waterLevel = 0x1184;
        public readonly int m_gotUpdate = 0x1188;
        public readonly int m_x = 0x118c;
        public readonly int m_y = 0x1190;
        public readonly int m_z = 0x1194;
        public readonly QAngle m_angle = 0x1198;
        public readonly int m_errorHistory = 0x119c;
        public readonly int m_errorHistoryIndex = 0x11ec;
        public readonly int m_errorHistoryCount = 0x11f0;
        public readonly int m_averageError = 0x11f4;
    }

    // Address: 0x456f848
    public class CSPerRoundStats_t
    {
        // Fields (3):
        public readonly int m_nDecoyShotTick = 0x11e4;
        public readonly int m_nClientLastKnownDecoyShotTick = 0x11e8;
        public readonly float m_flTimeParticleEffectSpawn = 0x1210;
    }

    // Address: 0x456fe48
    public class CSPlayerBlockingUseAction_t
    {
        // Fields (7):
        public readonly int m_vInitialPosition = 0x1150;
        public readonly int m_vInitialVelocity = 0x115c;
        public readonly int m_nBounces = 0x1168;
        public readonly int m_nExplodeEffectIndex = 0x1170;
        public readonly int m_nExplodeEffectTickBegin = 0x1178;
        public readonly Vector3 m_vecExplodeEffectOrigin = 0x117c;
        public readonly float m_flSpawnTime = 0x1188;
    }

    // Address: 0x456e5c8
    public class CSWeaponCategory
    {
        // Fields (2):
        public readonly int m_BuoyancyHelper = 0x1020;
        public readonly float m_flFluidDensity = 0x1138;
    }

    // Address: 0x45475a8
    public class CScriptUniformRandomStream
    {
        // Fields (13):
        public readonly float m_flStartTime = 0xf40;
        public readonly float m_flFadeInStart = 0xf44;
        public readonly float m_flFadeInLength = 0xf48;
        public readonly float m_flFadeOutModelStart = 0xf4c;
        public readonly float m_flFadeOutModelLength = 0xf50;
        public readonly float m_flFadeOutStart = 0xf54;
        public readonly float m_flFadeOutLength = 0xf58;
        public readonly float m_flNextSparkTime = 0xf5c;
        public readonly int m_nDissolveType = 0xf60;
        public readonly int m_vDissolverOrigin = 0xf64;
        public readonly int m_nMagnitude = 0xf70;
        public readonly bool m_bCoreExplode = 0xf74;
        public readonly bool m_bLinkedToServerEnt = 0xf75;
    }

    // Address: 0x4544fc8
    public class CSimTimer
    {
        // Fields (27):
        public readonly string m_sDecalGroup = 0x0;
        public readonly CHandle m_hMaterial = 0x8;
        public readonly string m_sSequenceName = 0x10;
        public readonly CHandle m_hEntity = 0x14;
        public readonly int m_nBoneIndex = 0x18;
        public readonly int m_nTriangleIndex = 0x1c;
        public readonly int m_vPositionLS = 0x20;
        public readonly int m_vPositionOS = 0x2c;
        public readonly int m_vNormalLS = 0x38;
        public readonly int m_vNormalOS = 0x44;
        public readonly int m_vSAxisLS = 0x50;
        public readonly int m_nFlags = 0x5c;
        public readonly Color m_Color = 0x60;
        public readonly float m_flWidth = 0x64;
        public readonly float m_flHeight = 0x68;
        public readonly float m_flDepth = 0x6c;
        public readonly int m_transform = 0x70;
        public readonly float m_flAnimationScale = 0x90;
        public readonly float m_flAnimationStartTime = 0x94;
        public readonly float m_flPlaceTime = 0x98;
        public readonly float m_flFadeStartTime = 0x9c;
        public readonly float m_flFadeDuration = 0xa0;
        public readonly float m_flLightingOriginOffset = 0xa4;
        public readonly float m_flBoundingRadiusSqr = 0xb0;
        public readonly int m_nSequenceIndex = 0xb4;
        public readonly bool m_bIsAdjacent = 0xb6;
        public readonly bool m_bDoDecalLightmapping = 0xb7;
    }

    // Address: 0x45481c8
    public class CSkillDamage
    {
        // Fields (10):
        public readonly IntPtr m_pWeaponServices = 0x1190;
        public readonly IntPtr m_pItemServices = 0x1198;
        public readonly IntPtr m_pAutoaimServices = 0x11a0;
        public readonly IntPtr m_pObserverServices = 0x11a8;
        public readonly IntPtr m_pWaterServices = 0x11b0;
        public readonly IntPtr m_pUseServices = 0x11b8;
        public readonly IntPtr m_pFlashlightServices = 0x11c0;
        public readonly IntPtr m_pCameraServices = 0x11c8;
        public readonly IntPtr m_pMovementServices = 0x11d0;
        public readonly int m_ServerViewAngleChanges = 0x11e0;
    }

    // Address: 0x45482c8
    public class CSkillInt
    {
        // Fields (16):
        public readonly int m_iHideHUD = 0x1260;
        public readonly string m_skybox3d = 0x1268;
        public readonly float m_flDeathTime = 0x12f8;
        public readonly Vector3 m_vecPredictionError = 0x12fc;
        public readonly float m_flPredictionErrorTime = 0x1308;
        public readonly Vector3 m_vecLastCameraSetupLocalOrigin = 0x1328;
        public readonly float m_flLastCameraSetupTime = 0x1334;
        public readonly float m_flFOVSensitivityAdjust = 0x1338;
        public readonly float m_flMouseSensitivity = 0x133c;
        public readonly int m_vOldOrigin = 0x1340;
        public readonly float m_flOldSimulationTime = 0x134c;
        public readonly int m_nLastExecutedCommandNumber = 0x1350;
        public readonly int m_nLastExecutedCommandTick = 0x1354;
        public readonly CHandle m_hController = 0x1358;
        public readonly CHandle m_hDefaultController = 0x135c;
        public readonly bool m_bIsSwappingToPredictableController = 0x1360;
    }

    // Address: 0x45437e8
    public class CTakeDamageInfo
    {
        // Fields (5):
        public readonly int m_think = 0x0;
        public readonly CHandle m_hFn = 0x10;
        public readonly int m_nContext = 0x18;
        public readonly int m_nNextThinkTick = 0x1c;
        public readonly int m_nLastThinkTick = 0x20;
    }

    // Address: 0x4543568
    public class CTakeDamageResult
    {
        // Fields (5):
        public readonly int m_vForce = 0x0;
        public readonly int m_nForceBone = 0xc;
        public readonly bool m_bForceCurrentWorldTransform = 0x10;
        public readonly bool m_bUseLRURetirement = 0x11;
        public readonly int m_nHealthToGrant = 0x14;
    }

    // Address: 0x4547a30
    public class CTransform
    {
        // Fields (18):
        public readonly Vector3 m_vecOrigin = 0x77c;
        public readonly int m_MinFalloff = 0x788;
        public readonly int m_MaxFalloff = 0x78c;
        public readonly float m_flFadeInDuration = 0x790;
        public readonly float m_flFadeOutDuration = 0x794;
        public readonly float m_flMaxWeight = 0x798;
        public readonly float m_flCurWeight = 0x79c;
        public readonly int m_netlookupFilename = 0x7a0;
        public readonly bool m_bEnabled = 0x9a0;
        public readonly bool m_bMaster = 0x9a1;
        public readonly bool m_bClientSide = 0x9a2;
        public readonly bool m_bExclusive = 0x9a3;
        public readonly bool m_bEnabledOnClient = 0x9a4;
        public readonly float m_flCurWeightOnClient = 0x9a8;
        public readonly bool m_bFadingIn = 0x9ac;
        public readonly float m_flFadeStartWeight = 0x9b0;
        public readonly float m_flFadeStartTime = 0x9b4;
        public readonly float m_flFadeDuration = 0x9b8;
    }

    // Address: 0x453d570
    public class CTriggerFan
    {
        // Fields (2):
        public readonly int m_vMin = 0x79c;
        public readonly int m_vMax = 0x7a8;
    }

    // Address: 0x45663e0
    public class CUtlStringMap
    {
        // Fields (10):
        public readonly int m_Type = 0x0;
        public readonly string m_szResponseName = 0x1;
        public readonly string m_szMatchingRule = 0xc1;
        public readonly int m_Params = 0x160;
        public readonly int m_fMatchScore = 0x17c;
        public readonly bool m_bAnyMatchingRulesInCooldown = 0x180;
        public readonly string m_szSpeakerContext = 0x188;
        public readonly string m_szWorldContext = 0x190;
        public readonly int m_Followup = 0x198;
        public readonly int m_recipientFilter = 0x1ca;
    }

    // Address: 0x4547880
    public class CVariant
    {
        // Fields (8):
        public readonly float m_flDensity = 0x1020;
        public readonly float m_flParticleInnerDist = 0x1030;
        public readonly IntPtr m_pParticleDef = 0x1038;
        public readonly int m_tParticlePrecipTraceTimer = 0x104c;
        public readonly bool m_bActiveParticlePrecipEmitter = 0x1054;
        public readonly bool m_bParticlePrecipInitialized = 0x1055;
        public readonly bool m_bHasSimulatedSinceLastSceneObjectUpdate = 0x1056;
        public readonly int m_nAvailableSheetSequencesMaxIndex = 0x1058;
    }

    // Address: 0x45544c8
    public class CVectorMovingAverage
    {
        // Fields (5):
        public readonly int m_PathToEntityTransform = 0x10;
        public readonly Vector3 m_vecPathSamplePositions = 0x30;
        public readonly Vector3 m_vecPathSampleParameters = 0x48;
        public readonly Vector3 m_vecPathSampleDistances = 0x60;
        public readonly bool m_bIsClosedLoop = 0x78;
    }

    // Address: 0x45926f0
    internal class CViewRender::Render
    {
        // Fields (102):
        public readonly IntPtr m_pBulletServices = 0x1418;
        public readonly IntPtr m_pHostageServices = 0x1420;
        public readonly IntPtr m_pBuyServices = 0x1428;
        public readonly IntPtr m_pGlowServices = 0x1430;
        public readonly IntPtr m_pActionTrackingServices = 0x1438;
        public readonly IntPtr m_pAimPunchServices = 0x1440;
        public readonly IntPtr m_pDamageReactServices = 0x1448;
        public readonly float m_flHealthShotBoostExpirationTime = 0x1450;
        public readonly float m_flLastFiredWeaponTime = 0x1454;
        public readonly bool m_bHasFemaleVoice = 0x1458;
        public readonly float m_flLandingTimeSeconds = 0x145c;
        public readonly float m_flOldFallVelocity = 0x1460;
        public readonly string m_szLastPlaceName = 0x1464;
        public readonly bool m_bPrevDefuser = 0x1476;
        public readonly bool m_bPrevHelmet = 0x1477;
        public readonly int m_nPrevArmorVal = 0x1478;
        public readonly int m_nPrevGrenadeAmmoCount = 0x147c;
        public readonly uint m_unPreviousWeaponHash = 0x1480;
        public readonly uint m_unWeaponHash = 0x1484;
        public readonly bool m_bInBuyZone = 0x1488;
        public readonly bool m_bPreviouslyInBuyZone = 0x1489;
        public readonly bool m_bInLanding = 0x148a;
        public readonly float m_flLandingStartTime = 0x148c;
        public readonly bool m_bInHostageRescueZone = 0x1490;
        public readonly bool m_bInBombZone = 0x1491;
        public readonly bool m_bIsBuyMenuOpen = 0x1492;
        public readonly float m_flTimeOfLastInjury = 0x1494;
        public readonly float m_flNextSprayDecalTime = 0x1498;
        public readonly int m_iRetakesOffering = 0x1600;
        public readonly int m_iRetakesOfferingCard = 0x1604;
        public readonly bool m_bRetakesHasDefuseKit = 0x1608;
        public readonly bool m_bRetakesMVPLastRound = 0x1609;
        public readonly int m_iRetakesMVPBoostItem = 0x160c;
        public readonly int m_RetakesMVPBoostExtraUtility = 0x1610;
        public readonly bool m_bNeedToReApplyGloves = 0x1615;
        public readonly int m_EconGloves = 0x1618;
        public readonly int m_nEconGlovesChanged = 0x2990;
        public readonly bool m_bMustSyncRagdollState = 0x2991;
        public readonly int m_nRagdollDamageBone = 0x2994;
        public readonly int m_vRagdollDamageForce = 0x2998;
        public readonly string m_szRagdollDamageWeaponName = 0x29a4;
        public readonly bool m_bRagdollDamageHeadshot = 0x29e4;
        public readonly int m_vRagdollServerOrigin = 0x29e8;
        public readonly int m_lastLandTime = 0x29f4;
        public readonly bool m_bOnGroundLastTick = 0x29f8;
        public readonly CHandle m_hHudModelArms = 0x2a14;
        public readonly QAngle m_qDeathEyeAngles = 0x2a18;
        public readonly bool m_bLeftHanded = 0x2a24;
        public readonly int m_fSwitchedHandednessTime = 0x2a28;
        public readonly float m_flViewmodelOffsetX = 0x2a2c;
        public readonly float m_flViewmodelOffsetY = 0x2a30;
        public readonly float m_flViewmodelOffsetZ = 0x2a34;
        public readonly float m_flViewmodelFOV = 0x2a38;
        public readonly Vector3 m_vecPlayerPatchEconIndices = 0x2a3c;
        public readonly int m_GunGameImmunityColor = 0x2a80;
        public readonly Vector3 m_vecBulletHitModels = 0x2ad0;
        public readonly bool m_bIsWalking = 0x2ae8;
        public readonly int m_entitySpottedState = 0x2af0;
        public readonly bool m_bIsScoped = 0x2b08;
        public readonly bool m_bResumeZoom = 0x2b09;
        public readonly bool m_bIsDefusing = 0x2b0a;
        public readonly bool m_bIsGrabbingHostage = 0x2b0b;
        public readonly int m_iBlockingUseActionInProgress = 0x2b0c;
        public readonly float m_flEmitSoundTime = 0x2b10;
        public readonly bool m_bInNoDefuseArea = 0x2b14;
        public readonly int m_nWhichBombZone = 0x2b18;
        public readonly int m_iShotsFired = 0x2b1c;
        public readonly float m_flFlinchStack = 0x2b20;
        public readonly float m_flVelocityModifier = 0x2b24;
        public readonly bool m_bWaitForNoAttack = 0x2b28;
        public readonly int m_ignoreLadderJumpTime = 0x2b2c;
        public readonly bool m_bKilledByHeadshot = 0x2b31;
        public readonly int m_ArmorValue = 0x2b34;
        public readonly uint m_unCurrentEquipmentValue = 0x2b38;
        public readonly uint m_unRoundStartEquipmentValue = 0x2b3a;
        public readonly uint m_unFreezetimeEndEquipmentValue = 0x2b3c;
        public readonly int m_nLastKillerIndex = 0x2b40;
        public readonly bool m_bOldIsScoped = 0x2b44;
        public readonly bool m_bHasDeathInfo = 0x2b45;
        public readonly float m_flDeathInfoTime = 0x2b48;
        public readonly Vector3 m_vecDeathInfoOrigin = 0x2b4c;
        public readonly int m_grenadeParameterStashTime = 0x2b88;
        public readonly bool m_bGrenadeParametersStashed = 0x2b8c;
        public readonly QAngle m_angStashedShootAngles = 0x2b90;
        public readonly Vector3 m_vecStashedGrenadeThrowPosition = 0x2b9c;
        public readonly Vector3 m_vecStashedGrenadeThrowPawnCenter = 0x2ba8;
        public readonly Vector3 m_vecStashedVelocity = 0x2bb4;
        public readonly bool m_bShouldAutobuyDMWeapons = 0x40f0;
        public readonly int m_fImmuneToGunGameDamageTime = 0x40f4;
        public readonly bool m_bGunGameImmunity = 0x40f8;
        public readonly int m_fImmuneToGunGameDamageTimeLast = 0x40fc;
        public readonly int m_fMolotovDamageTime = 0x4100;
        public readonly int m_nPlayerInfernoBodyFx = 0x416c;
        public readonly QAngle m_angEyeAngles = 0x41e0;
        public readonly int m_arrOldEyeAnglesTimes = 0x4278;
        public readonly int m_arrOldEyeAngles = 0x4288;
        public readonly QAngle m_angEyeAnglesVelocity = 0x42b8;
        public readonly int m_iIDEntIndex = 0x42c4;
        public readonly int m_delayTargetIDTimer = 0x42c8;
        public readonly int m_iTargetItemEntIdx = 0x42e0;
        public readonly int m_iOldIDEntIndex = 0x42e4;
        public readonly CHandle m_holdTargetIDTimer = 0x42e8;
    }

    // Address: 0x4527930
    public class C_BaseClientUIEntity
    {
        // Fields (2):
        public readonly CHandle m_hActivator = 0xf68;
        public readonly bool m_bStartEnabled = 0xf6c;
    }

    // Address: 0x454b308
    internal class C_BaseCombatCharacter::WaterWakeMode_t
    {
        // Fields (2):
        public readonly int m_controllers = 0x0;
        public readonly bool m_bGraphBindingsCreated = 0x90;
    }

    // Address: 0x454b068
    public class C_BaseDoor
    {
        // Fields (32):
        public readonly int m_nAnimationAlgorithm = 0x18;
        public readonly int m_nNextExternalGraphHandle = 0x1c;
        public readonly Vector3 m_vecSecondarySkeletonSlotIDs = 0x20;
        public readonly Vector3 m_vecSecondarySkeletons = 0x38;
        public readonly int m_nSecondarySkeletonMasterCount = 0x50;
        public readonly float m_flSoundSyncTime = 0x58;
        public readonly int m_nActiveIKChainMask = 0x5c;
        public readonly CHandle m_hSequence = 0xc0;
        public readonly float m_flSeqStartTime = 0xc4;
        public readonly float m_flSeqFixedCycle = 0xc8;
        public readonly int m_nAnimLoopMode = 0xcc;
        public readonly float m_flPlaybackRate = 0xd0;
        public readonly int m_nNotifyState = 0xdc;
        public readonly bool m_bNetworkedAnimationInputsChanged = 0xdd;
        public readonly bool m_bNetworkedSequenceChanged = 0xde;
        public readonly bool m_bLastUpdateSkipped = 0xdf;
        public readonly bool m_bSequenceFinished = 0xe0;
        public readonly int m_nPrevAnimUpdateTick = 0xe4;
        public readonly CHandle m_hGraphDefinitionAG2 = 0x380;
        public readonly int m_SerializePoseRecipeAG2Slots = 0x388;
        public readonly int m_SerializePoseRecipeAG2Dynamic = 0x3f0;
        public readonly int m_nSerializePoseRecipeAG2ActiveSlot = 0x408;
        public readonly int m_nSerializePoseRecipeVersionAG2 = 0x40c;
        public readonly int m_nServerGraphInstanceIteration = 0x410;
        public readonly int m_nServerSerializationContextIteration = 0x414;
        public readonly IntPtr m_primaryGraphId = 0x418;
        public readonly Vector3 m_vecExternalGraphIds = 0x420;
        public readonly Vector3 m_vecExternalClipIds = 0x438;
        public readonly string m_sAnimGraph2Identifier = 0x450;
        public readonly IntPtr m_pGraphInstanceAG2 = 0x458;
        public readonly Vector3 m_vecExternalGraphs = 0x678;
        public readonly int m_nPrevAnimationAlgorithm = 0x6a9;
    }

    // Address: 0x454bb48
    public class C_BaseModelEntity
    {
        // Fields (24):
        public readonly bool m_bUseHitboxesForRenderBox = 0x1278;
        public readonly bool m_bUseAnimGraph = 0x1279;
        public readonly IntPtr m_pOutputAnimBegun = 0x1280;
        public readonly IntPtr m_pOutputAnimOver = 0x1298;
        public readonly IntPtr m_pOutputAnimLoopCycleOver = 0x12b0;
        public readonly int m_OnAnimReachedStart = 0x12c8;
        public readonly int m_OnAnimReachedEnd = 0x12e0;
        public readonly int m_iszIdleAnim = 0x12f8;
        public readonly int m_nIdleAnimLoopMode = 0x1300;
        public readonly bool m_bRandomizeCycle = 0x1304;
        public readonly bool m_bStartDisabled = 0x1305;
        public readonly bool m_bFiredStartEndOutput = 0x1306;
        public readonly bool m_bForceNpcExclude = 0x1307;
        public readonly bool m_bCreateMovableSurfaceGraph = 0x1308;
        public readonly bool m_bCreateNonSolid = 0x1309;
        public readonly bool m_bIsOverrideProp = 0x130a;
        public readonly int m_iInitialGlowState = 0x130c;
        public readonly int m_nGlowRange = 0x1310;
        public readonly int m_nGlowRangeMin = 0x1314;
        public readonly int m_glowColor = 0x1318;
        public readonly int m_nGlowTeam = 0x131c;
        public readonly int m_iCachedFrameCount = 0x1320;
        public readonly Vector3 m_vecCachedRenderMins = 0x1324;
        public readonly Vector3 m_vecCachedRenderMaxs = 0x1330;
    }

    // Address: 0x45513e8
    public class C_BasePropDoor
    {
        // Fields (3):
        public readonly Vector3 m_vecX = 0x10;
        public readonly Vector3 m_vecY = 0x18;
        public readonly Vector3 m_vecZ = 0x20;
    }

    // Address: 0x4531230
    public class C_BaseTrigger
    {
        // Fields (36):
        public readonly float m_flScattering = 0x77c;
        public readonly int m_TintColor = 0x780;
        public readonly float m_flAnisotropy = 0x784;
        public readonly float m_flFadeSpeed = 0x788;
        public readonly float m_flDrawDistance = 0x78c;
        public readonly float m_flFadeInStart = 0x790;
        public readonly float m_flFadeInEnd = 0x794;
        public readonly float m_flIndirectStrength = 0x798;
        public readonly int m_nVolumeDepth = 0x79c;
        public readonly int m_fFirstVolumeSliceThickness = 0x7a0;
        public readonly int m_nIndirectTextureDimX = 0x7a4;
        public readonly int m_nIndirectTextureDimY = 0x7a8;
        public readonly int m_nIndirectTextureDimZ = 0x7ac;
        public readonly int m_vBoxMins = 0x7b0;
        public readonly int m_vBoxMaxs = 0x7bc;
        public readonly bool m_bActive = 0x7c8;
        public readonly float m_flStartAnisoTime = 0x7cc;
        public readonly float m_flStartScatterTime = 0x7d0;
        public readonly float m_flStartDrawDistanceTime = 0x7d4;
        public readonly float m_flStartAnisotropy = 0x7d8;
        public readonly float m_flStartScattering = 0x7dc;
        public readonly float m_flStartDrawDistance = 0x7e0;
        public readonly float m_flDefaultAnisotropy = 0x7e4;
        public readonly float m_flDefaultScattering = 0x7e8;
        public readonly float m_flDefaultDrawDistance = 0x7ec;
        public readonly bool m_bStartDisabled = 0x7f0;
        public readonly bool m_bEnableIndirect = 0x7f1;
        public readonly bool m_bIsMaster = 0x7f2;
        public readonly CHandle m_hFogIndirectTexture = 0x7f8;
        public readonly int m_nForceRefreshCount = 0x800;
        public readonly int m_fNoiseSpeed = 0x804;
        public readonly int m_fNoiseStrength = 0x808;
        public readonly int m_vNoiseScale = 0x80c;
        public readonly int m_fWindSpeed = 0x818;
        public readonly int m_vWindDirection = 0x81c;
        public readonly bool m_bFirstTime = 0x828;
    }

    // Address: 0x4542eb0
    public class C_Beam
    {
        // Fields (2):
        public readonly float m_flMinInterval = 0xc;
        public readonly float m_flMaxInterval = 0x10;
    }

    // Address: 0x45515d0
    public class C_Breakable
    {
        // Fields (3):
        public readonly Vector3 m_vecX = 0x10;
        public readonly Vector3 m_vecY = 0x18;
        public readonly Vector3 m_vecZ = 0x20;
    }

    // Address: 0x4583ff0
    public class C_BreakableProp
    {
        // Fields (26):
        public readonly string m_szSnapshotFileName = 0xf38;
        public readonly bool m_bActive = 0x1138;
        public readonly bool m_bFrozen = 0x1139;
        public readonly float m_flFreezeTransitionDuration = 0x113c;
        public readonly int m_nStopType = 0x1140;
        public readonly bool m_bAnimateDuringGameplayPause = 0x1144;
        public readonly int m_iEffectIndex = 0x1148;
        public readonly float m_flStartTime = 0x1150;
        public readonly float m_flPreSimTime = 0x1154;
        public readonly int m_vServerControlPoints = 0x1158;
        public readonly int m_iServerControlPointAssignments = 0x1188;
        public readonly CHandle m_hControlPointEnts = 0x118c;
        public readonly bool m_bDataStringLocalized = 0x128c;
        public readonly string m_strDataString = 0x1290;
        public readonly bool m_bNoSave = 0x1298;
        public readonly bool m_bNoFreeze = 0x1299;
        public readonly bool m_bNoRamp = 0x129a;
        public readonly bool m_bStartActive = 0x129b;
        public readonly int m_iszEffectName = 0x12a0;
        public readonly int m_iszControlPointNames = 0x12a8;
        public readonly int m_nDataCP = 0x14a8;
        public readonly Vector3 m_vecDataCPValue = 0x14ac;
        public readonly int m_nTintCP = 0x14b8;
        public readonly int m_clrTint = 0x14bc;
        public readonly bool m_bOldActive = 0x14e0;
        public readonly bool m_bOldFrozen = 0x14e1;
    }

    // Address: 0x4597650
    public class C_CSGO_CounterTerroristTeamIntroCamera
    {
        // Fields (17):
        public readonly int m_nDraftType = 0x78c;
        public readonly int m_nTeamWinningCoinToss = 0x790;
        public readonly int m_nTeamWithFirstChoice = 0x794;
        public readonly int m_nVoteMapIdsList = 0x894;
        public readonly int m_nAccountIDs = 0x8b0;
        public readonly int m_nMapId0 = 0x9b0;
        public readonly int m_nMapId1 = 0xab0;
        public readonly int m_nMapId2 = 0xbb0;
        public readonly int m_nMapId3 = 0xcb0;
        public readonly int m_nMapId4 = 0xdb0;
        public readonly int m_nMapId5 = 0xeb0;
        public readonly int m_nStartingSide0 = 0xfb0;
        public readonly int m_nCurrentPhase = 0x10b0;
        public readonly int m_nPhaseStartTick = 0x10b4;
        public readonly int m_nPhaseDurationTicks = 0x10b8;
        public readonly int m_nPostDataUpdateTick = 0x10bc;
        public readonly bool m_bDisabledHud = 0x10c0;
    }

    // Address: 0x4597b88
    public class C_CSGO_EndOfMatchCharacterPosition
    {
        // Fields (16):
        public readonly int m_nUniqueID = 0xf38;
        public readonly uint m_unAccountID = 0xf3c;
        public readonly uint m_unTraceID = 0xf40;
        public readonly int m_rtGcTime = 0xf44;
        public readonly Vector3 m_vecEndPos = 0xf48;
        public readonly Vector3 m_vecStart = 0xf54;
        public readonly Vector3 m_vecLeft = 0xf60;
        public readonly Vector3 m_vecNormal = 0xf6c;
        public readonly int m_nPlayer = 0xf78;
        public readonly int m_nEntity = 0xf7c;
        public readonly int m_nHitbox = 0xf80;
        public readonly float m_flCreationTime = 0xf84;
        public readonly int m_nTintID = 0xf88;
        public readonly int m_nVersion = 0xf8c;
        public readonly uint m_ubSignature = 0xf8d;
        public readonly int m_SprayRenderHelper = 0x1018;
    }

    // Address: 0x4595f30
    public class C_CSGO_MapPreviewCameraPath
    {
        // Fields (10):
        public readonly string m_szTeamMatchStat = 0x835;
        public readonly int m_numMapVictories = 0xa38;
        public readonly bool m_bSurrendered = 0xa3c;
        public readonly string m_scoreFirstHalf = 0xa40;
        public readonly string m_scoreSecondHalf = 0xa44;
        public readonly string m_scoreOvertime = 0xa48;
        public readonly string m_szClanTeamname = 0xa4c;
        public readonly int m_iClanID = 0xad0;
        public readonly string m_szTeamFlagImage = 0xad4;
        public readonly string m_szTeamLogoImage = 0xadc;
    }

    // Address: 0x45963f0
    public class C_CSGO_MapPreviewCameraPathNode
    {
        // Fields (2):
        public readonly int m_animgraphCharacterModeString = 0x4300;
        public readonly float m_flInitialModelScale = 0x4308;
    }

    // Address: 0x4598010
    internal class C_CSGO_PreviewPlayerAlias_csgo_player_previewmodel
    {
        // Fields (29):
        public readonly bool m_bBombTicking = 0x1128;
        public readonly int m_nBombSite = 0x112c;
        public readonly int m_nSourceSoundscapeHash = 0x1130;
        public readonly int m_entitySpottedState = 0x1138;
        public readonly float m_flNextGlow = 0x1150;
        public readonly float m_flNextBeep = 0x1154;
        public readonly float m_flC4Blow = 0x1158;
        public readonly bool m_bCannotBeDefused = 0x115c;
        public readonly bool m_bHasExploded = 0x115d;
        public readonly float m_flTimerLength = 0x1160;
        public readonly bool m_bBeingDefused = 0x1164;
        public readonly bool m_bTriggerWarning = 0x1168;
        public readonly bool m_bExplodeWarning = 0x116c;
        public readonly bool m_bC4Activated = 0x1170;
        public readonly bool m_bTenSecWarning = 0x1171;
        public readonly float m_flDefuseLength = 0x1174;
        public readonly float m_flDefuseCountDown = 0x1178;
        public readonly bool m_bBombDefused = 0x117c;
        public readonly CHandle m_hBombDefuser = 0x1180;
        public readonly int m_AttributeManager = 0x1188;
        public readonly CHandle m_hDefuserMultimeter = 0x2560;
        public readonly float m_flNextRadarFlashTime = 0x2564;
        public readonly bool m_bRadarFlash = 0x2568;
        public readonly IntPtr m_pBombDefuser = 0x256c;
        public readonly int m_fLastDefuseTime = 0x2570;
        public readonly IntPtr m_pPredictionOwner = 0x2578;
        public readonly Vector3 m_vecC4ExplodeSpectatePos = 0x2580;
        public readonly Vector3 m_vecC4ExplodeSpectateAng = 0x258c;
        public readonly float m_flC4ExplodeSpectateDuration = 0x2598;
    }

    // Address: 0x456f5e8
    public class C_CSGO_TeamIntroCharacterPosition
    {
        // Fields (2):
        public readonly int m_OwningPlayer = 0x2680;
        public readonly int m_KillingPlayer = 0x2684;
    }

    // Address: 0x45978c8
    public class C_CSGO_TeamSelectCamera
    {
        // Fields (7):
        public readonly int m_iActiveIssueIndex = 0x78c;
        public readonly int m_iOnlyTeamToVote = 0x790;
        public readonly int m_nVoteOptionCount = 0x794;
        public readonly int m_nPotentialVotes = 0x7a8;
        public readonly bool m_bVotesDirty = 0x7ac;
        public readonly bool m_bTypeDirty = 0x7ad;
        public readonly bool m_bIsYesNoVote = 0x7ae;
    }

    // Address: 0x456ee70
    public class C_CSGO_TeamSelectTerroristPosition
    {
        // Fields (14):
        public readonly bool m_bClientPredictDelete = 0x2b65;
        public readonly bool m_bRedraw = 0x2b66;
        public readonly bool m_bIsHeldByPlayer = 0x2b67;
        public readonly bool m_bPinPulled = 0x2b68;
        public readonly bool m_bJumpThrow = 0x2b69;
        public readonly bool m_bThrowAnimating = 0x2b6a;
        public readonly int m_fThrowTime = 0x2b6c;
        public readonly float m_flThrowStrength = 0x2b70;
        public readonly int m_fDropTime = 0x2bf0;
        public readonly int m_fPinPullTime = 0x2bf4;
        public readonly bool m_bJustPulledPin = 0x2bf8;
        public readonly int m_nNextHoldTick = 0x2bfc;
        public readonly float m_flNextHoldFrac = 0x2c00;
        public readonly CHandle m_hSwitchToWeaponAfterThrow = 0x2c04;
    }

    // Address: 0x456e088
    public class C_CSGameRulesProxy
    {
        // Fields (13):
        public readonly int m_iKills = 0x30;
        public readonly int m_iDeaths = 0x34;
        public readonly int m_iAssists = 0x38;
        public readonly int m_iDamage = 0x3c;
        public readonly int m_iEquipmentValue = 0x40;
        public readonly int m_iMoneySaved = 0x44;
        public readonly int m_iKillReward = 0x48;
        public readonly int m_iLiveTime = 0x4c;
        public readonly int m_iHeadShotKills = 0x50;
        public readonly int m_iObjective = 0x54;
        public readonly int m_iCashEarned = 0x58;
        public readonly int m_iUtilityDamage = 0x5c;
        public readonly int m_iEnemiesFlashed = 0x60;
    }

    // Address: 0x45950a8
    external class C_CSPlayerPawn_API
    {
        // Fields (2):
        public readonly int m_cameraName = 0x780;
        public readonly float m_flCsmFovOverrideValue = 0x788;
    }

    // Address: 0x457a850
    public class C_CSPlayerResource
    {
        // Fields (15):
        public readonly int m_PlayerDamager = 0x30;
        public readonly int m_PlayerRecipient = 0x34;
        public readonly CHandle m_hPlayerControllerDamager = 0x38;
        public readonly CHandle m_hPlayerControllerRecipient = 0x3c;
        public readonly string m_szPlayerDamagerName = 0x40;
        public readonly string m_szPlayerRecipientName = 0x48;
        public readonly int m_DamagerXuid = 0x50;
        public readonly int m_RecipientXuid = 0x58;
        public readonly float m_flBulletsDamage = 0x60;
        public readonly float m_flDamage = 0x64;
        public readonly float m_flActualHealthRemoved = 0x68;
        public readonly int m_iNumHits = 0x6c;
        public readonly int m_iLastBulletUpdate = 0x70;
        public readonly bool m_bIsOtherEnemy = 0x74;
        public readonly int m_killType = 0x75;
    }

    // Address: 0x4574bf0
    public class C_CSWeaponBaseGun
    {
        // Fields (2):
        public readonly bool m_bSequenceInProgress = 0x2b65;
        public readonly bool m_bRedraw = 0x2b66;
    }

    // Address: 0x4549c48
    public class C_ClientRagdoll
    {
        // Fields (44):
        public readonly int m_CRenderComponent = 0xa70;
        public readonly int m_CHitboxComponent = 0xa78;
        public readonly IntPtr m_pChoreoComponent = 0xa90;
        public readonly int m_nDestructiblePartInitialStateDestructed0 = 0xa98;
        public readonly int m_nDestructiblePartInitialStateDestructed1 = 0xa9c;
        public readonly int m_nDestructiblePartInitialStateDestructed2 = 0xaa0;
        public readonly int m_nDestructiblePartInitialStateDestructed3 = 0xaa4;
        public readonly int m_nDestructiblePartInitialStateDestructed4 = 0xaa8;
        public readonly int m_nDestructiblePartInitialStateDestructed0_PartIndex = 0xaac;
        public readonly int m_nDestructiblePartInitialStateDestructed1_PartIndex = 0xab0;
        public readonly int m_nDestructiblePartInitialStateDestructed2_PartIndex = 0xab4;
        public readonly int m_nDestructiblePartInitialStateDestructed3_PartIndex = 0xab8;
        public readonly int m_nDestructiblePartInitialStateDestructed4_PartIndex = 0xabc;
        public readonly bool m_bDestructiblePartInitialStateDestructed0_GenerateBreakpieces = 0xac0;
        public readonly bool m_bDestructiblePartInitialStateDestructed1_GenerateBreakpieces = 0xac1;
        public readonly bool m_bDestructiblePartInitialStateDestructed2_GenerateBreakpieces = 0xac2;
        public readonly bool m_bDestructiblePartInitialStateDestructed3_GenerateBreakpieces = 0xac3;
        public readonly bool m_bDestructiblePartInitialStateDestructed4_GenerateBreakpieces = 0xac4;
        public readonly IntPtr m_pDestructiblePartsSystemComponent = 0xac8;
        public readonly bool m_bInitModelEffects = 0xbf0;
        public readonly bool m_bDoingModelEffects = 0xbf1;
        public readonly int m_iOldHealth = 0xbf4;
        public readonly int m_nRenderMode = 0xbf8;
        public readonly int m_nRenderFX = 0xbf9;
        public readonly bool m_bAllowFadeInView = 0xbfa;
        public readonly int m_clrRender = 0xc18;
        public readonly Vector3 m_vecRenderAttributes = 0xc20;
        public readonly bool m_bRenderToCubemaps = 0xca0;
        public readonly bool m_bNoInterpolate = 0xca1;
        public readonly Color m_Collision = 0xca8;
        public readonly int m_Glow = 0xd60;
        public readonly float m_flGlowBackfaceMult = 0xdb8;
        public readonly int m_fadeMinDist = 0xdbc;
        public readonly int m_fadeMaxDist = 0xdc0;
        public readonly float m_flFadeScale = 0xdc4;
        public readonly float m_flShadowStrength = 0xdc8;
        public readonly int m_nObjectCulling = 0xdcc;
        public readonly int m_nRequiredDecalRtEncoding = 0xdcd;
        public readonly bool m_bodyGroupChoices = 0xdd0;
        public readonly Vector3 m_vecViewOffset = 0xdf8;
        public readonly IntPtr m_pClientAlphaProperty = 0xee0;
        public readonly int m_ClientOverrideTint = 0xee8;
        public readonly bool m_bUseClientOverrideTint = 0xeec;
        public readonly bool m_bvDisabledHitGroups = 0xf28;
    }

    // Address: 0x4597308
    public class C_CsmFovOverride
    {
        // Fields (14):
        public readonly int m_nAnimationSeed = 0x88;
        public readonly int m_characterMode = 0xa0;
        public readonly bool m_bCharacterModeReset = 0xb8;
        public readonly int m_nTeamPreviewVariant = 0xd0;
        public readonly int m_nTeamPreviewRandom = 0xe8;
        public readonly int m_nTeamPreviewPosition = 0x100;
        public readonly int m_endOfMatchCelebration = 0x118;
        public readonly int m_action = 0x130;
        public readonly bool m_bannerAnimation = 0x148;
        public readonly int m_weaponCategory = 0x160;
        public readonly int m_weaponType = 0x178;
        public readonly int m_weaponState = 0x190;
        public readonly int m_inspectTurnAngle = 0x1a8;
        public readonly bool m_bCT = 0x1c0;
    }

    // Address: 0x458bbc8
    public class C_DynamicLight
    {
        // Fields (8):
        public readonly int m_targetCamera = 0xf38;
        public readonly int m_nResolutionEnum = 0xf40;
        public readonly bool m_bRenderShadows = 0xf44;
        public readonly bool m_bUseUniqueColorTarget = 0xf45;
        public readonly bool m_brushModelName = 0xf48;
        public readonly CHandle m_hTargetCamera = 0xf50;
        public readonly bool m_bEnabled = 0xf54;
        public readonly bool m_bDraw3DSkybox = 0xf55;
    }

    // Address: 0x4583090
    public class C_DynamicProp
    {
        // Fields (5):
        public readonly string m_sGroupName = 0x0;
        public readonly string m_sEntityLumpName = 0x8;
        public readonly Vector3 m_vecWorldOffset = 0x10;
        public readonly bool m_bClientSpawnGroup = 0x40;
        public readonly bool m_bSuppressAllEntities = 0x41;
    }

    // Address: 0x452e310
    public class C_EnvCubemapFog
    {
        // Fields (11):
        public readonly IntPtr m_pController = 0x8;
        public readonly int m_nFluidType = 0x18;
        public readonly float m_flFluidDensity = 0x1c;
        public readonly float m_flNeutrallyBuoyantGravity = 0x20;
        public readonly float m_flNeutrallyBuoyantLinearDamping = 0x24;
        public readonly float m_flNeutrallyBuoyantAngularDamping = 0x28;
        public readonly bool m_bNeutrallyBuoyant = 0x2c;
        public readonly Vector3 m_vecFractionOfWheelSubmergedForWheelFriction = 0x30;
        public readonly Vector3 m_vecWheelFrictionScales = 0x48;
        public readonly Vector3 m_vecFractionOfWheelSubmergedForWheelDrag = 0x60;
        public readonly Vector3 m_vecWheelDrag = 0x78;
    }

    // Address: 0x4553d48
    public class C_EnvDecal
    {
        // Fields (5):
        public readonly float m_flTouchDelta = 0x1278;
        public readonly int m_fDeathTime = 0x127c;
        public readonly Vector3 m_vecDamagePosition = 0x1280;
        public readonly Vector3 m_vecDamageDirection = 0x128c;
        public readonly int m_nDamageType = 0x1298;
    }

    // Address: 0x4542548
    public class C_EnvDetailController
    {
        // Fields (4):
        public readonly int m_current = 0x0;
        public readonly int m_target = 0x4;
        public readonly int m_rate = 0x8;
        public readonly int m_forceupdate = 0xc;
    }

    // Address: 0x45864f0
    public class C_EnvParticleGlow
    {
        // Fields (20):
        public readonly Vector3 m_vecCsViewPunchAngle = 0x48;
        public readonly int m_nCsViewPunchAngleTick = 0x54;
        public readonly float m_flCsViewPunchAngleTickRatio = 0x58;
        public readonly int m_PlayerFog = 0x60;
        public readonly CHandle m_hColorCorrectionCtrl = 0xa0;
        public readonly CHandle m_hViewEntity = 0xa4;
        public readonly CHandle m_hTonemapController = 0xa8;
        public readonly int m_audio = 0xb0;
        public readonly int m_PostProcessingVolumes = 0x128;
        public readonly float m_flOldPlayerZ = 0x140;
        public readonly float m_flOldPlayerViewOffsetZ = 0x144;
        public readonly int m_CurrentFog = 0x148;
        public readonly CHandle m_hOldFogController = 0x1b0;
        public readonly bool m_bOverrideFogColor = 0x1b4;
        public readonly int m_OverrideFogColor = 0x1b9;
        public readonly bool m_bOverrideFogStartEnd = 0x1cd;
        public readonly int m_fOverrideFogStart = 0x1d4;
        public readonly int m_fOverrideFogEnd = 0x1e8;
        public readonly CHandle m_hActivePostProcessingVolume = 0x1fc;
        public readonly QAngle m_angDemoViewAngles = 0x200;
    }

    // Address: 0x4534050
    public class C_EnvVolumetricFogController
    {
        // Fields (22):
        public readonly int m_Entity_hLightProbeTexture_AmbientCube = 0x1778;
        public readonly int m_Entity_hLightProbeTexture_SDF = 0x1780;
        public readonly int m_Entity_hLightProbeTexture_SH2_DC = 0x1788;
        public readonly int m_Entity_hLightProbeTexture_SH2_R = 0x1790;
        public readonly int m_Entity_hLightProbeTexture_SH2_G = 0x1798;
        public readonly int m_Entity_hLightProbeTexture_SH2_B = 0x17a0;
        public readonly int m_Entity_hLightProbeDirectLightIndicesTexture = 0x17a8;
        public readonly int m_Entity_hLightProbeDirectLightScalarsTexture = 0x17b0;
        public readonly int m_Entity_hLightProbeDirectLightShadowsTexture = 0x17b8;
        public readonly int m_Entity_vBoxMins = 0x17c0;
        public readonly int m_Entity_vBoxMaxs = 0x17cc;
        public readonly int m_Entity_bMoveable = 0x17d8;
        public readonly int m_Entity_nHandshake = 0x17dc;
        public readonly int m_Entity_nPriority = 0x17e0;
        public readonly int m_Entity_bStartDisabled = 0x17e4;
        public readonly int m_Entity_nLightProbeSizeX = 0x17e8;
        public readonly int m_Entity_nLightProbeSizeY = 0x17ec;
        public readonly int m_Entity_nLightProbeSizeZ = 0x17f0;
        public readonly int m_Entity_nLightProbeAtlasX = 0x17f4;
        public readonly int m_Entity_nLightProbeAtlasY = 0x17f8;
        public readonly int m_Entity_nLightProbeAtlasZ = 0x17fc;
        public readonly int m_Entity_bEnabled = 0x1809;
    }

    // Address: 0x4532bd0
    public class C_EnvVolumetricFogVolume
    {
        // Fields (12):
        public readonly CHandle m_hSkyMaterial = 0xf38;
        public readonly CHandle m_hSkyMaterialLightingOnly = 0xf40;
        public readonly bool m_bStartDisabled = 0xf48;
        public readonly int m_vTintColor = 0xf49;
        public readonly int m_vTintColorLightingOnly = 0xf4d;
        public readonly float m_flBrightnessScale = 0xf54;
        public readonly int m_nFogType = 0xf58;
        public readonly float m_flFogMinStart = 0xf5c;
        public readonly float m_flFogMinEnd = 0xf60;
        public readonly float m_flFogMaxStart = 0xf64;
        public readonly float m_flFogMaxEnd = 0xf68;
        public readonly bool m_bEnabled = 0xf6c;
    }

    // Address: 0x458b8d0
    public class C_EnvWindClientside
    {
        // Fields (3):
        public readonly int m_nLongAxis = 0xf38;
        public readonly float m_flRadius = 0xf3c;
        public readonly float m_flLineLength = 0xf40;
    }

    // Address: 0x458f150
    public class C_EnvWindShared
    {
        // Fields (25):
        public readonly bool m_bDisabled = 0x77c;
        public readonly bool m_bDisabledOld = 0x77d;
        public readonly bool m_bUpdateOnClient = 0x77e;
        public readonly int m_nInputType = 0x780;
        public readonly CHandle m_hRemapLineStart = 0x784;
        public readonly CHandle m_hRemapLineEnd = 0x788;
        public readonly float m_flMaximumChangePerSecond = 0x78c;
        public readonly float m_flDisengageDistance = 0x790;
        public readonly float m_flEngageDistance = 0x794;
        public readonly bool m_bRequiresUseKey = 0x798;
        public readonly int m_nOutputType = 0x79c;
        public readonly CHandle m_hOutputEntities = 0x7a0;
        public readonly int m_nHapticsType = 0x7b8;
        public readonly int m_nMomentumType = 0x7bc;
        public readonly float m_flMomentumModifier = 0x7c0;
        public readonly float m_flSnapValue = 0x7c4;
        public readonly float m_flCurrentMomentum = 0x7c8;
        public readonly int m_nRatchetType = 0x7cc;
        public readonly float m_flRatchetOffset = 0x7d0;
        public readonly float m_flInputOffset = 0x7d4;
        public readonly bool m_bEngaged = 0x7d8;
        public readonly bool m_bFirstUpdate = 0x7d9;
        public readonly float m_flPreviousValue = 0x7dc;
        public readonly float m_flPreviousUpdateTickTime = 0x7e0;
        public readonly Vector3 m_vecPreviousTestPoint = 0x7e4;
    }

    // Address: 0x4549308
    public class C_Fish
    {
        // Fields (6):
        public readonly CHandle m_hMyWearables = 0x1108;
        public readonly int m_leftFootAttachment = 0x1120;
        public readonly int m_rightFootAttachment = 0x1121;
        public readonly int m_nWaterWakeMode = 0x1124;
        public readonly float m_flWaterWorldZ = 0x1128;
        public readonly float m_flWaterNextTraceTime = 0x112c;
    }

    // Address: 0x4577a70
    public class C_Flashbang
    {
        // Fields (2):
        public readonly float m_flDeathCamTilt = 0x2b0;
        public readonly int m_vClientScopeInaccuracy = 0x2b8;
    }

    // Address: 0x453c0b0
    public class C_FogController
    {
        // Fields (5):
        public readonly float m_flEmitterAngle = 0x838;
        public readonly float m_flSweetSpotAngle = 0x83c;
        public readonly float m_flAttenMin = 0x840;
        public readonly float m_flAttenMax = 0x844;
        public readonly int m_iszParameterName = 0x848;
    }

    // Address: 0x457b810
    public class C_FootstepControl
    {
        // Fields (15):
        public readonly string m_sModelName = 0x28;
        public readonly string m_sModelNameAg2Override = 0x108;
        public readonly float m_flHeadDamageMultiplier = 0x1e8;
        public readonly float m_flChestDamageMultiplier = 0x1f8;
        public readonly float m_flStomachDamageMultiplier = 0x208;
        public readonly float m_flArmDamageMultiplier = 0x218;
        public readonly float m_flLegDamageMultiplier = 0x228;
        public readonly float m_flHoldBreathTime = 0x238;
        public readonly float m_flDrowningDamageInterval = 0x23c;
        public readonly int m_nDrowningDamageInitial = 0x240;
        public readonly int m_nDrowningDamageMax = 0x244;
        public readonly int m_nWaterSpeed = 0x248;
        public readonly float m_flUseRange = 0x24c;
        public readonly float m_flUseAngleTolerance = 0x250;
        public readonly float m_flCrouchTime = 0x254;
    }

    // Address: 0x4551928
    public class C_FuncBrush
    {
        // Fields (5):
        public readonly float m_flStartTime = 0x0;
        public readonly float m_flEndTime = 0x4;
        public readonly float m_flStartValue = 0x8;
        public readonly float m_flEndValue = 0xc;
        public readonly int m_nInterpType = 0x10;
    }

    // Address: 0x458ded0
    public class C_FuncMonitor
    {
        // Fields (7):
        public readonly bool m_boneIndexAttached = 0x1190;
        public readonly int m_ragdollAttachedObjectIndex = 0x1194;
        public readonly int m_attachmentPointBoneSpace = 0x1198;
        public readonly int m_attachmentPointRagdollSpace = 0x11a4;
        public readonly Vector3 m_vecOffset = 0x11b0;
        public readonly IntPtr m_parentTime = 0x11bc;
        public readonly bool m_bHasParent = 0x11c0;
    }

    // Address: 0x45517c8
    public class C_FuncRotating
    {
        // Fields (7):
        public readonly int m_cellX = 0x10;
        public readonly int m_cellY = 0x12;
        public readonly int m_cellZ = 0x14;
        public readonly int m_nOutsideWorld = 0x16;
        public readonly Vector3 m_vecX = 0x18;
        public readonly Vector3 m_vecY = 0x20;
        public readonly Vector3 m_vecZ = 0x28;
    }

    // Address: 0x458b7b0
    public class C_GlobalLight
    {
        // Fields (2):
        public readonly int m_aAttachedObjectsFromServer = 0x1108;
        public readonly int m_aAttachedObjects = 0x1120;
    }

    // Address: 0x4537310
    public class C_GradientFog
    {
        // Fields (26):
        public readonly int m_FOV = 0x77c;
        public readonly int m_Resolution = 0x780;
        public readonly bool m_bFogEnable = 0x784;
        public readonly int m_FogColor = 0x785;
        public readonly float m_flFogStart = 0x78c;
        public readonly float m_flFogEnd = 0x790;
        public readonly float m_flFogMaxDensity = 0x794;
        public readonly bool m_bActive = 0x798;
        public readonly bool m_bUseScreenAspectRatio = 0x799;
        public readonly float m_flAspectRatio = 0x79c;
        public readonly bool m_bNoSky = 0x7a0;
        public readonly int m_fBrightness = 0x7a4;
        public readonly float m_flZFar = 0x7a8;
        public readonly float m_flZNear = 0x7ac;
        public readonly bool m_bCanHLTVUse = 0x7b0;
        public readonly bool m_bAlignWithParent = 0x7b1;
        public readonly bool m_bDofEnabled = 0x7b2;
        public readonly float m_flDofNearBlurry = 0x7b4;
        public readonly float m_flDofNearCrisp = 0x7b8;
        public readonly float m_flDofFarCrisp = 0x7bc;
        public readonly float m_flDofFarBlurry = 0x7c0;
        public readonly float m_flDofTiltToGround = 0x7c4;
        public readonly int m_TargetFOV = 0x7c8;
        public readonly int m_DegreesPerSecond = 0x7cc;
        public readonly bool m_bIsOn = 0x7d0;
        public readonly IntPtr m_pNext = 0x7d8;
    }

    // Address: 0x45a2db0
    public class C_HEGrenadeProjectile
    {
        // Fields (5):
        public readonly int m_iAttributeDefinitionIndex = 0x30;
        public readonly float m_flValue = 0x34;
        public readonly float m_flInitialValue = 0x38;
        public readonly int m_nRefundableCurrency = 0x3c;
        public readonly bool m_bSetBonus = 0x40;
    }

    // Address: 0x4596ad0
    public class C_HostageCarriableProp
    {
        // Fields (26):
        public readonly IntPtr m_pPingServices = 0x1378;
        public readonly IntPtr m_previousPlayerState = 0x1380;
        public readonly int m_iPlayerState = 0x1384;
        public readonly bool m_bHasMovedSinceSpawn = 0x1388;
        public readonly float m_flLastSpawnTimeIndex = 0x138c;
        public readonly int m_iProgressBarDuration = 0x1390;
        public readonly float m_flProgressBarStartTime = 0x1394;
        public readonly float m_flClientDeathTime = 0x1398;
        public readonly float m_flFlashBangTime = 0x139c;
        public readonly float m_flFlashScreenshotAlpha = 0x13a0;
        public readonly float m_flFlashOverlayAlpha = 0x13a4;
        public readonly bool m_bFlashBuildUp = 0x13a8;
        public readonly bool m_bFlashDspHasBeenCleared = 0x13a9;
        public readonly bool m_bFlashScreenshotHasBeenGrabbed = 0x13aa;
        public readonly float m_flFlashMaxAlpha = 0x13ac;
        public readonly float m_flFlashDuration = 0x13b0;
        public readonly float m_flClientHealthFadeChangeTimestamp = 0x13b4;
        public readonly int m_nClientHealthFadeParityValue = 0x13b8;
        public readonly int m_fNextThinkPushAway = 0x13bc;
        public readonly float m_flCurrentMusicStartTime = 0x13c4;
        public readonly float m_flMusicRoundStartTime = 0x13c8;
        public readonly bool m_bDeferStartMusicOnWarmup = 0x13cc;
        public readonly float m_flLastSmokeOverlayAlpha = 0x13d0;
        public readonly float m_flLastSmokeAge = 0x13d4;
        public readonly int m_vLastSmokeOverlayColor = 0x13d8;
        public readonly CHandle m_hOriginalController = 0x1400;
    }

    // Address: 0x4542190
    public class C_InfoLadderDismount
    {
        // Fields (13):
        public readonly IntPtr m_pitch = 0x8;
        public readonly int m_volume = 0x18;
        public readonly string m_shutdownTime = 0x3c;
        public readonly float m_flLastTime = 0x40;
        public readonly int m_iszSoundScriptName = 0x48;
        public readonly CHandle m_hEnt = 0x50;
        public readonly string m_soundEntityIndex = 0x54;
        public readonly string m_soundOrigin = 0x58;
        public readonly int m_isPlaying = 0x64;
        public readonly int m_Filter = 0x68;
        public readonly float m_flCloseCaptionDuration = 0xa0;
        public readonly bool m_bUpdatedSoundOrigin = 0xa4;
        public readonly int m_iszClassName = 0xa8;
    }

    // Address: 0x453b390
    public class C_InfoVisibilityBox
    {
        // Fields (9):
        public readonly int m_vFanOriginOffset = 0x1020;
        public readonly int m_vDirection = 0x102c;
        public readonly bool m_bPushTowardsInfoTarget = 0x1038;
        public readonly bool m_bPushAwayFromInfoTarget = 0x1039;
        public readonly QAngle m_qNoiseDelta = 0x1040;
        public readonly CHandle m_hInfoFan = 0x1050;
        public readonly float m_flForce = 0x1054;
        public readonly bool m_bFalloff = 0x1058;
        public readonly int m_RampTimer = 0x1060;
    }

    // Address: 0x4576610
    public class C_KeychainModule
    {
        // Fields (2):
        public readonly int m_nItemDefIndex = 0x30;
        public readonly int m_nCount = 0x32;
    }

    // Address: 0x45a2988
    public class C_LateUpdatedAnimating
    {
        // Fields (29):
        public readonly bool m_bInventoryImageRgbaRequested = 0x70;
        public readonly bool m_bInventoryImageTriedCache = 0x71;
        public readonly int m_nInventoryImageRgbaWidth = 0x90;
        public readonly int m_nInventoryImageRgbaHeight = 0x94;
        public readonly string m_szCurrentLoadCachedFileName = 0x98;
        public readonly bool m_bRestoreCustomMaterialAfterPrecache = 0x10c0;
        public readonly int m_iItemDefinitionIndex = 0x10c2;
        public readonly int m_iEntityQuality = 0x10c4;
        public readonly int m_iEntityLevel = 0x10c8;
        public readonly int m_iItemID = 0x10d0;
        public readonly int m_iItemIDHigh = 0x10d8;
        public readonly int m_iItemIDLow = 0x10dc;
        public readonly int m_iAccountID = 0x10e0;
        public readonly int m_iInventoryPosition = 0x10e4;
        public readonly bool m_bInitialized = 0x10f0;
        public readonly bool m_bDisallowSOC = 0x10f1;
        public readonly bool m_bIsStoreItem = 0x10f2;
        public readonly bool m_bIsTradeItem = 0x10f3;
        public readonly int m_iEntityQuantity = 0x10f4;
        public readonly int m_iRarityOverride = 0x10f8;
        public readonly int m_iQualityOverride = 0x10fc;
        public readonly int m_iOriginOverride = 0x1100;
        public readonly uint m_ubStyleOverride = 0x1104;
        public readonly uint m_unClientFlags = 0x1105;
        public readonly int m_AttributeList = 0x1110;
        public readonly int m_NetworkedDynamicAttributes = 0x1188;
        public readonly string m_szCustomName = 0x1200;
        public readonly string m_szCustomNameOverride = 0x12a1;
        public readonly bool m_bInitializedTags = 0x1370;
    }

    // Address: 0x45547a8
    public class C_LocalTempEntity
    {
        // Fields (16):
        public readonly bool m_bStartActive = 0x788;
        public readonly float m_flMaxSimulationTime = 0x78c;
        public readonly int m_iszEffectName = 0x790;
        public readonly int m_PathNodes_Name = 0x798;
        public readonly float m_flParticleSpacing = 0x7b0;
        public readonly float m_flSlack = 0x7b4;
        public readonly float m_flRadius = 0x7b8;
        public readonly Color m_ColorTint = 0x7bc;
        public readonly int m_nEffectState = 0x7c0;
        public readonly int m_iEffectIndex = 0x7c8;
        public readonly int m_PathNodes_Position = 0x7d0;
        public readonly int m_PathNodes_TangentIn = 0x7e8;
        public readonly int m_PathNodes_TangentOut = 0x800;
        public readonly int m_PathNodes_Color = 0x818;
        public readonly int m_PathNodes_PinEnabled = 0x830;
        public readonly int m_PathNodes_RadiusScale = 0x848;
    }

    // Address: 0x45416c8
    public class C_MultiplayRules
    {
        // Fields (15):
        public readonly IntPtr m_pOriginatingInfo = 0x0;
        public readonly int m_DestructibleHitGroupRequests = 0x8;
        public readonly int m_nHealthLost = 0x18;
        public readonly int m_nHealthBefore = 0x1c;
        public readonly float m_flDamageDealt = 0x20;
        public readonly float m_flPreModifiedDamage = 0x24;
        public readonly int m_vDamagePosition = 0x28;
        public readonly int m_nTotalledHealthLost = 0x34;
        public readonly float m_flTotalledDamageDealt = 0x38;
        public readonly float m_flTotalledPreModifiedDamage = 0x3c;
        public readonly float m_flNewDamageAccumulatorValue = 0x40;
        public readonly int m_nDamageFlags = 0x48;
        public readonly bool m_bWasDamageSuppressed = 0x50;
        public readonly bool m_bSuppressFlinch = 0x51;
        public readonly int m_nOverrideFlinchHitGroup = 0x54;
    }

    // Address: 0x4586cb0
    public class C_ParticleSystem
    {
        // Fields (5):
        public readonly string m_sMapName = 0x0;
        public readonly string m_sLandmarkName = 0x8;
        public readonly CHandle m_hEntLandmark = 0x10;
        public readonly Vector3 m_vecLandmarkOrigin = 0x14;
        public readonly Vector3 m_vecLandmarkAngles = 0x20;
    }

    // Address: 0x4585790
    public class C_PathParticleRope
    {
        // Fields (6):
        public readonly int m_iObserverMode = 0x48;
        public readonly CHandle m_hObserverTarget = 0x4c;
        public readonly int m_iObserverLastMode = 0x50;
        public readonly bool m_bForcedObserverMode = 0x54;
        public readonly float m_flObserverChaseDistance = 0x58;
        public readonly float m_flObserverChaseDistanceCalcTime = 0x5c;
    }

    // Address: 0x4551688
    public class C_PhysBox
    {
        // Fields (7):
        public readonly int m_cellX = 0x10;
        public readonly int m_cellY = 0x12;
        public readonly int m_cellZ = 0x14;
        public readonly int m_nOutsideWorld = 0x16;
        public readonly Vector3 m_vecX = 0x18;
        public readonly Vector3 m_vecY = 0x20;
        public readonly Vector3 m_vecZ = 0x28;
    }

    // Address: 0x45514c8
    public class C_PhysicsProp
    {
        // Fields (3):
        public readonly Vector3 m_vecX = 0x10;
        public readonly Vector3 m_vecY = 0x18;
        public readonly Vector3 m_vecZ = 0x20;
    }

    // Address: 0x4599f10
    public class C_PlantedC4
    {
        // Fields (76):
        public readonly bool m_bEnabled = 0xf38;
        public readonly int m_nColorMode = 0xf3c;
        public readonly Color m_Color = 0xf40;
        public readonly float m_flColorTemperature = 0xf44;
        public readonly float m_flBrightness = 0xf48;
        public readonly float m_flBrightnessScale = 0xf4c;
        public readonly int m_nDirectLight = 0xf50;
        public readonly int m_nBakedShadowIndex = 0xf54;
        public readonly int m_nLightPathUniqueId = 0xf58;
        public readonly int m_nLightMapUniqueId = 0xf5c;
        public readonly int m_nLuminaireShape = 0xf60;
        public readonly float m_flLuminaireSize = 0xf64;
        public readonly float m_flLuminaireAnisotropy = 0xf68;
        public readonly int m_LightStyleString = 0xf70;
        public readonly float m_flLightStyleStartTime = 0xf78;
        public readonly int m_QueuedLightStyleStrings = 0xf80;
        public readonly int m_LightStyleEvents = 0xf98;
        public readonly int m_LightStyleTargets = 0xfb0;
        public readonly int m_StyleEvent = 0xfc8;
        public readonly CHandle m_hLightCookie = 0x1028;
        public readonly float m_flShape = 0x1030;
        public readonly float m_flSoftX = 0x1034;
        public readonly float m_flSoftY = 0x1038;
        public readonly float m_flSkirt = 0x103c;
        public readonly float m_flSkirtNear = 0x1040;
        public readonly int m_vSizeParams = 0x1044;
        public readonly float m_flRange = 0x1050;
        public readonly int m_vShear = 0x1054;
        public readonly int m_nBakeSpecularToCubemaps = 0x1060;
        public readonly int m_vBakeSpecularToCubemapsSize = 0x1064;
        public readonly float m_flBakeSpecularToCubemapsScale = 0x1070;
        public readonly int m_nCastShadows = 0x1074;
        public readonly int m_nShadowMapSize = 0x1078;
        public readonly int m_nShadowPriority = 0x107c;
        public readonly bool m_bContactShadow = 0x1080;
        public readonly bool m_bForceShadowsEnabled = 0x1081;
        public readonly int m_nBounceLight = 0x1084;
        public readonly float m_flBounceScale = 0x1088;
        public readonly float m_flMinRoughness = 0x108c;
        public readonly int m_vAlternateColor = 0x1090;
        public readonly int m_fAlternateColorBrightness = 0x109c;
        public readonly int m_nFog = 0x10a0;
        public readonly float m_flFogStrength = 0x10a4;
        public readonly int m_nFogShadows = 0x10a8;
        public readonly float m_flFogScale = 0x10ac;
        public readonly float m_flFadeSizeStart = 0x10b0;
        public readonly float m_flFadeSizeEnd = 0x10b4;
        public readonly float m_flShadowFadeSizeStart = 0x10b8;
        public readonly float m_flShadowFadeSizeEnd = 0x10bc;
        public readonly bool m_bPrecomputedFieldsValid = 0x10c0;
        public readonly int m_vPrecomputedBoundsMins = 0x10c4;
        public readonly int m_vPrecomputedBoundsMaxs = 0x10d0;
        public readonly int m_vPrecomputedOBBOrigin = 0x10dc;
        public readonly int m_vPrecomputedOBBAngles = 0x10e8;
        public readonly int m_vPrecomputedOBBExtent = 0x10f4;
        public readonly int m_nPrecomputedSubFrusta = 0x1100;
        public readonly int m_vPrecomputedOBBOrigin0 = 0x1104;
        public readonly int m_vPrecomputedOBBAngles0 = 0x1110;
        public readonly int m_vPrecomputedOBBExtent0 = 0x111c;
        public readonly int m_vPrecomputedOBBOrigin1 = 0x1128;
        public readonly int m_vPrecomputedOBBAngles1 = 0x1134;
        public readonly int m_vPrecomputedOBBExtent1 = 0x1140;
        public readonly int m_vPrecomputedOBBOrigin2 = 0x114c;
        public readonly int m_vPrecomputedOBBAngles2 = 0x1158;
        public readonly int m_vPrecomputedOBBExtent2 = 0x1164;
        public readonly int m_vPrecomputedOBBOrigin3 = 0x1170;
        public readonly int m_vPrecomputedOBBAngles3 = 0x117c;
        public readonly int m_vPrecomputedOBBExtent3 = 0x1188;
        public readonly int m_vPrecomputedOBBOrigin4 = 0x1194;
        public readonly int m_vPrecomputedOBBAngles4 = 0x11a0;
        public readonly int m_vPrecomputedOBBExtent4 = 0x11ac;
        public readonly int m_vPrecomputedOBBOrigin5 = 0x11b8;
        public readonly int m_vPrecomputedOBBAngles5 = 0x11c4;
        public readonly int m_vPrecomputedOBBExtent5 = 0x11d0;
        public readonly bool m_bInitialBoneSetup = 0x1220;
        public readonly int m_VisClusters = 0x1228;
    }

    // Address: 0x4535650
    public class C_PlayerVisibility
    {
        // Fields (24):
        public readonly float m_flEndDistance = 0x77c;
        public readonly float m_flStartDistance = 0x780;
        public readonly float m_flFogFalloffExponent = 0x784;
        public readonly bool m_bHeightFogEnabled = 0x788;
        public readonly float m_flFogHeightWidth = 0x78c;
        public readonly float m_flFogHeightEnd = 0x790;
        public readonly float m_flFogHeightStart = 0x794;
        public readonly float m_flFogHeightExponent = 0x798;
        public readonly float m_flLODBias = 0x79c;
        public readonly bool m_bActive = 0x7a0;
        public readonly bool m_bStartDisabled = 0x7a1;
        public readonly float m_flFogMaxOpacity = 0x7a4;
        public readonly int m_nCubemapSourceType = 0x7a8;
        public readonly CHandle m_hSkyMaterial = 0x7b0;
        public readonly int m_iszSkyEntity = 0x7b8;
        public readonly int m_nHeightFogType = 0x7c0;
        public readonly int m_nFogHeightBlendMode = 0x7c4;
        public readonly int m_nFogHeightCoordinateSpace = 0x7c8;
        public readonly int m_nDistanceFogType = 0x7cc;
        public readonly int m_DistanceFogCurveString = 0x7d0;
        public readonly int m_HeightFogCurveString = 0x7d8;
        public readonly CHandle m_hFogCubemapTexture = 0x870;
        public readonly bool m_bHasHeightFogEnd = 0x878;
        public readonly bool m_bFirstTime = 0x879;
    }

    // Address: 0x4539230
    public class C_PointCameraVFOV
    {
        // Fields (3):
        public readonly int m_nMode = 0x780;
        public readonly int m_vBoxSize = 0x784;
        public readonly bool m_bEnabled = 0x790;
    }

    // Address: 0x4528048
    public class C_PointClientUIWorldPanel
    {
        // Fields (70):
        private readonly IntPtr __m_pChainEntity = 0x38;
        public readonly Color m_Color = 0x75;
        public readonly int m_SecondaryColor = 0x79;
        public readonly float m_flBrightness = 0x80;
        public readonly float m_flBrightnessScale = 0x84;
        public readonly float m_flBrightnessMult = 0x88;
        public readonly float m_flRange = 0x8c;
        public readonly float m_flFalloff = 0x90;
        public readonly float m_flAttenuation0 = 0x94;
        public readonly float m_flAttenuation1 = 0x98;
        public readonly float m_flAttenuation2 = 0x9c;
        public readonly float m_flTheta = 0xa0;
        public readonly float m_flPhi = 0xa4;
        public readonly CHandle m_hLightCookie = 0xa8;
        public readonly int m_nCascades = 0xb0;
        public readonly int m_nCastShadows = 0xb4;
        public readonly int m_nShadowWidth = 0xb8;
        public readonly int m_nShadowHeight = 0xbc;
        public readonly bool m_bRenderDiffuse = 0xc0;
        public readonly int m_nRenderSpecular = 0xc4;
        public readonly bool m_bRenderTransmissive = 0xc8;
        public readonly float m_flOrthoLightWidth = 0xcc;
        public readonly float m_flOrthoLightHeight = 0xd0;
        public readonly int m_nStyle = 0xd4;
        public readonly int m_Pattern = 0xd8;
        public readonly int m_nCascadeRenderStaticObjects = 0xe0;
        public readonly float m_flShadowCascadeCrossFade = 0xe4;
        public readonly float m_flShadowCascadeDistanceFade = 0xe8;
        public readonly float m_flShadowCascadeDistance0 = 0xec;
        public readonly float m_flShadowCascadeDistance1 = 0xf0;
        public readonly float m_flShadowCascadeDistance2 = 0xf4;
        public readonly float m_flShadowCascadeDistance3 = 0xf8;
        public readonly int m_nShadowCascadeResolution0 = 0xfc;
        public readonly int m_nShadowCascadeResolution1 = 0x100;
        public readonly int m_nShadowCascadeResolution2 = 0x104;
        public readonly int m_nShadowCascadeResolution3 = 0x108;
        public readonly bool m_bUsesBakedShadowing = 0x10c;
        public readonly int m_nShadowPriority = 0x110;
        public readonly int m_nBakedShadowIndex = 0x114;
        public readonly int m_nLightPathUniqueId = 0x118;
        public readonly int m_nLightMapUniqueId = 0x11c;
        public readonly bool m_bRenderToCubemaps = 0x120;
        public readonly bool m_bAllowSSTGeneration = 0x121;
        public readonly int m_nDirectLight = 0x124;
        public readonly int m_nBounceLight = 0x128;
        public readonly float m_flBounceScale = 0x12c;
        public readonly float m_flFadeMinDist = 0x130;
        public readonly float m_flFadeMaxDist = 0x134;
        public readonly float m_flShadowFadeMinDist = 0x138;
        public readonly float m_flShadowFadeMaxDist = 0x13c;
        public readonly bool m_bEnabled = 0x140;
        public readonly bool m_bFlicker = 0x141;
        public readonly bool m_bPrecomputedFieldsValid = 0x142;
        public readonly int m_vPrecomputedBoundsMins = 0x144;
        public readonly int m_vPrecomputedBoundsMaxs = 0x150;
        public readonly int m_vPrecomputedOBBOrigin = 0x15c;
        public readonly int m_vPrecomputedOBBAngles = 0x168;
        public readonly int m_vPrecomputedOBBExtent = 0x174;
        public readonly float m_flPrecomputedMaxRange = 0x180;
        public readonly int m_nFogLightingMode = 0x184;
        public readonly float m_flFogContributionStength = 0x188;
        public readonly float m_flNearClipPlane = 0x18c;
        public readonly int m_SkyColor = 0x190;
        public readonly float m_flSkyIntensity = 0x194;
        public readonly int m_SkyAmbientBounce = 0x198;
        public readonly bool m_bUseSecondaryColor = 0x19c;
        public readonly bool m_bMixedShadows = 0x19d;
        public readonly float m_flLightStyleStartTime = 0x1a0;
        public readonly float m_flCapsuleLength = 0x1a4;
        public readonly float m_flMinRoughness = 0x1a8;
    }

    // Address: 0x4527ed0
    public class C_PointClientUIWorldTextPanel
    {
        // Fields (5):
        private readonly IntPtr __m_pChainEntity = 0x10;
        public readonly bool m_bIsRenderingWithViewModels = 0x50;
        public readonly int m_nSplitscreenFlags = 0x54;
        public readonly bool m_bEnableRendering = 0x58;
        public readonly bool m_bInterpolationReadyToDraw = 0xb8;
    }

    // Address: 0x4591b90
    public class C_PointValueRemapper
    {
        // Fields (8):
        public readonly int m_iszStackName = 0x798;
        public readonly int m_iszOperatorName = 0x7a0;
        public readonly int m_iszOpvarName = 0x7a8;
        public readonly int m_vDistanceInnerMins = 0x7b0;
        public readonly int m_vDistanceInnerMaxs = 0x7bc;
        public readonly int m_vDistanceOuterMins = 0x7c8;
        public readonly int m_vDistanceOuterMaxs = 0x7d4;
        public readonly int m_nAABBDirection = 0x7e0;
    }

    // Address: 0x4590e30
    public class C_PointWorldText
    {
        // Fields (2):
        public readonly int m_Handle = 0x77c;
        public readonly bool m_bSendHandle = 0x780;
    }

    // Address: 0x4540a10
    public class C_PostProcessingVolume
    {
        // Fields (20):
        public readonly int m_vOrigin = 0x8;
        public readonly int m_vStart = 0x14;
        public readonly int m_vNormal = 0x20;
        public readonly int m_vAngles = 0x2c;
        public readonly CHandle m_hEntity = 0x38;
        public readonly CHandle m_hOtherEntity = 0x3c;
        public readonly float m_flScale = 0x40;
        public readonly float m_flMagnitude = 0x44;
        public readonly float m_flRadius = 0x48;
        public readonly int m_nSurfaceProp = 0x4c;
        public readonly int m_nEffectIndex = 0x50;
        public readonly int m_nDamageType = 0x58;
        public readonly int m_nPenetrate = 0x5c;
        public readonly int m_nMaterial = 0x5e;
        public readonly int m_nHitBox = 0x60;
        public readonly int m_nColor = 0x62;
        public readonly int m_fFlags = 0x63;
        public readonly int m_nAttachmentIndex = 0x64;
        public readonly int m_nAttachmentName = 0x68;
        public readonly int m_iEffectName = 0x6c;
    }

    // Address: 0x4549850
    public class C_PrecipitationBlocker
    {
        // Fields (4):
        public readonly bool m_bModelOverrodeBlockLOS = 0x1108;
        public readonly int m_iShapeType = 0x110c;
        public readonly bool m_bConformToCollisionBounds = 0x1110;
        public readonly int m_mPreferredCatchTransform = 0x1120;
    }

    // Address: 0x45511a8
    public class C_PropDoorRotating
    {
        // Fields (7):
        public readonly CHandle m_hEntity = 0x0;
        public readonly int m_iIndex = 0x4;
        public readonly float m_flStartTime = 0x8;
        public readonly float m_flGrowthDuration = 0xc;
        public readonly Vector3 m_vecGrowthOrigin = 0x10;
        public readonly float m_flEndcapTime = 0x1c;
        public readonly bool m_bMarkedForDelete = 0x20;
    }

    // Address: 0x4551168
    public class C_RopeKeyframe
    {
        // Fields (7):
        public readonly string m_saveId = 0x0;
        public readonly int m_version = 0x4;
        public readonly int m_nConnectionCount = 0x8;
        public readonly int m_nMapVersion = 0xc;
        public readonly string m_sSpawnGroupName = 0x10;
        public readonly Vector3 m_vecWorldOffset = 0x20;
        public readonly float m_flSaveTime = 0x50;
    }

    // Address: 0x4541fa8
    public class C_ShatterGlassShardPhysics
    {
        // Fields (24):
        public readonly CHandle m_hSpriteMaterial = 0xf38;
        public readonly CHandle m_hAttachedToEntity = 0xf40;
        public readonly int m_nAttachment = 0xf44;
        public readonly float m_flSpriteFramerate = 0xf48;
        public readonly float m_flFrame = 0xf4c;
        public readonly float m_flDieTime = 0xf50;
        public readonly int m_nBrightness = 0xf60;
        public readonly float m_flBrightnessDuration = 0xf64;
        public readonly float m_flSpriteScale = 0xf68;
        public readonly float m_flScaleDuration = 0xf6c;
        public readonly bool m_bWorldSpaceScale = 0xf70;
        public readonly float m_flGlowProxySize = 0xf74;
        public readonly float m_flHDRColorScale = 0xf78;
        public readonly float m_flLastTime = 0xf7c;
        public readonly float m_flMaxFrame = 0xf80;
        public readonly float m_flStartScale = 0xf84;
        public readonly float m_flDestScale = 0xf88;
        public readonly float m_flScaleTimeStart = 0xf8c;
        public readonly int m_nStartBrightness = 0xf90;
        public readonly int m_nDestBrightness = 0xf94;
        public readonly float m_flBrightnessTimeStart = 0xf98;
        public readonly int m_nSpriteWidth = 0xfa8;
        public readonly int m_nSpriteHeight = 0xfac;
        public readonly float m_flSpeed = 0xfb0;
    }

    // Address: 0x4576f68
    public class C_SmokeGrenade
    {
        // Fields (68):
        public readonly IntPtr m_pInGameMoneyServices = 0x990;
        public readonly IntPtr m_pInventoryServices = 0x998;
        public readonly IntPtr m_pActionTrackingServices = 0x9a0;
        public readonly IntPtr m_pDamageServices = 0x9a8;
        public readonly int m_iPing = 0x9b0;
        public readonly bool m_bHasCommunicationAbuseMute = 0x9b4;
        public readonly uint m_uiCommunicationMuteFlags = 0x9b8;
        public readonly string m_szCrosshairCodes = 0x9c0;
        public readonly int m_iPendingTeamNum = 0x9c8;
        public readonly float m_flForceTeamTime = 0x9cc;
        public readonly int m_iCompTeammateColor = 0x9d0;
        public readonly bool m_bEverPlayedOnTeam = 0x9d4;
        public readonly float m_flPreviousForceJoinTeamTime = 0x9d8;
        public readonly string m_szClan = 0x9e0;
        public readonly string m_sSanitizedPlayerName = 0x9e8;
        public readonly int m_iCoachingTeam = 0x9f0;
        public readonly int m_nPlayerDominated = 0x9f8;
        public readonly int m_nPlayerDominatingMe = 0xa00;
        public readonly int m_iCompetitiveRanking = 0xa08;
        public readonly int m_iCompetitiveWins = 0xa0c;
        public readonly int m_iCompetitiveRankType = 0xa10;
        public readonly int m_iCompetitiveRankingPredicted_Win = 0xa14;
        public readonly int m_iCompetitiveRankingPredicted_Loss = 0xa18;
        public readonly int m_iCompetitiveRankingPredicted_Tie = 0xa1c;
        public readonly int m_nEndMatchNextMapVote = 0xa20;
        public readonly uint m_unActiveQuestId = 0xa24;
        public readonly int m_rtActiveMissionPeriod = 0xa28;
        public readonly int m_nQuestProgressReason = 0xa2c;
        public readonly uint m_unPlayerTvControlFlags = 0xa30;
        public readonly int m_iDraftIndex = 0xa60;
        public readonly int m_msQueuedModeDisconnectionTimestamp = 0xa64;
        public readonly uint m_uiAbandonRecordedReason = 0xa68;
        public readonly int m_eNetworkDisconnectionReason = 0xa6c;
        public readonly bool m_bCannotBeKicked = 0xa70;
        public readonly bool m_bEverFullyConnected = 0xa71;
        public readonly bool m_bAbandonAllowsSurrender = 0xa72;
        public readonly bool m_bAbandonOffersInstantSurrender = 0xa73;
        public readonly bool m_bDisconnection1MinWarningPrinted = 0xa74;
        public readonly bool m_bScoreReported = 0xa75;
        public readonly int m_nDisconnectionTick = 0xa78;
        public readonly bool m_bControllingBot = 0xa88;
        public readonly bool m_bHasControlledBotThisRound = 0xa89;
        public readonly bool m_bHasBeenControlledByPlayerThisRound = 0xa8a;
        public readonly int m_nBotsControlledThisRound = 0xa8c;
        public readonly bool m_bCanControlObservedBot = 0xa90;
        public readonly CHandle m_hPlayerPawn = 0xa94;
        public readonly CHandle m_hObserverPawn = 0xa98;
        public readonly bool m_bPawnIsAlive = 0xa9c;
        public readonly int m_iPawnHealth = 0xaa0;
        public readonly int m_iPawnArmor = 0xaa4;
        public readonly bool m_bPawnHasDefuser = 0xaa8;
        public readonly bool m_bPawnHasHelmet = 0xaa9;
        public readonly int m_nPawnCharacterDefIndex = 0xaaa;
        public readonly int m_iPawnLifetimeStart = 0xaac;
        public readonly int m_iPawnLifetimeEnd = 0xab0;
        public readonly int m_iPawnBotDifficulty = 0xab4;
        public readonly CHandle m_hOriginalControllerOfCurrentPawn = 0xab8;
        public readonly int m_iScore = 0xabc;
        public readonly int m_recentKillQueue = 0xac0;
        public readonly int m_nFirstKill = 0xac8;
        public readonly int m_nKillCount = 0xac9;
        public readonly bool m_bMvpNoMusic = 0xaca;
        public readonly int m_eMvpReason = 0xacc;
        public readonly int m_iMusicKitID = 0xad0;
        public readonly int m_iMusicKitMVPs = 0xad4;
        public readonly int m_iMVPs = 0xad8;
        public readonly bool m_bIsPlayerNameDirty = 0xadc;
        public readonly bool m_bFireBulletsSeedSynchronized = 0xadd;
    }

    // Address: 0x453fb50
    public class C_SoundAreaEntityBase
    {
        // Fields (4):
        private readonly IntPtr __m_pChainEntity = 0x8;
        public readonly int m_nTotalPausedTicks = 0x30;
        public readonly int m_nPauseStartTick = 0x34;
        public readonly bool m_bGamePaused = 0x38;
    }

    // Address: 0x453f890
    public class C_SoundAreaEntityOrientedBox
    {
        // Fields (11):
        public readonly int m_fGlowColor = 0x8;
        public readonly int m_iGlowType = 0x30;
        public readonly int m_iGlowTeam = 0x34;
        public readonly int m_nGlowRange = 0x38;
        public readonly int m_nGlowRangeMin = 0x3c;
        public readonly int m_glowColorOverride = 0x40;
        public readonly bool m_bFlashing = 0x44;
        public readonly float m_flGlowTime = 0x48;
        public readonly float m_flGlowStartTime = 0x4c;
        public readonly bool m_bEligibleForScreenHighlight = 0x50;
        public readonly bool m_bGlowing = 0x51;
    }

    // Address: 0x453f2d0
    public class C_SoundEventEntity
    {
        // Fields (14):
        public readonly CHandle m_hCtrl = 0x8;
        public readonly float m_flTransitionTime = 0xc;
        public readonly int m_OldColor = 0x10;
        public readonly float m_flOldStart = 0x14;
        public readonly float m_flOldEnd = 0x18;
        public readonly float m_flOldMaxDensity = 0x1c;
        public readonly float m_flOldHDRColorScale = 0x20;
        public readonly float m_flOldFarZ = 0x24;
        public readonly int m_NewColor = 0x28;
        public readonly float m_flNewStart = 0x2c;
        public readonly float m_flNewEnd = 0x30;
        public readonly float m_flNewMaxDensity = 0x34;
        public readonly float m_flNewHDRColorScale = 0x38;
        public readonly float m_flNewFarZ = 0x3c;
    }

    // Address: 0x453de48
    public class C_SoundEventOBBEntity
    {
        // Fields (10):
        public readonly float m_flDmgModBullet = 0x10;
        public readonly float m_flDmgModClub = 0x14;
        public readonly float m_flDmgModExplosive = 0x18;
        public readonly float m_flDmgModFire = 0x1c;
        public readonly int m_iszPhysicsDamageTableName = 0x20;
        public readonly int m_iszBasePropData = 0x28;
        public readonly int m_nInteractions = 0x30;
        public readonly bool m_bSpawnMotionDisabled = 0x34;
        public readonly int m_nDisableTakePhysicsDamageSpawnFlag = 0x38;
        public readonly int m_nMotionDisabledSpawnFlag = 0x3c;
    }

    // Address: 0x453e2f0
    public class C_SoundEventPathCornerEntity
    {
        // Fields (12):
        public readonly CHandle m_hPostSettings = 0x1030;
        public readonly float m_flFadeDuration = 0x1038;
        public readonly float m_flMinLogExposure = 0x103c;
        public readonly float m_flMaxLogExposure = 0x1040;
        public readonly float m_flMinExposure = 0x1044;
        public readonly float m_flMaxExposure = 0x1048;
        public readonly float m_flExposureCompensation = 0x104c;
        public readonly float m_flExposureFadeSpeedUp = 0x1050;
        public readonly float m_flExposureFadeSpeedDown = 0x1054;
        public readonly float m_flTonemapEVSmoothingRange = 0x1058;
        public readonly bool m_bMaster = 0x105c;
        public readonly bool m_bExposureControl = 0x105d;
    }

    // Address: 0x4544568
    public class C_SoundOpvarSetAutoRoomEntity
    {
        // Fields (20):
        public readonly int m_iLayer = 0x0;
        public readonly int m_iPriority = 0x4;
        public readonly CHandle m_hSequence = 0x8;
        public readonly float m_flWeight = 0xc;
        public readonly float m_flLastAccumulatedTime = 0x10;
        public readonly float m_flLastJumpFromTime = 0x14;
        public readonly float m_flLastJumpToTime = 0x18;
        public readonly float m_flLastCycle = 0x1c;
        public readonly CHandle m_hAnimClip = 0x20;
        public readonly string m_sAnimClipSlot = 0x28;
        public readonly string m_sAnimClipSlotWeight = 0x30;
        public readonly bool m_bHasArrived = 0x38;
        public readonly int m_nType = 0x3c;
        public readonly float m_flNext = 0x40;
        public readonly bool m_bIsGesture = 0x44;
        public readonly bool m_bShouldRemove = 0x45;
        public readonly CHandle m_hTarget = 0x6c;
        public readonly int m_nSceneEventId = 0x70;
        public readonly bool m_bClientSide = 0x74;
        public readonly bool m_bStarted = 0x75;
    }

    // Address: 0x4544868
    public class C_SoundOpvarSetPointBase
    {
        // Fields (3):
        public readonly int m_Transforms = 0x8;
        public readonly CHandle m_hOwner = 0x20;
        public readonly bool m_bSetFromDebugHistory = 0x24;
    }

    // Address: 0x4592e90
    public class C_Sprite
    {
        // Fields (6):
        public readonly int m_matLocal = 0x1108;
        public readonly int m_iBoneIndex = 0x1138;
        public readonly CHandle m_hPlayerParent = 0x113c;
        public readonly bool m_bIsHit = 0x1140;
        public readonly float m_flTimeCreated = 0x1144;
        public readonly Vector3 m_vecStartPos = 0x1148;
    }

    // Address: 0x4589f70
    public class C_TextureBasedAnimatable
    {
        // Fields (9):
        public readonly int m_LastEnterWeight = 0x1020;
        public readonly int m_LastEnterTime = 0x1024;
        public readonly int m_LastExitWeight = 0x1028;
        public readonly int m_LastExitTime = 0x102c;
        public readonly bool m_bEnabled = 0x1030;
        public readonly int m_MaxWeight = 0x1034;
        public readonly int m_FadeDuration = 0x1038;
        public readonly int m_Weight = 0x103c;
        public readonly int m_lookupFilename = 0x1040;
    }

    // Address: 0x4534710
    public class C_TonemapController2
    {
        // Fields (16):
        public readonly CHandle m_hGradientFogTexture = 0x780;
        public readonly float m_flFogStartDistance = 0x788;
        public readonly float m_flFogEndDistance = 0x78c;
        public readonly bool m_bHeightFogEnabled = 0x790;
        public readonly float m_flFogStartHeight = 0x794;
        public readonly float m_flFogEndHeight = 0x798;
        public readonly float m_flFarZ = 0x79c;
        public readonly float m_flFogMaxOpacity = 0x7a0;
        public readonly float m_flFogFalloffExponent = 0x7a4;
        public readonly float m_flFogVerticalExponent = 0x7a8;
        public readonly int m_fogColor = 0x7ac;
        public readonly float m_flFogStrength = 0x7b0;
        public readonly float m_flFadeTime = 0x7b4;
        public readonly bool m_bStartDisabled = 0x7b8;
        public readonly bool m_bIsEnabled = 0x7b9;
        public readonly bool m_bGradientFogNeedsTextures = 0x7ba;
    }

    // Address: 0x4550488
    public class C_TriggerLerpObject
    {
        // Fields (10):
        public readonly bool m_bHull_Human = 0x0;
        public readonly bool m_bHull_SmallCentered = 0x1;
        public readonly bool m_bHull_WideHuman = 0x2;
        public readonly bool m_bHull_Tiny = 0x3;
        public readonly bool m_bHull_Medium = 0x4;
        public readonly bool m_bHull_TinyCentered = 0x5;
        public readonly bool m_bHull_Large = 0x6;
        public readonly bool m_bHull_LargeCentered = 0x7;
        public readonly bool m_bHull_MediumTall = 0x8;
        public readonly bool m_bHull_Small = 0x9;
    }

    // Address: 0x4599848
    public class C_VoteController
    {
        // Fields (5):
        public readonly int m_leader = 0x1348;
        public readonly int m_AttributeManager = 0x1350;
        public readonly bool m_bAttributesInitialized = 0x2728;
        public readonly CHandle m_hWaterWakeParticles = 0x272c;
        public readonly bool m_bIsPreviewModel = 0x2730;
    }

    // Address: 0x458e0f0
    public class C_WaterBullet
    {
        // Fields (19):
        public readonly bool m_bForceRecreateNextUpdate = 0xf40;
        public readonly int m_nTextWidthPx = 0xf58;
        public readonly int m_nTextHeightPx = 0xf5c;
        public readonly int m_messageText = 0xf60;
        public readonly int m_FontName = 0x1160;
        public readonly int m_BackgroundMaterialName = 0x11a0;
        public readonly bool m_bEnabled = 0x11e0;
        public readonly bool m_bFullbright = 0x11e1;
        public readonly float m_flWorldUnitsPerPx = 0x11e4;
        public readonly float m_flFontSize = 0x11e8;
        public readonly float m_flDepthOffset = 0x11ec;
        public readonly bool m_bDrawBackground = 0x11f0;
        public readonly float m_flBackgroundBorderWidth = 0x11f4;
        public readonly float m_flBackgroundBorderHeight = 0x11f8;
        public readonly float m_flBackgroundWorldToUV = 0x11fc;
        public readonly Color m_Color = 0x1200;
        public readonly int m_nJustifyHorizontal = 0x1204;
        public readonly int m_nJustifyVertical = 0x1208;
        public readonly int m_nReorientMode = 0x120c;
    }

    // Address: 0x4576c10
    public class C_WeaponBaseItem
    {
        // Fields (9):
        public readonly int m_action = 0x88;
        public readonly bool m_bActionReset = 0xa0;
        public readonly int m_idleVariation = 0xc0;
        public readonly int m_runVariation = 0xd8;
        public readonly IntPtr m_panicVariation = 0xf0;
        public readonly string m_squatVariation = 0x108;
        public readonly bool m_bInWater = 0x120;
        public readonly bool m_bHasActionCompletedEvent = 0x138;
        public readonly bool m_bWaitingForCompletedEvent = 0x139;
    }

    // Address: 0x4577c10
    public class C_WeaponElite
    {
        // Fields (5):
        public readonly uint m_unDefIdx = 0x30;
        public readonly int m_nCost = 0x34;
        public readonly int m_nPrevArmor = 0x38;
        public readonly bool m_bPrevHelmet = 0x3c;
        public readonly CHandle m_hItem = 0x40;
    }

    // Address: 0x4573468
    public class C_WeaponFamas
    {
        // Fields (84):
        public readonly int m_WeaponType = 0x520;
        public readonly int m_WeaponCategory = 0x524;
        public readonly string m_szAnimSkeleton = 0x528;
        public readonly Vector3 m_vecMuzzlePos0 = 0x608;
        public readonly Vector3 m_vecMuzzlePos1 = 0x614;
        public readonly string m_szTracerParticle = 0x620;
        public readonly int m_GearSlot = 0x700;
        public readonly int m_GearSlotPosition = 0x704;
        public readonly int m_DefaultLoadoutSlot = 0x708;
        public readonly int m_nPrice = 0x70c;
        public readonly int m_nKillAward = 0x710;
        public readonly int m_nPrimaryReserveAmmoMax = 0x714;
        public readonly int m_nSecondaryReserveAmmoMax = 0x718;
        public readonly bool m_bMeleeWeapon = 0x71c;
        public readonly bool m_bHasBurstMode = 0x71d;
        public readonly bool m_bIsRevolver = 0x71e;
        public readonly bool m_bCannotShootUnderwater = 0x71f;
        public readonly string m_szName = 0x720;
        public readonly int m_eSilencerType = 0x728;
        public readonly int m_nCrosshairMinDistance = 0x72c;
        public readonly int m_nCrosshairDeltaDistance = 0x730;
        public readonly bool m_bIsFullAuto = 0x734;
        public readonly int m_nNumBullets = 0x738;
        public readonly bool m_bReloadsSingleShells = 0x73c;
        public readonly float m_flCycleTime = 0x740;
        public readonly float m_flCycleTimeWhenInBurstMode = 0x748;
        public readonly float m_flTimeBetweenBurstShots = 0x74c;
        public readonly float m_flMaxSpeed = 0x750;
        public readonly float m_flSpread = 0x758;
        public readonly float m_flInaccuracyCrouch = 0x760;
        public readonly float m_flInaccuracyStand = 0x768;
        public readonly float m_flInaccuracyJump = 0x770;
        public readonly float m_flInaccuracyLand = 0x778;
        public readonly float m_flInaccuracyLadder = 0x780;
        public readonly float m_flInaccuracyFire = 0x788;
        public readonly float m_flInaccuracyMove = 0x790;
        public readonly float m_flRecoilAngle = 0x798;
        public readonly float m_flRecoilAngleVariance = 0x7a0;
        public readonly float m_flRecoilMagnitude = 0x7a8;
        public readonly float m_flRecoilMagnitudeVariance = 0x7b0;
        public readonly int m_nTracerFrequency = 0x7b8;
        public readonly float m_flInaccuracyJumpInitial = 0x7c0;
        public readonly float m_flInaccuracyJumpApex = 0x7c4;
        public readonly float m_flInaccuracyReload = 0x7c8;
        public readonly float m_flDeployDuration = 0x7cc;
        public readonly float m_flDisallowAttackAfterReloadStartDuration = 0x7d0;
        public readonly int m_nBurstShotCount = 0x7d4;
        public readonly bool m_bAllowBurstHolster = 0x7d8;
        public readonly int m_nRecoilSeed = 0x7dc;
        public readonly int m_nSpreadSeed = 0x7e0;
        public readonly float m_flAttackMovespeedFactor = 0x7e4;
        public readonly float m_flInaccuracyPitchShift = 0x7e8;
        public readonly float m_flInaccuracyAltSoundThreshold = 0x7ec;
        public readonly string m_szUseRadioSubtitle = 0x7f0;
        public readonly bool m_bUnzoomsAfterShot = 0x7f8;
        public readonly bool m_bHideViewModelWhenZoomed = 0x7f9;
        public readonly int m_nZoomLevels = 0x7fc;
        public readonly int m_nZoomFOV1 = 0x800;
        public readonly int m_nZoomFOV2 = 0x804;
        public readonly float m_flZoomTime0 = 0x808;
        public readonly float m_flZoomTime1 = 0x80c;
        public readonly float m_flZoomTime2 = 0x810;
        public readonly float m_flIronSightPullUpSpeed = 0x814;
        public readonly float m_flIronSightPutDownSpeed = 0x818;
        public readonly float m_flIronSightFOV = 0x81c;
        public readonly float m_flIronSightPivotForward = 0x820;
        public readonly float m_flIronSightLooseness = 0x824;
        public readonly int m_nDamage = 0x828;
        public readonly float m_flHeadshotMultiplier = 0x82c;
        public readonly float m_flArmorRatio = 0x830;
        public readonly float m_flPenetration = 0x834;
        public readonly float m_flRange = 0x838;
        public readonly float m_flRangeModifier = 0x83c;
        public readonly float m_flFlinchVelocityModifierLarge = 0x840;
        public readonly float m_flFlinchVelocityModifierSmall = 0x844;
        public readonly float m_flRecoveryTimeCrouch = 0x848;
        public readonly float m_flRecoveryTimeStand = 0x84c;
        public readonly float m_flRecoveryTimeCrouchFinal = 0x850;
        public readonly float m_flRecoveryTimeStandFinal = 0x854;
        public readonly int m_nRecoveryTransitionStartBullet = 0x858;
        public readonly int m_nRecoveryTransitionEndBullet = 0x85c;
        public readonly float m_flThrowVelocity = 0x860;
        public readonly int m_vSmokeColor = 0x864;
        public readonly string m_szAnimClass = 0x870;
    }

    // Address: 0x4572d68
    public class C_WeaponNegev
    {
        // Fields (54):
        public readonly int m_iWeaponGameplayAnimState = 0x2608;
        public readonly float m_flWeaponGameplayAnimStateTimestamp = 0x260c;
        public readonly float m_flInspectCancelCompleteTime = 0x2610;
        public readonly bool m_bInspectPending = 0x2614;
        public readonly bool m_bInspectShouldLoop = 0x2615;
        public readonly float m_flCrosshairDistance = 0x2640;
        public readonly int m_iAmmoLastCheck = 0x2644;
        public readonly int m_nLastEmptySoundCmdNum = 0x2648;
        public readonly bool m_bFireOnEmpty = 0x264c;
        public readonly int m_OnPlayerPickup = 0x2650;
        public readonly int m_weaponMode = 0x2668;
        public readonly float m_flTurningInaccuracyDelta = 0x266c;
        public readonly Vector3 m_vecTurningInaccuracyEyeDirLast = 0x2670;
        public readonly float m_flTurningInaccuracy = 0x267c;
        public readonly int m_fAccuracyPenalty = 0x2680;
        public readonly float m_flLastAccuracyUpdateTime = 0x2684;
        public readonly int m_fAccuracySmoothedForZoom = 0x2688;
        public readonly int m_iRecoilIndex = 0x268c;
        public readonly float m_flRecoilIndex = 0x2690;
        public readonly bool m_bBurstMode = 0x2694;
        public readonly float m_flLastBurstModeChangeTime = 0x2698;
        public readonly int m_nPostponeFireReadyTicks = 0x269c;
        public readonly float m_flPostponeFireReadyFrac = 0x26a0;
        public readonly bool m_bInReload = 0x26a4;
        public readonly int m_nDeployTick = 0x26a8;
        public readonly float m_flDroppedAtTime = 0x26ac;
        public readonly bool m_bIsHauledBack = 0x26b4;
        public readonly bool m_bSilencerOn = 0x26b5;
        public readonly float m_flTimeSilencerSwitchComplete = 0x26b8;
        public readonly float m_flWeaponActionPlaybackRate = 0x26bc;
        public readonly int m_iOriginalTeamNumber = 0x26c0;
        public readonly int m_iMostRecentTeamNumber = 0x26c4;
        public readonly bool m_bDroppedNearBuyZone = 0x26c8;
        public readonly float m_flNextAttackRenderTimeOffset = 0x26cc;
        public readonly bool m_bClearWeaponIdentifyingUGC = 0x2778;
        public readonly bool m_bVisualsDataSet = 0x2779;
        public readonly bool m_bUIWeapon = 0x277a;
        public readonly int m_nCustomEconReloadEventId = 0x277c;
        public readonly bool m_bCanBePickedUp = 0x2788;
        public readonly int m_nextPrevOwnerUseTime = 0x278c;
        public readonly CHandle m_hPrevOwner = 0x2790;
        public readonly int m_nDropTick = 0x2794;
        public readonly bool m_bWasActiveWeaponWhenDropped = 0x2798;
        public readonly int m_donated = 0x27bc;
        public readonly int m_fLastShotTime = 0x27c0;
        public readonly bool m_bWasOwnedByCT = 0x27c4;
        public readonly bool m_bWasOwnedByTerrorist = 0x27c5;
        public readonly float m_flNextClientFireBulletTime = 0x27c8;
        public readonly float m_flNextClientFireBulletTime_Repredict = 0x27cc;
        public readonly int m_IronSightController = 0x2820;
        public readonly int m_iIronSightMode = 0x28d0;
        public readonly float m_flLastLOSTraceFailureTime = 0x2948;
        public readonly float m_flWatTickOffset = 0x29a8;
        public readonly float m_flLastShakeTime = 0x29bc;
    }

    // Address: 0x4576d88
    public class C_WeaponTaser
    {
        // Fields (2):
        public readonly CHandle m_hCarriedHostage = 0x48;
        public readonly CHandle m_hCarriedHostageProp = 0x4c;
    }

    // Address: 0x4594f08
    public class C_WorldModelGloves
    {
        // Fields (8):
        public readonly Vector3 m_vecMoveDirEntitySpace = 0xf40;
        public readonly float m_flTargetSpeed = 0xf4c;
        public readonly int m_nTransitionStartTick = 0xf50;
        public readonly int m_nTransitionDurationTicks = 0xf54;
        public readonly float m_flTransitionStartSpeed = 0xf58;
        public readonly CHandle m_hConveyorModels = 0xf60;
        public readonly float m_flCurrentConveyorOffset = 0xf78;
        public readonly float m_flCurrentConveyorSpeed = 0xf7c;
    }

    // Address: 0x4540fe8
    public class C_fogplayerparams_t
    {
        // Fields (23):
        public readonly float m_flFrameRate = 0xf38;
        public readonly float m_flHDRColorScale = 0xf3c;
        public readonly float m_flFireTime = 0xf40;
        public readonly float m_flDamage = 0xf44;
        public readonly int m_nNumBeamEnts = 0xf48;
        public readonly QAngle m_queryHandleHalo = 0xf4c;
        public readonly CHandle m_hBaseMaterial = 0xf70;
        public readonly int m_nHaloIndex = 0xf78;
        public readonly int m_nBeamType = 0xf80;
        public readonly int m_nBeamFlags = 0xf84;
        public readonly CHandle m_hAttachEntity = 0xf88;
        public readonly int m_nAttachIndex = 0xfb0;
        public readonly int m_fWidth = 0xfbc;
        public readonly int m_fEndWidth = 0xfc0;
        public readonly int m_fFadeLength = 0xfc4;
        public readonly int m_fHaloScale = 0xfc8;
        public readonly int m_fAmplitude = 0xfcc;
        public readonly int m_fStartFrame = 0xfd0;
        public readonly int m_fSpeed = 0xfd4;
        public readonly float m_flFrame = 0xfd8;
        public readonly bool m_bTurnedOff = 0xfdc;
        public readonly Vector3 m_vecEndPos = 0xfe0;
        public readonly CHandle m_hEndEntity = 0xfec;
    }

    // Address: 0x4552348
    public class CanPlaySequence_t
    {
        // Fields (7):
        public readonly float m_flValues = 0x10;
        public readonly int m_nValueCounts = 0x110;
        public readonly int m_nBucketCount = 0x210;
        public readonly float m_flInterval = 0x214;
        public readonly float m_flFinalValue = 0x218;
        public readonly int m_nCompressionType = 0x21c;
        public readonly bool m_bStopped = 0x220;
    }

    // Address: 0x45b5050
    public class Catmull-Rom
    {
        // Fields (5):
        public readonly string m_skeleton = 0x0;
        public readonly string m_setID = 0x8;
        public readonly int m_channelSettings = 0x10;
        public readonly int m_compressedData = 0x28;
        public readonly int m_compressedOffsets = 0x40;
    }

    // Address: 0x45b4fb0
    public class Catmull-Rom (Norm X)
    {
        // Fields (9):
        public readonly int m_translationRangeX = 0x0;
        public readonly int m_translationRangeY = 0x8;
        public readonly int m_translationRangeZ = 0x10;
        public readonly string m_scaleRange = 0x18;
        public readonly int m_nTrackReadOffset = 0x20;
        public readonly int m_constantRotation = 0x30;
        public readonly bool m_bIsRotationStatic = 0x40;
        public readonly bool m_bIsTranslationStatic = 0x41;
        public readonly bool m_bIsScaleStatic = 0x42;
    }

    // Address: 0x4539b40
    public class ChangeFOV
    {
        // Fields (3):
        public readonly int m_fog = 0x780;
        public readonly bool m_bUseAngles = 0x7e8;
        public readonly int m_iChangedVariables = 0x7ec;
    }

    // Address: 0x4569128
    public class ChoreoStrafeMode_t
    {
        // Fields (12):
        public readonly bool m_bHasWarnedAI = 0x1108;
        public readonly bool m_bIsSmokeGrenade = 0x1109;
        public readonly bool m_bIsLive = 0x110a;
        public readonly int m_DmgRadius = 0x110c;
        public readonly float m_flDetonateTime = 0x1110;
        public readonly float m_flWarnAITime = 0x1114;
        public readonly float m_flDamage = 0x1118;
        public readonly int m_iszBounceSound = 0x1120;
        public readonly int m_ExplosionSound = 0x1128;
        public readonly CHandle m_hThrower = 0x1130;
        public readonly float m_flNextAttack = 0x1148;
        public readonly CHandle m_hOriginalThrower = 0x114c;
    }

    // Address: 0x45a2920
    public class Client Simulation
    {
        // Fields (20):
        public readonly float m_flFlexDelayTime = 0x1118;
        public readonly float m_flFlexDelayedWeight = 0x1120;
        public readonly bool m_bAttributesInitialized = 0x1128;
        public readonly int m_AttributeManager = 0x1130;
        public readonly int m_OriginalOwnerXuidLow = 0x2508;
        public readonly int m_OriginalOwnerXuidHigh = 0x250c;
        public readonly int m_nFallbackPaintKit = 0x2510;
        public readonly int m_nFallbackSeed = 0x2514;
        public readonly float m_flFallbackWear = 0x2518;
        public readonly int m_nFallbackStatTrak = 0x251c;
        public readonly bool m_bClientside = 0x2520;
        public readonly bool m_bParticleSystemsCreated = 0x2521;
        public readonly Vector3 m_vecAttachedParticles = 0x2528;
        public readonly CHandle m_hViewmodelAttachment = 0x2540;
        public readonly int m_iOldTeam = 0x2544;
        public readonly bool m_bAttachmentDirty = 0x2548;
        public readonly int m_nUnloadedModelIndex = 0x254c;
        public readonly int m_iNumOwnerValidationRetries = 0x2550;
        public readonly CHandle m_hOldProvidee = 0x2560;
        public readonly Vector3 m_vecAttachedModels = 0x2568;
    }

    // Address: 0x45c8b28
    public class Code
    {
        // Fields (5):
        public readonly int m_MethodName = 0x80;
        public readonly int m_Description = 0x90;
        public readonly bool m_bIsPublic = 0x98;
        public readonly int m_ReturnType = 0xa0;
        public readonly int m_Args = 0xb8;
    }

    // Address: 0x4526630
    public class Collision Wireframe
    {
        // Fields (30):
        public readonly bool m_bForceRecreateNextUpdate = 0xf70;
        public readonly bool m_bMoveViewToPlayerNextThink = 0xf71;
        public readonly bool m_bCheckCSSClasses = 0xf72;
        public readonly int m_anchorDeltaTransform = 0xf80;
        public readonly IntPtr m_pOffScreenIndicator = 0x1110;
        public readonly bool m_bIgnoreInput = 0x1138;
        public readonly bool m_bLit = 0x1139;
        public readonly bool m_bFollowPlayerAcrossTeleport = 0x113a;
        public readonly float m_flWidth = 0x113c;
        public readonly float m_flHeight = 0x1140;
        public readonly float m_flDPI = 0x1144;
        public readonly float m_flInteractDistance = 0x1148;
        public readonly float m_flDepthOffset = 0x114c;
        public readonly uint m_unOwnerContext = 0x1150;
        public readonly uint m_unHorizontalAlign = 0x1154;
        public readonly uint m_unVerticalAlign = 0x1158;
        public readonly uint m_unOrientation = 0x115c;
        public readonly bool m_bAllowInteractionFromAllSceneWorlds = 0x1160;
        public readonly Vector3 m_vecCSSClasses = 0x1168;
        public readonly bool m_bOpaque = 0x1180;
        public readonly bool m_bNoDepth = 0x1181;
        public readonly bool m_bVisibleWhenParentNoDraw = 0x1182;
        public readonly bool m_bRenderBackface = 0x1183;
        public readonly bool m_bUseOffScreenIndicator = 0x1184;
        public readonly bool m_bExcludeFromSaveGames = 0x1185;
        public readonly bool m_bGrabbable = 0x1186;
        public readonly bool m_bOnlyRenderToTexture = 0x1187;
        public readonly bool m_bDisableMipGen = 0x1188;
        public readonly int m_nExplicitImageLayout = 0x118c;
        public readonly bool m_bIgnoreParentOrientation = 0x1190;
    }

    // Address: 0x45c8c88
    public class Color
    {
        // Fields (3):
        public readonly int m_Outflows = 0xd8;
        public readonly bool m_bWaitForChildOutflows = 0xf0;
        public readonly int m_OnFinished = 0xf8;
    }

    // Address: 0x45c3028
    public class ConstantInfo_t
    {
        // Fields (9):
        public readonly int m_Name = 0x0;
        public readonly int m_Description = 0x10;
        public readonly int m_Type = 0x18;
        public readonly int m_DefaultValue = 0x30;
        public readonly int m_nKeysSource = 0x44;
        public readonly bool m_bIsPublicBlackboardVariable = 0x48;
        public readonly bool m_bIsObservable = 0x49;
        public readonly int m_nEditorNodeID = 0x4c;
        public readonly int m_Metadata = 0x50;
    }

    // Address: 0x45541f0
    public class CountdownTimer
    {
        // Fields (6):
        public readonly int m_vInTangentLocal = 0x77c;
        public readonly int m_vOutTangentLocal = 0x788;
        public readonly string m_strParentPathUniqueID = 0x798;
        public readonly string m_strPathNodeParameter = 0x7a0;
        public readonly int m_xWSPrevParent = 0x7b0;
        public readonly CHandle m_hPath = 0x7d0;
    }

    // Address: 0x454e0e0
    internal class Does not kill the entity when the part is destroyed
    {
        // Fields (7):
        public readonly int m_nDesyncOffset = 0x0;
        public readonly int m_nDistFadeStart = 0x10;
        public readonly int m_nDistFadeEnd = 0x12;
        public readonly int m_nAlpha = 0x17;
        public readonly float m_flFadeScale = 0x18;
        public readonly float m_flRenderFxStartTime = 0x1c;
        public readonly float m_flRenderFxDuration = 0x20;
    }

    // Address: 0x4575f30
    internal class In-Code weapon name
    {
        // Fields (13):
        public readonly bool m_bIronSightAvailable = 0x10;
        public readonly float m_flIronSightAmount = 0x14;
        public readonly float m_flIronSightAmountGained = 0x18;
        public readonly float m_flIronSightAmountBiased = 0x1c;
        public readonly float m_flIronSightAmount_Interpolated = 0x20;
        public readonly float m_flIronSightAmountGained_Interpolated = 0x24;
        public readonly float m_flIronSightAmountBiased_Interpolated = 0x28;
        public readonly float m_flInterpolationLastUpdated = 0x2c;
        public readonly QAngle m_angDeltaAverage = 0x30;
        public readonly QAngle m_angViewLast = 0x90;
        public readonly Vector3 m_vecDotCoords = 0x9c;
        public readonly float m_flFiringInaccuracyExtraWidthMultiplier = 0xa4;
        public readonly float m_flSpeedRatio = 0xa8;
    }

    // Address: 0x454e0c8
    internal class Kills and instantly removes the entity when the part is destroyed
    {
        // Fields (3):
        static readonly int s_movement_id = 0x0;
        static readonly int s_movement_serial_number = 0x8;
        static readonly int s_goal_source_location = 0x10;
    }

    // Address: 0x452ba40
    internal class baked_light_indexing
    {
        // Fields (2):
        public readonly IntPtr m_pSceneNode = 0x8;
        private readonly IntPtr __m_pChainEntity = 0x48;
    }

    // Address: 0x457a5c0
    internal class cs_player_controller
    {
        // Fields (4):
        public readonly int m_iAccount = 0x40;
        public readonly int m_iStartAccount = 0x44;
        public readonly int m_iTotalCashSpent = 0x48;
        public readonly int m_iCashSpentThisRound = 0x4c;
    }

    // Address: 0x45781f0
    internal class customplayer
    {
        // Fields (16):
        public readonly int m_currentMoveType = 0x10;
        public readonly int m_groundMoveState = 0x11;
        public readonly int m_groundActionDirection = 0x12;
        public readonly int m_airAction = 0x13;
        public readonly bool m_bWasOnGroundLastUpdate = 0x14;
        public readonly bool m_bWasStationaryLastUpdate = 0x15;
        public readonly int m_actionStartTick = 0x18;
        public readonly string m_staticAimTimerStartTick = 0x1c;
        public readonly IntPtr m_plantAndTurnStartTick = 0x20;
        public readonly float m_flTurnOnSpotAngle = 0x24;
        public readonly float m_flPreviousAimYaw = 0x28;
        public readonly float m_flPreviousHorizontalSpeed = 0x2c;
        public readonly float m_flFootIKOffsetLeft = 0x30;
        public readonly float m_flFootIKOffsetRight = 0x34;
        public readonly float m_flWeaponDropPercentageDueToMovement = 0x38;
        public readonly float m_flWeaponDropSmoothDampVelocity = 0x3c;
    }

    // Address: 0x452eda0
    internal class default_env_map
    {
        // Fields (12):
        public readonly int m_OnStartTouch = 0xf38;
        public readonly int m_OnStartTouchAll = 0xf50;
        public readonly int m_OnEndTouch = 0xf68;
        public readonly int m_OnEndTouchAll = 0xf80;
        public readonly int m_OnTouching = 0xf98;
        public readonly int m_OnTouchingEachEntity = 0xfb0;
        public readonly int m_OnNotTouching = 0xfc8;
        public readonly int m_OnTouchingChanged = 0xfe0;
        public readonly CHandle m_hTouchingEntities = 0xff8;
        public readonly int m_iFilterName = 0x1010;
        public readonly CHandle m_hFilter = 0x1018;
        public readonly bool m_bDisabled = 0x101c;
    }

    // Address: 0x45cd630
    internal class entity2
    {
        // Fields (8):
        public readonly int m_ModelName = 0x0;
        public readonly int m_nSequenceIndex = 0xe0;
        public readonly float m_flCycle = 0xe4;
        public readonly int m_KVModelStateChoices = 0xe8;
        public readonly bool m_bEnableChildModel = 0xf8;
        public readonly int m_ChildModelName = 0x100;
        public readonly Vector3 m_vecCompositeMaterialAssemblyProcedures = 0x1e0;
        public readonly Vector3 m_vecCompositeMaterials = 0x1f8;
    }

    // Address: 0x453efc0
    internal class entityIndexSelection
    {
        // Fields (11):
        public readonly string m_szParticlePrecipitationEffect = 0x28;
        public readonly string m_szParticlePrecipitationPuddleEffect = 0x108;
        public readonly string m_szParticlePrecipitationPostEffect = 0x1e8;
        public readonly float m_flInnerDistance = 0x2c8;
        public readonly int m_nAttachType = 0x2cc;
        public readonly bool m_bBatchSameVolumeType = 0x2d0;
        public readonly int m_nRTEnvCP = 0x2d4;
        public readonly int m_nRTEnvCPComponent = 0x2d8;
        public readonly string m_szModifier = 0x2e0;
        public readonly int m_nUseSnapshotFromSurfaceGraph = 0x2e8;
        public readonly string m_snapshotFilter = 0x2ec;
    }

    // Address: 0x4593a40
    internal class entityUseFastRefreshRate
    {
        // Fields (10):
        public readonly string m_szParentPathUniqueID = 0x780;
        public readonly int m_nPathIndex = 0x788;
        public readonly int m_vInTangentLocal = 0x78c;
        public readonly int m_vOutTangentLocal = 0x798;
        public readonly float m_flFOV = 0x7a4;
        public readonly float m_flCameraSpeed = 0x7a8;
        public readonly float m_flEaseIn = 0x7ac;
        public readonly float m_flEaseOut = 0x7b0;
        public readonly int m_vInTangentWorld = 0x7b4;
        public readonly int m_vOutTangentWorld = 0x7c0;
    }

    // Address: 0x4549420
    internal class entityflame
    {
        // Fields (29):
        public readonly int m_CPropDataComponent = 0x1140;
        public readonly int m_OnStartDeath = 0x1180;
        public readonly int m_OnBreak = 0x1198;
        public readonly int m_OnHealthChanged = 0x11b0;
        public readonly int m_OnTakeDamage = 0x11d0;
        public readonly int m_impactEnergyScale = 0x11e8;
        public readonly int m_iMinHealthDmg = 0x11ec;
        public readonly float m_flPressureDelay = 0x11f0;
        public readonly float m_flDefBurstScale = 0x11f4;
        public readonly int m_vDefBurstOffset = 0x11f8;
        public readonly CHandle m_hBreaker = 0x1204;
        public readonly int m_PerformanceMode = 0x1208;
        public readonly float m_flPreventDamageBeforeTime = 0x120c;
        public readonly int m_BreakableContentsType = 0x1210;
        public readonly string m_strBreakableContentsPropGroupOverride = 0x1218;
        public readonly string m_strBreakableContentsParticleOverride = 0x1220;
        public readonly bool m_bHasBreakPiecesOrCommands = 0x1228;
        public readonly int m_explodeDamage = 0x122c;
        public readonly int m_explodeRadius = 0x1230;
        public readonly string m_sExplosionType = 0x1238;
        public readonly int m_explosionDelay = 0x1240;
        public readonly int m_explosionBuildupSound = 0x1248;
        public readonly int m_explosionCustomEffect = 0x1250;
        public readonly int m_explosionCustomSound = 0x1258;
        public readonly int m_explosionModifier = 0x1260;
        public readonly CHandle m_hPhysicsAttacker = 0x1268;
        public readonly float m_flLastPhysicsInfluenceTime = 0x126c;
        public readonly float m_flDefaultFadeScale = 0x1270;
        public readonly CHandle m_hLastAttacker = 0x1274;
    }

    // Address: 0x4588668
    internal class entitytable_t
    {
        // Fields (43):
        public readonly bool m_bSpotLight = 0x10;
        public readonly int m_SpotLightOrigin = 0x14;
        public readonly int m_SpotLightAngles = 0x20;
        public readonly int m_ShadowDirection = 0x2c;
        public readonly int m_AmbientDirection = 0x38;
        public readonly int m_SpecularDirection = 0x44;
        public readonly int m_InspectorSpecularDirection = 0x50;
        public readonly float m_flSpecularPower = 0x5c;
        public readonly float m_flSpecularIndependence = 0x60;
        public readonly int m_SpecularColor = 0x64;
        public readonly bool m_bStartDisabled = 0x68;
        public readonly bool m_bEnabled = 0x69;
        public readonly int m_LightColor = 0x6a;
        public readonly int m_AmbientColor1 = 0x6e;
        public readonly int m_AmbientColor2 = 0x72;
        public readonly int m_AmbientColor3 = 0x76;
        public readonly float m_flSunDistance = 0x7c;
        public readonly float m_flFOV = 0x80;
        public readonly float m_flNearZ = 0x84;
        public readonly float m_flFarZ = 0x88;
        public readonly bool m_bEnableShadows = 0x8c;
        public readonly bool m_bOldEnableShadows = 0x8d;
        public readonly bool m_bBackgroundClearNotRequired = 0x8e;
        public readonly float m_flCloudScale = 0x90;
        public readonly float m_flCloud1Speed = 0x94;
        public readonly float m_flCloud1Direction = 0x98;
        public readonly float m_flCloud2Speed = 0x9c;
        public readonly float m_flCloud2Direction = 0xa0;
        public readonly float m_flAmbientScale1 = 0xb0;
        public readonly float m_flAmbientScale2 = 0xb4;
        public readonly float m_flGroundScale = 0xb8;
        public readonly float m_flLightScale = 0xbc;
        public readonly float m_flFoWDarkness = 0xc0;
        public readonly bool m_bEnableSeparateSkyboxFog = 0xc4;
        public readonly int m_vFowColor = 0xc8;
        public readonly int m_ViewOrigin = 0xd4;
        public readonly int m_ViewAngles = 0xe0;
        public readonly float m_flViewFoV = 0xec;
        public readonly int m_WorldPoints = 0xf0;
        public readonly int m_vFogOffsetLayer0 = 0x4a8;
        public readonly int m_vFogOffsetLayer1 = 0x4b0;
        public readonly CHandle m_hEnvWind = 0x4b8;
        public readonly CHandle m_hEnvSky = 0x4bc;
    }

    // Address: 0x452c6f0
    internal class fog_lighting
    {
        // Fields (18):
        public readonly int m_Entity_hCubemapTexture = 0x800;
        public readonly int m_Entity_bCustomCubemapTexture = 0x808;
        public readonly int m_Entity_flInfluenceRadius = 0x80c;
        public readonly int m_Entity_vBoxProjectMins = 0x810;
        public readonly int m_Entity_vBoxProjectMaxs = 0x81c;
        public readonly int m_Entity_bMoveable = 0x828;
        public readonly int m_Entity_nHandshake = 0x82c;
        public readonly int m_Entity_nEnvCubeMapArrayIndex = 0x830;
        public readonly int m_Entity_nPriority = 0x834;
        public readonly int m_Entity_flEdgeFadeDist = 0x838;
        public readonly int m_Entity_vEdgeFadeDists = 0x83c;
        public readonly int m_Entity_flDiffuseScale = 0x848;
        public readonly int m_Entity_bStartDisabled = 0x84c;
        public readonly int m_Entity_bDefaultEnvMap = 0x84d;
        public readonly int m_Entity_bDefaultSpecEnvMap = 0x84e;
        public readonly int m_Entity_bIndoorCubeMap = 0x84f;
        public readonly int m_Entity_bCopyDiffuseFromDefaultCubemap = 0x850;
        public readonly int m_Entity_bEnabled = 0x860;
    }

    // Address: 0x4566940
    internal class followup_entityiotarget
    {
        // Fields (8):
        public readonly int m_LoopState = 0x0;
        public readonly int m_nClientOutputFrames = 0x28;
        public readonly float m_flRealTime = 0x30;
        public readonly float m_flRenderTime = 0x38;
        public readonly float m_flRenderFrameTime = 0x40;
        public readonly float m_flRenderFrameTimeUnbounded = 0x48;
        public readonly float m_flRenderFrameTimeUnscaled = 0x50;
        public readonly float m_flTickRemainder = 0x58;
    }

    // Address: 0x4552608
    internal class globalentitydatabase_t
    {
        // Fields (2):
        public readonly int m_timestamp = 0x8;
        public readonly int m_nWorldGroupId = 0xc;
    }

    // Address: 0x453b020
    internal class info_world_layer
    {
        // Fields (2):
        public readonly string m_strMapToLoad = 0x0;
        public readonly string m_strLandmarkName = 0x8;
    }

    // Address: 0x456d108
    internal class last_match_max_players
    {
        // Fields (8):
        public readonly int m_nVariant = 0x77c;
        public readonly int m_nRandom = 0x780;
        public readonly int m_nOrdinal = 0x784;
        public readonly string m_sWeaponName = 0x788;
        public readonly int m_xuid = 0x790;
        public readonly int m_agentItem = 0x798;
        public readonly int m_glovesItem = 0x1b10;
        public readonly int m_weaponItem = 0x2e88;
    }

    // Address: 0x4530100
    internal class light_probe_atlas_z
    {
        // Fields (18):
        public readonly bool m_bActive = 0x77c;
        public readonly int m_vBoxMins = 0x780;
        public readonly int m_vBoxMaxs = 0x78c;
        public readonly bool m_bStartDisabled = 0x798;
        public readonly bool m_bIndirectUseLPVs = 0x799;
        public readonly float m_flStrength = 0x79c;
        public readonly int m_nFalloffShape = 0x7a0;
        public readonly float m_flFalloffExponent = 0x7a4;
        public readonly float m_flHeightFogDepth = 0x7a8;
        public readonly int m_fHeightFogEdgeWidth = 0x7ac;
        public readonly int m_fIndirectLightStrength = 0x7b0;
        public readonly int m_fSunLightStrength = 0x7b4;
        public readonly int m_fNoiseStrength = 0x7b8;
        public readonly int m_TintColor = 0x7bc;
        public readonly bool m_bOverrideTintColor = 0x7c0;
        public readonly bool m_bOverrideIndirectLightStrength = 0x7c1;
        public readonly bool m_bOverrideSunLightStrength = 0x7c2;
        public readonly bool m_bOverrideNoiseStrength = 0x7c3;
    }

    // Address: 0x45361a0
    internal class light_probe_size_x
    {
        // Fields (7):
        public readonly int m_iszSpawnTargetName = 0x780;
        public readonly CHandle m_hTarget = 0x788;
        public readonly bool m_bActive = 0x78c;
        public readonly int m_nGoalDirection = 0x790;
        public readonly int m_nConstraint = 0x794;
        public readonly float m_flMaxTurnRate = 0x798;
        public readonly float m_flLastGameTime = 0x79c;
    }

    // Address: 0x453a900
    internal class light_spot
    {
        // Fields (9):
        public readonly bool m_bActive = 0x77c;
        public readonly int m_vBoxMins = 0x780;
        public readonly int m_vBoxMaxs = 0x78c;
        public readonly bool m_bStartDisabled = 0x798;
        public readonly int m_nShape = 0x79c;
        public readonly int m_fWindSpeedMultiplier = 0x7a0;
        public readonly int m_fWindTurbulenceMultiplier = 0x7a4;
        public readonly int m_fWindSpeedVariationMultiplier = 0x7a8;
        public readonly int m_fWindDirectionVariationMultiplier = 0x7ac;
    }

    // Address: 0x452b340
    internal class lightcookie
    {
        // Fields (6):
        private readonly IntPtr __m_pChainEntity = 0x8;
        public readonly CHandle m_hOwner = 0x30;
        public readonly int m_nExernalChoreoGraphCount = 0x34;
        public readonly string m_sActiveExternalChoreoGraphSlotID = 0x38;
        public readonly int m_nNextSceneEventId = 0x70;
        public readonly float m_flAllowResponsesEndTime = 0x74;
    }

    // Address: 0x4535b10
    internal class lightprobetexture
    {
        // Fields (12):
        public readonly int m_iszWorldName = 0x780;
        public readonly int m_iszSource2EntityLumpName = 0x788;
        public readonly int m_iszEntityFilterName = 0x790;
        public readonly float m_flTimeoutInterval = 0x798;
        public readonly bool m_bAsynchronouslySpawnEntities = 0x79c;
        public readonly int m_clientOnlyEntityBehavior = 0x7a0;
        public readonly int m_ownerSpawnGroupType = 0x7a4;
        public readonly int m_createdSpawnGroupHandles = 0x7a8;
        public readonly int m_SpawnedEntityHandles = 0x7c0;
        public readonly int m_ScriptSpawnCallback = 0x7d8;
        public readonly int m_ScriptCallbackScope = 0x7e0;
        public readonly int m_OnEntitySpawned = 0x7e8;
    }

    // Address: 0x452f990
    internal class lightprobetexture_dli
    {
        // Fields (11):
        public readonly int m_EnvWindShared = 0x780;
        public readonly int m_fDirectionVariation = 0x878;
        public readonly int m_fSpeedVariation = 0x87c;
        public readonly int m_fTurbulence = 0x880;
        public readonly int m_fVolumeHalfExtentXY = 0x884;
        public readonly int m_fVolumeHalfExtentZ = 0x888;
        public readonly int m_nVolumeResolutionXY = 0x88c;
        public readonly int m_nVolumeResolutionZ = 0x890;
        public readonly int m_nClipmapLevels = 0x894;
        public readonly bool m_bIsMaster = 0x898;
        public readonly bool m_bFirstTime = 0x899;
    }

    // Address: 0x458b3f0
    internal class lightscale
    {
        // Fields (2):
        public readonly float m_flLightScale = 0xf38;
        public readonly int m_Radius = 0xf3c;
    }

    // Address: 0x453c778
    internal class locallightscale
    {
        // Fields (15):
        public readonly bool m_bClientSideOnly = 0x0;
        public readonly bool m_bStartOnSpawn = 0x77c;
        public readonly bool m_bToLocalPlayer = 0x77d;
        public readonly bool m_bStopOnNew = 0x77e;
        public readonly bool m_bSaveRestore = 0x77f;
        public readonly bool m_bSavedIsPlaying = 0x780;
        public readonly float m_flSavedElapsedTime = 0x784;
        public readonly int m_iszSourceEntityName = 0x788;
        public readonly int m_iszAttachmentName = 0x790;
        public readonly int m_onGUIDChanged = 0x798;
        public readonly int m_onSoundFinished = 0x7c8;
        public readonly float m_flClientCullRadius = 0x7e0;
        public readonly int m_iszSoundName = 0x810;
        public readonly CHandle m_hSource = 0x82c;
        public readonly int m_nEntityIndexSelection = 0x830;
    }

    // Address: 0x4553b80
    internal class m_FlashlightTexture
    {
        // Fields (9):
        public readonly int m_ragEnabled = 0x1108;
        public readonly int m_ragPos = 0x1120;
        public readonly int m_ragAngles = 0x1138;
        public readonly float m_flBlendWeight = 0x1150;
        public readonly CHandle m_hRagdollSource = 0x1154;
        public readonly int m_iEyeAttachment = 0x1158;
        public readonly float m_flBlendWeightCurrent = 0x115c;
        public readonly IntPtr m_parentPhysicsBoneIndices = 0x1160;
        public readonly int m_worldSpaceBoneComputationOrder = 0x1178;
    }

    // Address: 0x45418e0
    internal class m_bEligibleForScreenHighlight
    {
        // Fields (22):
        public readonly Vector3 m_vecDamageForce = 0x8;
        public readonly Vector3 m_vecDamagePosition = 0x14;
        public readonly Vector3 m_vecReportedPosition = 0x20;
        public readonly Vector3 m_vecDamageDirection = 0x2c;
        public readonly CHandle m_hInflictor = 0x38;
        public readonly CHandle m_hAttacker = 0x3c;
        public readonly CHandle m_hAbility = 0x40;
        public readonly float m_flDamage = 0x44;
        public readonly float m_flTotalledDamage = 0x48;
        public readonly bool m_bitsDamageType = 0x4c;
        public readonly int m_iDamageCustom = 0x50;
        public readonly int m_iAmmoType = 0x54;
        public readonly float m_flOriginalDamage = 0x60;
        public readonly bool m_bShouldBleed = 0x64;
        public readonly bool m_bShouldSpark = 0x65;
        public readonly int m_nDamageFlags = 0x70;
        public readonly int m_iHitGroupId = 0x78;
        public readonly int m_nNumObjectsPenetrated = 0x7c;
        public readonly float m_flFriendlyFireDamageReductionRatio = 0x80;
        public readonly bool m_bStoppedBullet = 0x84;
        public readonly int m_DestructibleHitGroupRequests = 0x100;
        public readonly bool m_bInTakeDamageFlow = 0x110;
    }

    // Address: 0x4551ea0
    internal class m_bFastRetrigger
    {
        // Fields (9):
        public readonly CHandle m_hDecalMaterial = 0xf38;
        public readonly float m_flWidth = 0xf40;
        public readonly float m_flHeight = 0xf44;
        public readonly float m_flDepth = 0xf48;
        public readonly int m_nRenderOrder = 0xf4c;
        public readonly bool m_bProjectOnWorld = 0xf50;
        public readonly bool m_bProjectOnCharacters = 0xf51;
        public readonly bool m_bProjectOnWater = 0xf52;
        public readonly float m_flDepthSortBias = 0xf54;
    }

    // Address: 0x45509a0
    internal class m_bMultiplayer
    {
        // Fields (26):
        public readonly bool m_bDirtyHierarchy = 0x0;
        public readonly int m_nodeToWorld = 0x10;
        public readonly IntPtr m_pOwner = 0x30;
        public readonly IntPtr m_pParent = 0x38;
        public readonly IntPtr m_pChild = 0x40;
        public readonly IntPtr m_pNextSibling = 0x48;
        public readonly CHandle m_hParent = 0x70;
        public readonly Vector3 m_vecOrigin = 0x80;
        public readonly QAngle m_angRotation = 0xb8;
        public readonly float m_flScale = 0xc4;
        public readonly Vector3 m_vecAbsOrigin = 0xc8;
        public readonly QAngle m_angAbsRotation = 0xd4;
        public readonly float m_flAbsScale = 0xe0;
        public readonly Vector3 m_vecWrappedLocalOrigin = 0xe4;
        public readonly QAngle m_angWrappedLocalRotation = 0xf0;
        public readonly float m_flWrappedScale = 0xfc;
        public readonly int m_nParentAttachmentOrBone = 0x100;
        public readonly bool m_bDebugAbsOriginChanges = 0x102;
        public readonly bool m_bDormant = 0x103;
        public readonly bool m_bForceParentToBeNetworked = 0x104;
        public readonly int m_nHierarchicalDepth = 0x107;
        public readonly int m_nHierarchyType = 0x108;
        public readonly int m_nDoNotSetAnimTimeInInvalidatePhysicsCount = 0x109;
        public readonly int m_name = 0x10c;
        public readonly CHandle m_hierarchyAttachName = 0x128;
        public readonly float m_flClientLocalScale = 0x12c;
    }

    // Address: 0x4594820
    internal class m_entitySpottedState
    {
        // Fields (23):
        public readonly int m_entitySpottedState = 0x1190;
        public readonly int m_leader = 0x11a8;
        public readonly int m_reuseTimer = 0x11b0;
        public readonly int m_vel = 0x11c8;
        public readonly int m_isRescued = 0x11d4;
        public readonly int m_jumpedThisFrame = 0x11d5;
        public readonly int m_nHostageState = 0x11d8;
        public readonly bool m_bHandsHaveBeenCut = 0x11dc;
        public readonly CHandle m_hHostageGrabber = 0x11e0;
        public readonly int m_fLastGrabTime = 0x11e4;
        public readonly Vector3 m_vecGrabbedPos = 0x11e8;
        public readonly float m_flRescueStartTime = 0x11f4;
        public readonly float m_flGrabSuccessTime = 0x11f8;
        public readonly float m_flDropStartTime = 0x11fc;
        public readonly float m_flDeadOrRescuedTime = 0x1200;
        public readonly bool m_blinkTimer = 0x1208;
        public readonly int m_lookAt = 0x1220;
        public readonly int m_lookAroundTimer = 0x1230;
        public readonly int m_isInit = 0x1248;
        public readonly int m_eyeAttachment = 0x1249;
        public readonly int m_chestAttachment = 0x124a;
        public readonly IntPtr m_pPredictionOwner = 0x1250;
        public readonly int m_fNewestAlphaThinkTime = 0x1258;
    }

    // Address: 0x45bc140
    internal class m_triggerMode
    {
        // Fields (3):
        public readonly int m_nInputValueNodeIdx = 0xa;
        public readonly int m_comparison = 0xc;
        public readonly int m_comparisionIDs = 0x10;
    }

    // Address: 0x45993e0
    internal class m_weaponCategory
    {
        // Fields (24):
        public readonly int m_nfxFireDamageEffect = 0xf78;
        public readonly CHandle m_hInfernoPointsSnapshot = 0xf80;
        public readonly CHandle m_hInfernoFillerPointsSnapshot = 0xf88;
        public readonly CHandle m_hInfernoOutlinePointsSnapshot = 0xf90;
        public readonly CHandle m_hInfernoClimbingOutlinePointsSnapshot = 0xf98;
        public readonly CHandle m_hInfernoDecalsSnapshot = 0xfa0;
        public readonly int m_firePositions = 0xfa8;
        public readonly int m_fireParentPositions = 0x12a8;
        public readonly bool m_bFireIsBurning = 0x15a8;
        public readonly int m_BurnNormal = 0x15e8;
        public readonly int m_fireCount = 0x18e8;
        public readonly int m_nInfernoType = 0x18ec;
        public readonly int m_nFireLifetime = 0x18f0;
        public readonly bool m_bInPostEffectTime = 0x18f4;
        public readonly int m_lastFireCount = 0x18f8;
        public readonly int m_nFireEffectTickBegin = 0x18fc;
        public readonly int m_drawableCount = 0x8500;
        public readonly bool m_blosCheck = 0x8504;
        public readonly int m_nlosperiod = 0x8508;
        public readonly int m_maxFireHalfWidth = 0x850c;
        public readonly int m_maxFireHeight = 0x8510;
        public readonly int m_minBounds = 0x8514;
        public readonly int m_maxBounds = 0x8520;
        public readonly float m_flLastGrassBurnThink = 0x852c;
    }

    // Address: 0x456f140
    internal class m_weaponItem
    {
        // Fields (10):
        public readonly int m_nSmokeEffectTickBegin = 0x1200;
        public readonly bool m_bDidSmokeEffect = 0x1204;
        public readonly int m_nRandomSeed = 0x1208;
        public readonly int m_vSmokeColor = 0x120c;
        public readonly int m_vSmokeDetonationPos = 0x1218;
        public readonly int m_VoxelFrameData = 0x1228;
        public readonly int m_nVoxelFrameDataSize = 0x1240;
        public readonly int m_nVoxelUpdate = 0x1244;
        public readonly bool m_bSmokeVolumeDataReceived = 0x1248;
        public readonly bool m_bSmokeEffectSpawned = 0x1249;
    }

    // Address: 0x4574e60
    internal class m_weaponMode
    {
        // Fields (2):
        public readonly int m_fFireTime = 0x2b8c;
        public readonly int m_nLastAttackTick = 0x2b90;
    }

    // Address: 0x4578540
    internal class m_weaponPurchases
    {
        // Fields (6):
        public readonly IntPtr m_predictableBaseTick = 0x48;
        public readonly IntPtr m_predictableBaseTickInterpAmount = 0x4c;
        public readonly IntPtr m_predictableBaseAngle = 0x50;
        public readonly IntPtr m_predictableBaseAngleVel = 0x5c;
        public readonly uint m_unpredictableBaseTick = 0xa0;
        public readonly uint m_unpredictableBaseAngle = 0xa4;
    }

    // Address: 0x4525fd0
    internal class melee_hit_player
    {
        // Fields (12):
        public readonly bool m_bDisabled = 0x77c;
        public readonly int m_nResolutionX = 0x780;
        public readonly int m_nResolutionY = 0x784;
        public readonly string m_szPanelType = 0x788;
        public readonly string m_szLayoutFileName = 0x790;
        public readonly int m_RenderAttrName = 0x798;
        public readonly int m_TargetEntities = 0x7a0;
        public readonly int m_nTargetChangeCount = 0x7b8;
        public readonly Vector3 m_vecCSSClasses = 0x7c0;
        public readonly string m_szTargetsName = 0x7d8;
        public readonly int m_AdditionalTargetEntities = 0x7e0;
        public readonly bool m_bCheckCSSClasses = 0x958;
    }

    // Address: 0x45a0ee0
    internal class player_ping_stop
    {
        // Fields (2):
        public readonly float m_flTracerDuration = 0xf50;
        public readonly int m_nType = 0xf54;
    }

    // Address: 0x4551a60
    internal class prop_dynamic_override
    {
        // Fields (13):
        public readonly bool m_bIsOn = 0x8;
        public readonly bool m_bMuzzleFlashEnabled = 0x18;
        public readonly float m_flMuzzleFlashBrightness = 0x1c;
        public readonly QAngle m_quatMuzzleFlashOrientation = 0x20;
        public readonly Vector3 m_vecMuzzleFlashOrigin = 0x30;
        public readonly float m_flFov = 0x3c;
        public readonly float m_flFarZ = 0x40;
        public readonly float m_flLinearAtten = 0x44;
        public readonly bool m_bCastsShadows = 0x48;
        public readonly float m_flCurrentPullBackDist = 0x4c;
        public readonly int m_FlashlightTexture = 0x50;
        public readonly int m_MuzzleFlashTexture = 0x58;
        public readonly int m_textureName = 0x60;
    }

    // Address: 0x456c328
    internal class total_kills_enemy_weapon
    {
        // Fields (98):
        public readonly bool m_bFreezePeriod = 0x39;
        public readonly bool m_bWarmupPeriod = 0x3a;
        public readonly int m_fWarmupPeriodEnd = 0x3c;
        public readonly int m_fWarmupPeriodStart = 0x40;
        public readonly bool m_bTerroristTimeOutActive = 0x44;
        public readonly bool m_bCTTimeOutActive = 0x45;
        public readonly float m_flTerroristTimeOutRemaining = 0x48;
        public readonly float m_flCTTimeOutRemaining = 0x4c;
        public readonly int m_nTerroristTimeOuts = 0x50;
        public readonly int m_nCTTimeOuts = 0x54;
        public readonly bool m_bTechnicalTimeOut = 0x58;
        public readonly bool m_bMatchWaitingForResume = 0x59;
        public readonly int m_iFreezeTime = 0x5c;
        public readonly int m_iRoundTime = 0x60;
        public readonly int m_fMatchStartTime = 0x64;
        public readonly int m_fRoundStartTime = 0x68;
        public readonly float m_flRestartRoundTime = 0x6c;
        public readonly bool m_bGameRestart = 0x70;
        public readonly float m_flGameStartTime = 0x74;
        public readonly int m_timeUntilNextPhaseStarts = 0x78;
        public readonly int m_gamePhase = 0x7c;
        public readonly int m_totalRoundsPlayed = 0x80;
        public readonly int m_nRoundsPlayedThisPhase = 0x84;
        public readonly int m_nOvertimePlaying = 0x88;
        public readonly int m_iHostagesRemaining = 0x8c;
        public readonly bool m_bAnyHostageReached = 0x90;
        public readonly bool m_bMapHasBombTarget = 0x91;
        public readonly bool m_bMapHasRescueZone = 0x92;
        public readonly bool m_bMapHasBuyZone = 0x93;
        public readonly bool m_bIsQueuedMatchmaking = 0x94;
        public readonly int m_nQueuedMatchmakingMode = 0x98;
        public readonly bool m_bIsValveDS = 0x9c;
        public readonly bool m_bLogoMap = 0x9d;
        public readonly bool m_bPlayAllStepSoundsOnServer = 0x9e;
        public readonly int m_iSpectatorSlotCount = 0xa0;
        public readonly int m_MatchDevice = 0xa4;
        public readonly bool m_bHasMatchStarted = 0xa8;
        public readonly int m_nNextMapInMapgroup = 0xac;
        public readonly string m_szTournamentEventName = 0xb0;
        public readonly string m_szTournamentEventStage = 0x2b0;
        public readonly string m_szMatchStatTxt = 0x4b0;
        public readonly string m_szTournamentPredictionsTxt = 0x6b0;
        public readonly int m_nTournamentPredictionsPct = 0x8b0;
        public readonly float m_flCMMItemDropRevealStartTime = 0x8b4;
        public readonly float m_flCMMItemDropRevealEndTime = 0x8b8;
        public readonly bool m_bIsDroppingItems = 0x8bc;
        public readonly bool m_bIsQuestEligible = 0x8bd;
        public readonly bool m_bIsHltvActive = 0x8be;
        public readonly bool m_bBombPlanted = 0x8bf;
        public readonly int m_arrProhibitedItemIndices = 0x8c0;
        public readonly int m_arrTournamentActiveCasterAccounts = 0x988;
        public readonly int m_numBestOfMaps = 0x998;
        public readonly int m_nHalloweenMaskListSeed = 0x99c;
        public readonly bool m_bBombDropped = 0x9a0;
        public readonly int m_iRoundWinStatus = 0x9a4;
        public readonly int m_eRoundWinReason = 0x9a8;
        public readonly bool m_bTCantBuy = 0x9ac;
        public readonly bool m_bCTCantBuy = 0x9ad;
        public readonly int m_iMatchStats_RoundResults = 0x9b0;
        public readonly int m_iMatchStats_PlayersAlive_CT = 0xa28;
        public readonly int m_iMatchStats_PlayersAlive_T = 0xaa0;
        public readonly int m_TeamRespawnWaveTimes = 0xb18;
        public readonly float m_flNextRespawnWave = 0xb98;
        public readonly int m_vMinimapMins = 0xc18;
        public readonly int m_vMinimapMaxs = 0xc24;
        public readonly int m_MinimapVerticalSectionHeights = 0xc30;
        public readonly uint m_ullLocalMatchID = 0xc50;
        public readonly int m_nEndMatchMapGroupVoteTypes = 0xc58;
        public readonly int m_nEndMatchMapGroupVoteOptions = 0xc80;
        public readonly int m_nEndMatchMapVoteWinner = 0xca8;
        public readonly int m_iNumConsecutiveCTLoses = 0xcac;
        public readonly int m_iNumConsecutiveTerroristLoses = 0xcb0;
        public readonly int m_nMatchAbortedEarlyReason = 0xd70;
        public readonly bool m_bHasTriggeredRoundStartMusic = 0xd74;
        public readonly bool m_bSwitchingTeamsAtRoundReset = 0xd75;
        public readonly IntPtr m_pGameModeRules = 0xd90;
        public readonly int m_RetakeRules = 0xd98;
        public readonly int m_nMatchEndCount = 0xef0;
        public readonly int m_nTTeamIntroVariant = 0xef4;
        public readonly int m_nCTTeamIntroVariant = 0xef8;
        public readonly bool m_bTeamIntroPeriod = 0xefc;
        public readonly int m_iRoundEndWinnerTeam = 0xf00;
        public readonly int m_eRoundEndReason = 0xf04;
        public readonly bool m_bRoundEndShowTimerDefend = 0xf08;
        public readonly int m_iRoundEndTimerTime = 0xf0c;
        public readonly string m_sRoundEndFunFactToken = 0xf10;
        public readonly int m_iRoundEndFunFactPlayerSlot = 0xf18;
        public readonly int m_iRoundEndFunFactData1 = 0xf1c;
        public readonly int m_iRoundEndFunFactData2 = 0xf20;
        public readonly int m_iRoundEndFunFactData3 = 0xf24;
        public readonly string m_sRoundEndMessage = 0xf28;
        public readonly int m_iRoundEndPlayerCount = 0xf30;
        public readonly bool m_bRoundEndNoMusic = 0xf34;
        public readonly int m_iRoundEndLegacy = 0xf38;
        public readonly int m_nRoundEndCount = 0xf3c;
        public readonly int m_iRoundStartRoundNumber = 0xf40;
        public readonly int m_nRoundStartCount = 0xf44;
        public readonly float m_flLastPerfSampleTime = 0x4f50;
    }

    // Address: 0x45748a0
    internal class weapon_famas
    {
        // Fields (10):
        public readonly int m_activeLightParticleIndex = 0x2b68;
        public readonly int m_eActiveLightEffect = 0x2b6c;
        public readonly bool m_bStartedArming = 0x2b70;
        public readonly int m_fArmedTime = 0x2b74;
        public readonly bool m_bBombPlacedAnimation = 0x2b78;
        public readonly bool m_bIsPlantingViaUse = 0x2b79;
        public readonly int m_entitySpottedState = 0x2b80;
        public readonly int m_nSpotRules = 0x2b98;
        public readonly bool m_bPlayedArmingBeeps = 0x2b9c;
        public readonly bool m_bBombPlanted = 0x2ba3;
    }

    // Address: 0x4596560
    internal class weapon_incgrenade
    {
        // Fields (4):
        public readonly int m_defaultAnim = 0x1108;
        public readonly int m_nDefaultAnimLoopMode = 0x1110;
        public readonly float m_flInitialModelScale = 0x1114;
        public readonly string m_sInitialWeaponState = 0x1118;
    }

    // Address: 0x45741a0
    internal class weapon_mac10_client
    {
        // Fields (2):
        public readonly int m_nKeychainDefID = 0x1110;
        public readonly int m_nKeychainSeed = 0x1114;
    }

    // Address: 0x45987c0
    internal class weapon_state
    {
        // Fields (15):
        public readonly int m_iBuyingStatus = 0x77c;
        public readonly float m_flBombRadius = 0x780;
        public readonly int m_iPetPopulation = 0x784;
        public readonly bool m_bUseNormalSpawnsForDM = 0x788;
        public readonly bool m_bDisableAutoGeneratedDMSpawns = 0x789;
        public readonly float m_flBotMaxVisionDistance = 0x78c;
        public readonly int m_iHostageCount = 0x790;
        public readonly bool m_bFadePlayerVisibilityFarZ = 0x794;
        public readonly bool m_bRainTraceToSkyEnabled = 0x795;
        public readonly bool m_bGPUCullSkybox = 0x796;
        public readonly float m_flEnvRainStrength = 0x798;
        public readonly float m_flEnvPuddleRippleStrength = 0x79c;
        public readonly float m_flEnvPuddleRippleDirection = 0x7a0;
        public readonly float m_flEnvWetnessCoverage = 0x7a4;
        public readonly float m_flEnvWetnessDryingAmount = 0x7a8;
    }

}
