// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using Remora.Rest.Core;

namespace DSharpPlus.Core.Abstractions.Models;

/// <summary>
/// Represents a default value for an auto-populated select menu.
/// </summary>
public interface IDefaultSelectValue
{
    /// <summary>
    /// The snowflake identifier of a user, role or channel.
    /// </summary>
    public Snowflake Id { get; }

    /// <summary>
    /// The type of the value represented by <seealso cref="Id"/>; either "user", "role" or "channel".
    /// </summary>
    public string Type { get; }
}
