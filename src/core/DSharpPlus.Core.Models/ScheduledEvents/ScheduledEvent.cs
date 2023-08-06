// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using DSharpPlus.Entities;

using Remora.Rest.Core;
using System;

using DSharpPlus.Core.Abstractions.Models;

namespace DSharpPlus.Core.Models;

/// <inheritdoc cref="IScheduledEvent" />
public sealed record ScheduledEvent : IScheduledEvent
{
    /// <inheritdoc/>
    public required Snowflake Id { get; init; }

    /// <inheritdoc/>
    public required Snowflake GuildId { get; init; }

    /// <inheritdoc/>
    public required Snowflake ChannelId { get; init; }

    /// <inheritdoc/>
    public Optional<Snowflake> CreatorId { get; init; }

    /// <inheritdoc/>
    public required string Name { get; init; }

    /// <inheritdoc/>
    public Optional<string?> Description { get; init; }

    /// <inheritdoc/>
    public required DateTimeOffset ScheduledStartTime { get; init; }

    /// <inheritdoc/>
    public required DiscordScheduledEventPrivacyLevel PrivacyLevel { get; init; }

    /// <inheritdoc/>
    public required DiscordScheduledEventStatus Status { get; init; }

    /// <inheritdoc/>
    public required DiscordScheduledEventType EntityType { get; init; }

    /// <inheritdoc/>
    public Optional<IUser> Creator { get; init; }

    /// <inheritdoc/>
    public Optional<int> UserCount { get; init; }

    /// <inheritdoc/>
    public Optional<string?> Image { get; init; }
}