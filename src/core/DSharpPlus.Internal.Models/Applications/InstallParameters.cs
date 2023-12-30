// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;

using DSharpPlus.Internal.Abstractions.Models;
using DSharpPlus.Entities;

namespace DSharpPlus.Internal.Models;

/// <inheritdoc cref="IInstallParameters" />
public sealed record InstallParameters : IInstallParameters
{
    /// <inheritdoc/>
    public required IReadOnlyList<string> Scopes { get; init; }

    /// <inheritdoc/>
    public required DiscordPermissions Permissions { get; init; }
}