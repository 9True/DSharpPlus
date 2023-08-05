// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using DSharpPlus.Entities;

using DSharpPlus.Core.Abstractions.Models;

namespace DSharpPlus.Core.Models;

/// <inheritdoc cref="IInteractiveComponent" />
public sealed record InteractiveComponent : IInteractiveComponent
{
    /// <inheritdoc/>
    public required DiscordMessageComponentType Type { get; init; }
}