// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;

namespace CounterStrikeSharp.API.Core;

public enum NmEventConditionRules_t : byte
{
	LimitSearchToSourceState = 0x0,
	IgnoreInactiveEvents = 0x1,
	PreferHighestWeight = 0x2,
	PreferHighestProgress = 0x3,
	OperatorOr = 0x4,
	OperatorAnd = 0x5,
	SearchOnlyStateEvents = 0x6,
	SearchOnlyAnimEvents = 0x7,
	SearchBothStateAndAnimEvents = 0x8,
}
