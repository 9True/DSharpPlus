using DSharpPlus.Caching;

namespace DSharpPlus.Entities.AuditLogs;

public sealed class DiscordAuditLogBanEntry : DiscordAuditLogEntry
{
    /// <summary>
    /// Gets the banned member.
    /// </summary>
    public CachedEntity<ulong, DiscordMember> Target { get; internal set; }

    internal DiscordAuditLogBanEntry() { }
}
