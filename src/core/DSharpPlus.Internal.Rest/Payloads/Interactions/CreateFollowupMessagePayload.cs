// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;

using DSharpPlus.Entities;
using DSharpPlus.Internal.Abstractions.Models;
using DSharpPlus.Internal.Abstractions.Rest.Payloads;

namespace DSharpPlus.Internal.Rest.Payloads;

/// <inheritdoc cref="ICreateFollowupMessagePayload" />
public sealed record CreateFollowupMessagePayload : ICreateFollowupMessagePayload
{
    /// <inheritdoc/>
    public Optional<string> Content { get; init; }

    /// <inheritdoc/>
    public Optional<bool> Tts { get; init; }

    /// <inheritdoc/>
    public Optional<IReadOnlyList<IEmbed>> Embeds { get; init; }

    /// <inheritdoc/>
    public Optional<IAllowedMentions> AllowedMentions { get; init; }

    /// <inheritdoc/>
    public Optional<IReadOnlyList<IActionRowComponent>> Components { get; init; }

    /// <inheritdoc/>
    public IReadOnlyList<AttachmentData>? Files { get; init; }

    /// <inheritdoc/>
    public Optional<IReadOnlyList<IPartialAttachment>> Attachments { get; init; }

    /// <inheritdoc/>
    public Optional<DiscordMessageFlags> Flags { get; init; }
}