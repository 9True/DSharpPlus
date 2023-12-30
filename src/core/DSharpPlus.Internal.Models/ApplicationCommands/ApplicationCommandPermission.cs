// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using DSharpPlus.Internal.Abstractions.Models;
using DSharpPlus.Entities;

namespace DSharpPlus.Internal.Models;

/// <inheritdoc cref="IApplicationCommandPermission" />
public sealed record ApplicationCommandPermission : IApplicationCommandPermission
{
    /// <inheritdoc/>
    public required Snowflake Id { get; init; }

    /// <inheritdoc/>
    public required DiscordApplicationCommandPermissionType Type { get; init; }

    /// <inheritdoc/>
    public required bool Permission { get; init; }
}