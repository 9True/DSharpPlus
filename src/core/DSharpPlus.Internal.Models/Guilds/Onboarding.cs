// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;

using DSharpPlus.Entities;
using DSharpPlus.Internal.Abstractions.Models;

namespace DSharpPlus.Internal.Models;

/// <inheritdoc cref="IOnboarding" />
public sealed record Onboarding : IOnboarding
{
    /// <inheritdoc/>
    public required Snowflake GuildId { get; init; }

    /// <inheritdoc/>
    public required IReadOnlyList<IOnboardingPrompt> Prompts { get; init; }

    /// <inheritdoc/>
    public required IReadOnlyList<Snowflake> DefaultChannelIds { get; init; }

    /// <inheritdoc/>
    public required bool Enabled { get; init; }

    /// <inheritdoc/>
    public required DiscordGuildOnboardingPromptType Mode { get; init; }
}
