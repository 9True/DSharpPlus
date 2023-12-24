// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using DSharpPlus.Core.Abstractions.Models;
using DSharpPlus.Core.Abstractions.Rest.Payloads;

using Remora.Results;

namespace DSharpPlus.Core.Abstractions.Rest.API;

/// <summary>
/// Provides access to guild-scheduled-event-related rest API calls.
/// </summary>
public interface IGuildScheduledEventRestAPI
{
    /// <summary>
    /// Returns a list of scheduled events taking place in this guild.
    /// </summary>
    /// <param name="guildId">The snowflake identifier of the guild in question.</param>
    /// <param name="withUserCount">Whether the answer should include user counts.</param>
    /// <param name="ct">Cancellation token for this request.</param>
    public ValueTask<Result<IReadOnlyList<IScheduledEvent>>> ListScheduledEventsForGuildAsync
    (
        Snowflake guildId,
        bool? withUserCount = null,
        CancellationToken ct = default
    );

    /// <summary>
    /// Creates a new scheduled event in the specified guild.
    /// </summary>
    /// <param name="guildId">The snowflake identifier of the guild in question.</param>
    /// <param name="payload">The data to intialize the event with.</param>
    /// <param name="reason">An optional audit log reason</param>
    /// <param name="ct">Cancellation token for this request.</param>
    /// <returns>The newly created scheduled event.</returns>
    public ValueTask<Result<IScheduledEvent>> CreateGuildScheduledEventAsync
    (
        Snowflake guildId,
        ICreateGuildScheduledEventPayload payload,
        string? reason = null,
        CancellationToken ct = default
    );

    /// <summary>
    /// Returns the requested scheduled event.
    /// </summary>
    /// <param name="guildId">The snowflake identifier of the guild this scheduled event takes place in.</param>
    /// <param name="eventId">The snowflake identifier of the scheduled event in qeustion.</param>
    /// <param name="withUserCount">
    /// Specifies whether the number of users subscribed to this event should be included.
    /// </param>
    /// <param name="ct">Cancellation token for this request.</param>
    public ValueTask<Result<IScheduledEvent>> GetScheduledEventAsync
    (
        Snowflake guildId,
        Snowflake eventId,
        bool? withUserCount = null,
        CancellationToken ct = default
    );

    /// <summary>
    /// Modifies the given scheduled event.
    /// </summary>
    /// <param name="guildId">The snowflake identifier of the guild this event takes place in.</param>
    /// <param name="eventId">The snowflake identifier of the event to be modified.</param>
    /// <param name="payload">The new information for this event.</param>
    /// <param name="reason">An optional audit log reason.</param>
    /// <param name="ct">Cancellation token for this request.</param>
    /// <returns>The newly modified scheduled event.</returns>
    public ValueTask<Result<IScheduledEvent>> ModifyScheduledEventAsync
    (
        Snowflake guildId,
        Snowflake eventId,
        IModifyGuildScheduledEventPayload payload,
        string? reason = null,
        CancellationToken ct = default
    );

    /// <summary>
    /// Deletes the given scheduled event.
    /// </summary>
    /// <param name="guildId">The snowflake identifier of the guild this event takes place in.</param>
    /// <param name="eventId">The snowflake identifier of the event to be modified.</param>
    /// <param name="ct">Cancellation token for this request.</param>
    /// <returns>Whether the deletion was successful.</returns>
    public ValueTask<Result> DeleteScheduledEventAsync
    (
        Snowflake guildId,
        Snowflake eventId,
        CancellationToken ct = default
    );

    /// <summary>
    /// Returns <seealso cref="IScheduledEventUser"/> objects for each participant of the given scheduled event.
    /// </summary>
    /// <param name="guildId">The snowflake identifier of the guild this scheduled event belongs to.</param>
    /// <param name="eventId">The snowflake identifier of the scheduled event in question.</param>
    /// <param name="limit">Number of users to return.</param>
    /// <param name="withMember">Specifies whether the response should include guild member data.</param>
    /// <param name="before">Only return users before the given snowflake ID, used for pagination.</param>
    /// <param name="after">Only return users after the given snowflake ID, used for pagination.</param>
    /// <param name="ct">Cancellation token for this request.</param>
    public ValueTask<Result<IReadOnlyList<IScheduledEventUser>>> GetScheduledEventUsersAsync
    (
        Snowflake guildId,
        Snowflake eventId,
        int? limit = null,
        bool? withMember = null,
        Snowflake? before = null,
        Snowflake? after = null,
        CancellationToken ct = default
    );
}
