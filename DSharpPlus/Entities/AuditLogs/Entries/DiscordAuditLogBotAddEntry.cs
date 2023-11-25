namespace DSharpPlus.Entities.AuditLogs;

using Caching;

public sealed class DiscordAuditLogBotAddEntry : DiscordAuditLogEntry
{
    /// <summary>
    /// Gets the bot that has been added to the guild.
    /// </summary>
    public CachedEntity<ulong, DiscordUser> TargetBot { get; internal set; }
}
