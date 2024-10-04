// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CBaseEntity : CEntityInstance
{
    public CBaseEntity (IntPtr pointer) : base(pointer) {}

	// m_CBodyComponent
	[SchemaMember("CBaseEntity", "m_CBodyComponent")]
	public CBodyComponent? CBodyComponent => Schema.GetPointer<CBodyComponent>(this.Handle, "CBaseEntity", "m_CBodyComponent");

	// m_NetworkTransmitComponent
	[SchemaMember("CBaseEntity", "m_NetworkTransmitComponent")]
	public CNetworkTransmitComponent NetworkTransmitComponent => Schema.GetDeclaredClass<CNetworkTransmitComponent>(this.Handle, "CBaseEntity", "m_NetworkTransmitComponent");

	// m_aThinkFunctions
	[SchemaMember("CBaseEntity", "m_aThinkFunctions")]
	public NetworkedVector<thinkfunc_t> ThinkFunctions => Schema.GetDeclaredClass<NetworkedVector<thinkfunc_t>>(this.Handle, "CBaseEntity", "m_aThinkFunctions");

	// m_iCurrentThinkContext
	[SchemaMember("CBaseEntity", "m_iCurrentThinkContext")]
	public ref Int32 CurrentThinkContext => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_iCurrentThinkContext");

	// m_nLastThinkTick
	[SchemaMember("CBaseEntity", "m_nLastThinkTick")]
	public ref Int32 LastThinkTick => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_nLastThinkTick");

	// m_bDisabledContextThinks
	[SchemaMember("CBaseEntity", "m_bDisabledContextThinks")]
	public ref bool DisabledContextThinks => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bDisabledContextThinks");

	// m_isSteadyState
	[SchemaMember("CBaseEntity", "m_isSteadyState")]
	public Span<byte> IsSteadyState => Schema.GetFixedArray<byte>(this.Handle, "CBaseEntity", "m_isSteadyState", 8);

	// m_lastNetworkChange
	[SchemaMember("CBaseEntity", "m_lastNetworkChange")]
	public ref float LastNetworkChange => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_lastNetworkChange");

	// m_ResponseContexts
	[SchemaMember("CBaseEntity", "m_ResponseContexts")]
	public NetworkedVector<ResponseContext_t> ResponseContexts => Schema.GetDeclaredClass<NetworkedVector<ResponseContext_t>>(this.Handle, "CBaseEntity", "m_ResponseContexts");

	// m_iszResponseContext
	[SchemaMember("CBaseEntity", "m_iszResponseContext")]
	public string ResponseContext
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseEntity", "m_iszResponseContext"); }
		set { Schema.SetString(this.Handle, "CBaseEntity", "m_iszResponseContext", value); }
	}

	// m_iHealth
	[SchemaMember("CBaseEntity", "m_iHealth")]
	public ref Int32 Health => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_iHealth");

	// m_iMaxHealth
	[SchemaMember("CBaseEntity", "m_iMaxHealth")]
	public ref Int32 MaxHealth => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_iMaxHealth");

	// m_lifeState
	[SchemaMember("CBaseEntity", "m_lifeState")]
	public ref byte LifeState => ref Schema.GetRef<byte>(this.Handle, "CBaseEntity", "m_lifeState");

	// m_flDamageAccumulator
	[SchemaMember("CBaseEntity", "m_flDamageAccumulator")]
	public ref float DamageAccumulator => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flDamageAccumulator");

	// m_bTakesDamage
	[SchemaMember("CBaseEntity", "m_bTakesDamage")]
	public ref bool TakesDamage => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bTakesDamage");

	// m_nTakeDamageFlags
	[SchemaMember("CBaseEntity", "m_nTakeDamageFlags")]
	public ref TakeDamageFlags_t TakeDamageFlags => ref Schema.GetRef<TakeDamageFlags_t>(this.Handle, "CBaseEntity", "m_nTakeDamageFlags");

	// m_nPlatformType
	[SchemaMember("CBaseEntity", "m_nPlatformType")]
	public ref EntityPlatformTypes_t PlatformType => ref Schema.GetRef<EntityPlatformTypes_t>(this.Handle, "CBaseEntity", "m_nPlatformType");

	// m_MoveCollide
	[SchemaMember("CBaseEntity", "m_MoveCollide")]
	public ref MoveCollide_t MoveCollide => ref Schema.GetRef<MoveCollide_t>(this.Handle, "CBaseEntity", "m_MoveCollide");

	// m_MoveType
	[SchemaMember("CBaseEntity", "m_MoveType")]
	public ref MoveType_t MoveType => ref Schema.GetRef<MoveType_t>(this.Handle, "CBaseEntity", "m_MoveType");

	// m_nActualMoveType
	[SchemaMember("CBaseEntity", "m_nActualMoveType")]
	public ref MoveType_t ActualMoveType => ref Schema.GetRef<MoveType_t>(this.Handle, "CBaseEntity", "m_nActualMoveType");

	// m_nWaterTouch
	[SchemaMember("CBaseEntity", "m_nWaterTouch")]
	public ref byte WaterTouch => ref Schema.GetRef<byte>(this.Handle, "CBaseEntity", "m_nWaterTouch");

	// m_nSlimeTouch
	[SchemaMember("CBaseEntity", "m_nSlimeTouch")]
	public ref byte SlimeTouch => ref Schema.GetRef<byte>(this.Handle, "CBaseEntity", "m_nSlimeTouch");

	// m_bRestoreInHierarchy
	[SchemaMember("CBaseEntity", "m_bRestoreInHierarchy")]
	public ref bool RestoreInHierarchy => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bRestoreInHierarchy");

	// m_target
	[SchemaMember("CBaseEntity", "m_target")]
	public string Target
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseEntity", "m_target"); }
		set { Schema.SetString(this.Handle, "CBaseEntity", "m_target", value); }
	}

	// m_hDamageFilter
	[SchemaMember("CBaseEntity", "m_hDamageFilter")]
	public CHandle<CBaseFilter> DamageFilter => Schema.GetDeclaredClass<CHandle<CBaseFilter>>(this.Handle, "CBaseEntity", "m_hDamageFilter");

	// m_iszDamageFilterName
	[SchemaMember("CBaseEntity", "m_iszDamageFilterName")]
	public string DamageFilterName
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseEntity", "m_iszDamageFilterName"); }
		set { Schema.SetString(this.Handle, "CBaseEntity", "m_iszDamageFilterName", value); }
	}

	// m_flMoveDoneTime
	[SchemaMember("CBaseEntity", "m_flMoveDoneTime")]
	public ref float MoveDoneTime => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flMoveDoneTime");

	// m_nSubclassID
	[SchemaMember("CBaseEntity", "m_nSubclassID")]
	public CUtlStringToken SubclassID => Schema.GetDeclaredClass<CUtlStringToken>(this.Handle, "CBaseEntity", "m_nSubclassID");

	// m_flAnimTime
	[SchemaMember("CBaseEntity", "m_flAnimTime")]
	public ref float AnimTime => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flAnimTime");

	// m_flSimulationTime
	[SchemaMember("CBaseEntity", "m_flSimulationTime")]
	public ref float SimulationTime => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flSimulationTime");

	// m_flCreateTime
	[SchemaMember("CBaseEntity", "m_flCreateTime")]
	public ref float CreateTime => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flCreateTime");

	// m_bClientSideRagdoll
	[SchemaMember("CBaseEntity", "m_bClientSideRagdoll")]
	public ref bool ClientSideRagdoll => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bClientSideRagdoll");

	// m_ubInterpolationFrame
	[SchemaMember("CBaseEntity", "m_ubInterpolationFrame")]
	public ref byte InterpolationFrame => ref Schema.GetRef<byte>(this.Handle, "CBaseEntity", "m_ubInterpolationFrame");

	// m_vPrevVPhysicsUpdatePos
	[SchemaMember("CBaseEntity", "m_vPrevVPhysicsUpdatePos")]
	public Vector PrevVPhysicsUpdatePos => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseEntity", "m_vPrevVPhysicsUpdatePos");

	// m_iTeamNum
	[SchemaMember("CBaseEntity", "m_iTeamNum")]
	public ref byte TeamNum => ref Schema.GetRef<byte>(this.Handle, "CBaseEntity", "m_iTeamNum");

	// m_iGlobalname
	[SchemaMember("CBaseEntity", "m_iGlobalname")]
	public string Globalname
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseEntity", "m_iGlobalname"); }
		set { Schema.SetString(this.Handle, "CBaseEntity", "m_iGlobalname", value); }
	}

	// m_iSentToClients
	[SchemaMember("CBaseEntity", "m_iSentToClients")]
	public ref Int32 SentToClients => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_iSentToClients");

	// m_flSpeed
	[SchemaMember("CBaseEntity", "m_flSpeed")]
	public ref float Speed => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flSpeed");

	// m_sUniqueHammerID
	[SchemaMember("CBaseEntity", "m_sUniqueHammerID")]
	public string UniqueHammerID
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseEntity", "m_sUniqueHammerID"); }
		set { Schema.SetString(this.Handle, "CBaseEntity", "m_sUniqueHammerID", value); }
	}

	// m_spawnflags
	[SchemaMember("CBaseEntity", "m_spawnflags")]
	public ref UInt32 Spawnflags => ref Schema.GetRef<UInt32>(this.Handle, "CBaseEntity", "m_spawnflags");

	// m_nNextThinkTick
	[SchemaMember("CBaseEntity", "m_nNextThinkTick")]
	public ref Int32 NextThinkTick => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_nNextThinkTick");

	// m_nSimulationTick
	[SchemaMember("CBaseEntity", "m_nSimulationTick")]
	public ref Int32 SimulationTick => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_nSimulationTick");

	// m_OnKilled
	[SchemaMember("CBaseEntity", "m_OnKilled")]
	public CEntityIOOutput OnKilled => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseEntity", "m_OnKilled");

	// m_fFlags
	[SchemaMember("CBaseEntity", "m_fFlags")]
	public ref UInt32 Flags => ref Schema.GetRef<UInt32>(this.Handle, "CBaseEntity", "m_fFlags");

	// m_vecAbsVelocity
	[SchemaMember("CBaseEntity", "m_vecAbsVelocity")]
	public Vector AbsVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseEntity", "m_vecAbsVelocity");

	// m_vecVelocity
	[SchemaMember("CBaseEntity", "m_vecVelocity")]
	public CNetworkVelocityVector Velocity => Schema.GetDeclaredClass<CNetworkVelocityVector>(this.Handle, "CBaseEntity", "m_vecVelocity");

	// m_vecBaseVelocity
	[SchemaMember("CBaseEntity", "m_vecBaseVelocity")]
	public Vector BaseVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CBaseEntity", "m_vecBaseVelocity");

	// m_nPushEnumCount
	[SchemaMember("CBaseEntity", "m_nPushEnumCount")]
	public ref Int32 PushEnumCount => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_nPushEnumCount");

	// m_pCollision
	[SchemaMember("CBaseEntity", "m_pCollision")]
	public CCollisionProperty? Collision => Schema.GetPointer<CCollisionProperty>(this.Handle, "CBaseEntity", "m_pCollision");

	// m_hEffectEntity
	[SchemaMember("CBaseEntity", "m_hEffectEntity")]
	public CHandle<CBaseEntity> EffectEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CBaseEntity", "m_hEffectEntity");

	// m_hOwnerEntity
	[SchemaMember("CBaseEntity", "m_hOwnerEntity")]
	public CHandle<CBaseEntity> OwnerEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CBaseEntity", "m_hOwnerEntity");

	// m_fEffects
	[SchemaMember("CBaseEntity", "m_fEffects")]
	public ref UInt32 Effects => ref Schema.GetRef<UInt32>(this.Handle, "CBaseEntity", "m_fEffects");

	// m_hGroundEntity
	[SchemaMember("CBaseEntity", "m_hGroundEntity")]
	public CHandle<CBaseEntity> GroundEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CBaseEntity", "m_hGroundEntity");

	// m_nGroundBodyIndex
	[SchemaMember("CBaseEntity", "m_nGroundBodyIndex")]
	public ref Int32 GroundBodyIndex => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_nGroundBodyIndex");

	// m_flFriction
	[SchemaMember("CBaseEntity", "m_flFriction")]
	public ref float Friction => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flFriction");

	// m_flElasticity
	[SchemaMember("CBaseEntity", "m_flElasticity")]
	public ref float Elasticity => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flElasticity");

	// m_flGravityScale
	[SchemaMember("CBaseEntity", "m_flGravityScale")]
	public ref float GravityScale => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flGravityScale");

	// m_flTimeScale
	[SchemaMember("CBaseEntity", "m_flTimeScale")]
	public ref float TimeScale => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flTimeScale");

	// m_flWaterLevel
	[SchemaMember("CBaseEntity", "m_flWaterLevel")]
	public ref float WaterLevel => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flWaterLevel");

	// m_bAnimatedEveryTick
	[SchemaMember("CBaseEntity", "m_bAnimatedEveryTick")]
	public ref bool AnimatedEveryTick => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bAnimatedEveryTick");

	// m_bDisableLowViolence
	[SchemaMember("CBaseEntity", "m_bDisableLowViolence")]
	public ref bool DisableLowViolence => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bDisableLowViolence");

	// m_nWaterType
	[SchemaMember("CBaseEntity", "m_nWaterType")]
	public ref byte WaterType => ref Schema.GetRef<byte>(this.Handle, "CBaseEntity", "m_nWaterType");

	// m_iEFlags
	[SchemaMember("CBaseEntity", "m_iEFlags")]
	public ref Int32 EFlags => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_iEFlags");

	// m_OnUser1
	[SchemaMember("CBaseEntity", "m_OnUser1")]
	public CEntityIOOutput OnUser1 => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseEntity", "m_OnUser1");

	// m_OnUser2
	[SchemaMember("CBaseEntity", "m_OnUser2")]
	public CEntityIOOutput OnUser2 => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseEntity", "m_OnUser2");

	// m_OnUser3
	[SchemaMember("CBaseEntity", "m_OnUser3")]
	public CEntityIOOutput OnUser3 => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseEntity", "m_OnUser3");

	// m_OnUser4
	[SchemaMember("CBaseEntity", "m_OnUser4")]
	public CEntityIOOutput OnUser4 => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseEntity", "m_OnUser4");

	// m_iInitialTeamNum
	[SchemaMember("CBaseEntity", "m_iInitialTeamNum")]
	public ref Int32 InitialTeamNum => ref Schema.GetRef<Int32>(this.Handle, "CBaseEntity", "m_iInitialTeamNum");

	// m_flNavIgnoreUntilTime
	[SchemaMember("CBaseEntity", "m_flNavIgnoreUntilTime")]
	public ref float NavIgnoreUntilTime => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flNavIgnoreUntilTime");

	// m_vecAngVelocity
	[SchemaMember("CBaseEntity", "m_vecAngVelocity")]
	public QAngle AngVelocity => Schema.GetDeclaredClass<QAngle>(this.Handle, "CBaseEntity", "m_vecAngVelocity");

	// m_bNetworkQuantizeOriginAndAngles
	[SchemaMember("CBaseEntity", "m_bNetworkQuantizeOriginAndAngles")]
	public ref bool NetworkQuantizeOriginAndAngles => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bNetworkQuantizeOriginAndAngles");

	// m_bLagCompensate
	[SchemaMember("CBaseEntity", "m_bLagCompensate")]
	public ref bool LagCompensate => ref Schema.GetRef<bool>(this.Handle, "CBaseEntity", "m_bLagCompensate");

	// m_flOverriddenFriction
	[SchemaMember("CBaseEntity", "m_flOverriddenFriction")]
	public ref float OverriddenFriction => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flOverriddenFriction");

	// m_pBlocker
	[SchemaMember("CBaseEntity", "m_pBlocker")]
	public CHandle<CBaseEntity> Blocker => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CBaseEntity", "m_pBlocker");

	// m_flLocalTime
	[SchemaMember("CBaseEntity", "m_flLocalTime")]
	public ref float LocalTime => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flLocalTime");

	// m_flVPhysicsUpdateLocalTime
	[SchemaMember("CBaseEntity", "m_flVPhysicsUpdateLocalTime")]
	public ref float VPhysicsUpdateLocalTime => ref Schema.GetRef<float>(this.Handle, "CBaseEntity", "m_flVPhysicsUpdateLocalTime");

	// m_nBloodType
	[SchemaMember("CBaseEntity", "m_nBloodType")]
	public ref BloodType BloodType => ref Schema.GetRef<BloodType>(this.Handle, "CBaseEntity", "m_nBloodType");

}
