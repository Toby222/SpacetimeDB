﻿//HintName: Timers.SendScheduledMessage.cs
// <auto-generated />
#nullable enable

partial class Timers
{
    [System.Diagnostics.CodeAnalysis.Experimental("STDB_UNSTABLE")]
    public static void VolatileNonatomicScheduleImmediateSendScheduledMessage(
        Timers.SendMessageTimer arg
    )
    {
        using var stream = new MemoryStream();
        using var writer = new BinaryWriter(stream);
        new Timers.SendMessageTimer.BSATN().Write(writer, arg);
        SpacetimeDB.Internal.IReducer.VolatileNonatomicScheduleImmediate(
            nameof(SendScheduledMessage),
            stream
        );
    }
} // Timers
