// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System;

using DSharpPlus.Entities;

using Remora.Rest.Core;

using DSharpPlus.Core.Abstractions.Models;

namespace DSharpPlus.Core.Models;

/// <inheritdoc cref="IInvite" />
public sealed record Invite : IInvite
{
    /// <inheritdoc/>
    public required string Code { get; init; }

    /// <inheritdoc/>
    public Optional<IPartialGuild> Guild { get; init; }

    /// <inheritdoc/>
    public required IPartialChannel? Channel { get; init; }

    /// <inheritdoc/>
    public Optional<IUser> Inviter { get; init; }

    /// <inheritdoc/>
    public Optional<DiscordInviteTargetType> TargetType { get; init; }

    /// <inheritdoc/>
    public Optional<IUser> TargetUser { get; init; }

    /// <inheritdoc/>
    public Optional<IPartialApplication> TargetApplication { get; init; }

    /// <inheritdoc/>
    public Optional<int> ApproximatePresenceCount { get; init; }

    /// <inheritdoc/>
    public Optional<int> ApproximateMemberCount { get; init; }

    /// <inheritdoc/>
    public Optional<DateTimeOffset?> ExpiresAt { get; init; }

    /// <inheritdoc/>
    public Optional<IScheduledEvent> GuildScheduledEvent { get; init; }

    /// <inheritdoc/>
    public Optional<int> Uses { get; init; }

    /// <inheritdoc/>
    public Optional<int> MaxUses { get; init; }

    /// <inheritdoc/>
    public Optional<int> MaxAge { get; init; }

    /// <inheritdoc/>
    public Optional<bool> Temporary { get; init; }

    /// <inheritdoc/>
    public Optional<DateTimeOffset> CreatedAt { get; init; }
}