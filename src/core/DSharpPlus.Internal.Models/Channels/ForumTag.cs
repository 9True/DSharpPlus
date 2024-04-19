// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using DSharpPlus.Internal.Abstractions.Models;

namespace DSharpPlus.Internal.Models;

/// <inheritdoc cref="IForumTag" />
public sealed record ForumTag : IForumTag
{
    /// <inheritdoc/>
    public required Snowflake Id { get; init; }

    /// <inheritdoc/>
    public required string Name { get; init; }

    /// <inheritdoc/>
    public required bool Moderated { get; init; }

    /// <inheritdoc/>
    public Snowflake? EmojiId { get; init; }

    /// <inheritdoc/>
    public string? EmojiName { get; init; }
}
