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

public partial class CBaseAnimGraphController : CSkeletonAnimationController
{
    public CBaseAnimGraphController (IntPtr pointer) : base(pointer) {}

	// m_animGraphNetworkedVars
	[SchemaMember("CBaseAnimGraphController", "m_animGraphNetworkedVars")]
	public CAnimGraphNetworkedVariables AnimGraphNetworkedVars => Schema.GetDeclaredClass<CAnimGraphNetworkedVariables>(this.Handle, "CBaseAnimGraphController", "m_animGraphNetworkedVars");

	// m_bSequenceFinished
	[SchemaMember("CBaseAnimGraphController", "m_bSequenceFinished")]
	public ref bool SequenceFinished => ref Schema.GetRef<bool>(this.Handle, "CBaseAnimGraphController", "m_bSequenceFinished");

	// m_flSoundSyncTime
	[SchemaMember("CBaseAnimGraphController", "m_flSoundSyncTime")]
	public ref float SoundSyncTime => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flSoundSyncTime");

	// m_nActiveIKChainMask
	[SchemaMember("CBaseAnimGraphController", "m_nActiveIKChainMask")]
	public ref UInt32 ActiveIKChainMask => ref Schema.GetRef<UInt32>(this.Handle, "CBaseAnimGraphController", "m_nActiveIKChainMask");

	// m_hSequence
	[SchemaMember("CBaseAnimGraphController", "m_hSequence")]
	public ref Int32 Sequence => ref Schema.GetRef<Int32>(this.Handle, "CBaseAnimGraphController", "m_hSequence");

	// m_flSeqStartTime
	[SchemaMember("CBaseAnimGraphController", "m_flSeqStartTime")]
	public ref float SeqStartTime => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flSeqStartTime");

	// m_flSeqFixedCycle
	[SchemaMember("CBaseAnimGraphController", "m_flSeqFixedCycle")]
	public ref float SeqFixedCycle => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flSeqFixedCycle");

	// m_nAnimLoopMode
	[SchemaMember("CBaseAnimGraphController", "m_nAnimLoopMode")]
	public ref AnimLoopMode_t AnimLoopMode => ref Schema.GetRef<AnimLoopMode_t>(this.Handle, "CBaseAnimGraphController", "m_nAnimLoopMode");

	// m_flPlaybackRate
	[SchemaMember("CBaseAnimGraphController", "m_flPlaybackRate")]
	public ref float PlaybackRate => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flPlaybackRate");

	// m_nNotifyState
	[SchemaMember("CBaseAnimGraphController", "m_nNotifyState")]
	public ref SequenceFinishNotifyState_t NotifyState => ref Schema.GetRef<SequenceFinishNotifyState_t>(this.Handle, "CBaseAnimGraphController", "m_nNotifyState");

	// m_bNetworkedAnimationInputsChanged
	[SchemaMember("CBaseAnimGraphController", "m_bNetworkedAnimationInputsChanged")]
	public ref bool NetworkedAnimationInputsChanged => ref Schema.GetRef<bool>(this.Handle, "CBaseAnimGraphController", "m_bNetworkedAnimationInputsChanged");

	// m_bNetworkedSequenceChanged
	[SchemaMember("CBaseAnimGraphController", "m_bNetworkedSequenceChanged")]
	public ref bool NetworkedSequenceChanged => ref Schema.GetRef<bool>(this.Handle, "CBaseAnimGraphController", "m_bNetworkedSequenceChanged");

	// m_bLastUpdateSkipped
	[SchemaMember("CBaseAnimGraphController", "m_bLastUpdateSkipped")]
	public ref bool LastUpdateSkipped => ref Schema.GetRef<bool>(this.Handle, "CBaseAnimGraphController", "m_bLastUpdateSkipped");

	// m_flPrevAnimUpdateTime
	[SchemaMember("CBaseAnimGraphController", "m_flPrevAnimUpdateTime")]
	public ref float PrevAnimUpdateTime => ref Schema.GetRef<float>(this.Handle, "CBaseAnimGraphController", "m_flPrevAnimUpdateTime");

}
