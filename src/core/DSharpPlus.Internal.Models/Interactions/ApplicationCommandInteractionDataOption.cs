// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;

using DSharpPlus.Entities;
using DSharpPlus.Internal.Abstractions.Models;

using OneOf;

namespace DSharpPlus.Internal.Models;

/// <inheritdoc cref="IApplicationCommandInteractionDataOption" />
public sealed record ApplicationCommandInteractionDataOption : IApplicationCommandInteractionDataOption
{
    /// <inheritdoc/>
    public required string Name { get; init; }

    /// <inheritdoc/>
    public required DiscordApplicationCommandOptionType Type { get; init; }

    /// <inheritdoc/>
    public Optional<OneOf<string, int, double, bool>> Value { get; init; }

    /// <inheritdoc/>
    public Optional<IReadOnlyList<IApplicationCommandInteractionDataOption>> Options { get; init; }

    /// <inheritdoc/>
    public Optional<bool> Focused { get; init; }
}