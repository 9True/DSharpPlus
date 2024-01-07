// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using DSharpPlus.Internal.Abstractions.Models;
using DSharpPlus.Internal.Abstractions.Rest.Payloads;
using DSharpPlus.Internal.Abstractions.Rest.Queries;
using DSharpPlus.Internal.Abstractions.Rest.Responses;

using Remora.Results;

namespace DSharpPlus.Internal.Abstractions.Rest.API;

/// <summary>
/// Provides access to application commands-related API calls.
/// </summary>
// https://discord.com/developers/docs/interactions/application-commands
public interface IApplicationCommandsRestAPI
{
    /// <summary>
    /// Fetches all global application commands for your application.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="query">Indicates whether to include full localizations in the returned objects.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>An array of application commands.</returns>
    public ValueTask<Result<IReadOnlyList<IApplicationCommand>>> GetGlobalApplicationCommandsAsync
    (
        Snowflake applicationId,
        LocalizationQuery query = default,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Creates a new global application command for your application.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="payload">The command you wish to create.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>A value indicating whether this command was newly created as well as the command object.</returns>
    public ValueTask<Result<CreateApplicationCommandResponse>> CreateGlobalApplicationCommandAsync
    (
        Snowflake applicationId,
        ICreateGlobalApplicationCommandPayload payload,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Fetches a global application command for your application.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="commandId">The snowflake identifier of the command to fetch.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>The requested application command.</returns>
    public ValueTask<Result<IApplicationCommand>> GetGlobalApplicationCommandAsync
    (
        Snowflake applicationId,
        Snowflake commandId,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Edits a global application command for your application.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="commandId">The snowflake identifier of the command to edit.</param>
    /// <param name="payload">A payload containing the fields to edit with their new values.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>The edited application command.</returns>
    public ValueTask<Result<IApplicationCommand>> EditGlobalApplicationCommandAsync
    (
        Snowflake applicationId,
        Snowflake commandId,
        IEditGlobalApplicationCommandPayload payload,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Deletes a global application command for your application.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="commandId">The snowflake identifier of the command to delete.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>A value indicating the success of this operation.</returns>
    public ValueTask<Result> DeleteGlobalApplicationCommandAsync
    (
        Snowflake applicationId,
        Snowflake commandId,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Bulk-overwrites global application commands for your application with the provided commands.
    /// </summary>
    /// <remarks>
    /// This will overwrite all types of application commands: slash/chat input commands, user context menu
    /// commands and message context menu commands. Commands that did not already exist will count towards the
    /// daily application command creation limits, commands that did exist will not.
    /// </remarks>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="payload">The application commands to create.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>The full list of application commands for your application after overwriting.</returns>
    public ValueTask<Result<IReadOnlyList<IApplicationCommand>>> BulkOverwriteGlobalApplicationCommandsAsync
    (
        Snowflake applicationId,
        IReadOnlyList<ICreateGlobalApplicationCommandPayload> payload,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Fetches application commands for the specified guild.
    /// </summary>
    /// <remarks>
    /// This does not fetch global commands accessible in the guild, only comands registered to specifically 
    /// that guild using the related API calls.
    /// </remarks>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild containing the application commands.</param>
    /// <param name="query">
    /// Indicates whether to include localization dictionaries with the commands.
    /// </param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    public ValueTask<Result<IReadOnlyList<IApplicationCommand>>> GetGuildApplicationCommandsAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        LocalizationQuery query = default,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Creates an application command specific to the given guild.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild to own this command.</param>
    /// <param name="payload">The command you wish to create.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>The created application command object.</returns>
    public ValueTask<Result<CreateApplicationCommandResponse>> CreateGuildApplicationCommandAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        ICreateGuildApplicationCommandPayload payload,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Fetches a guild-specific application command by snowflake.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild owning this command.</param>
    /// <param name="commandId">The snowflake identifier of the command to fetch.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    public ValueTask<Result<IApplicationCommand>> GetGuildApplicationCommandAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        Snowflake commandId,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Edits a guild-specific application command. Updates will be available immediately.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild owning this command.</param>
    /// <param name="commandId">The snowflake identifier of this command.</param>
    /// <param name="payload">A payload containing new properties for this command.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>The edited application command object.</returns>
    public ValueTask<Result<IApplicationCommand>> EditGuildApplicationCommandAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        Snowflake commandId,
        IEditGuildApplicationCommandPayload payload,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Deletes a guild-specific application command.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild owning this command.</param>
    /// <param name="commandId">The snowflake identifier of this command.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    public ValueTask<Result> DeleteGuildApplicationCommandAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        Snowflake commandId,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Bulk-overwrites guild-specific application commands for your application with the provided commands.
    /// </summary>
    /// <remarks>
    /// This will overwrite all types of application commands: slash/chat input commands, user context menu
    /// commands and message context menu commands. Commands that did not already exist will count towards the
    /// daily application command creation limits, commands that did exist will not.
    /// </remarks>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild to own these commands.</param>
    /// <param name="payload">The application commands to create.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    /// <returns>The full list of application commands for your application after overwriting.</returns>
    public ValueTask<Result<IReadOnlyList<IApplicationCommand>>> BulkOverwriteGuildApplicationCommandsAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        IReadOnlyList<ICreateGuildApplicationCommandPayload> payload,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Fetches permissions for all commands owned by your application in the given guild.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    public ValueTask<Result<IReadOnlyList<IApplicationCommandPermissions>>> GetGuildApplicationCommandPermissionsAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        RequestInfo info = default,
        CancellationToken ct = default
    );

    /// <summary>
    /// Fetches permissions for the given command in the given guild.
    /// </summary>
    /// <param name="applicationId">The snowflake identifier of your application.</param>
    /// <param name="guildId">The snowflake identifier of the guild.</param>
    /// <param name="commandId">The snowflake identifier of the command.</param>
    /// <param name="info">Additional instructions regarding this request.</param>
    /// <param name="ct">A cancellation token for this operation.</param>
    public ValueTask<Result<IApplicationCommandPermissions>> GetApplicationCommandPermissionsAsync
    (
        Snowflake applicationId,
        Snowflake guildId,
        Snowflake commandId,
        RequestInfo info = default,
        CancellationToken ct = default
    );
}
