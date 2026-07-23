using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SquareConnectApi.Core;
using SquareConnectApi.Core.ErrorResponse;
using SquareConnectApi.Core.Exceptions;
using SquareConnectApi.Core.Models;
using SquareConnectApi.Core.Request;
using SquareConnectApi.Core.Response;
using SquareConnectApi.Models;

namespace SquareConnectApi.Api;

public sealed class Team
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Team(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BulkCreateTeamMembers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkCreateTeamMembersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates multiple <c>TeamMember</c> objects. The created <c>TeamMember</c> objects are returned on successful creates.
    /// This process is non-transactional and processes as much of the request as possible. If one of the creates in
    /// the request cannot be successfully processed, the request is not marked as failed, but the body of the response
    /// contains explicit error information for the failed create.
    /// <para>
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#bulk-create-team-members">Troubleshooting the Team API</see>.
    /// </para>
    /// </remarks>
    public Task<BulkCreateTeamMembersResponse> BulkCreateTeamMembers(BulkCreateTeamMembersRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/bulk-create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkCreateTeamMembersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// BulkUpdateTeamMembers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BulkUpdateTeamMembersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates multiple <c>TeamMember</c> objects. The updated <c>TeamMember</c> objects are returned on successful updates.
    /// This process is non-transactional and processes as much of the request as possible. If one of the updates in
    /// the request cannot be successfully processed, the request is not marked as failed, but the body of the response
    /// contains explicit error information for the failed update.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#bulk-update-team-members">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<BulkUpdateTeamMembersResponse> BulkUpdateTeamMembers(BulkUpdateTeamMembersRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/bulk-update"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BulkUpdateTeamMembersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateTeamMember
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTeamMemberResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a single <c>TeamMember</c> object. The <c>TeamMember</c> object is returned on successful creates.
    /// You must provide the following values in your request to this endpoint:
    /// - <c>given_name</c>
    /// - <c>family_name</c>
    /// <para>
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#createteammember">Troubleshooting the Team API</see>.
    /// </para>
    /// </remarks>
    public Task<CreateTeamMemberResponse> CreateTeamMember(CreateTeamMemberRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateTeamMemberResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveTeamMember
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTeamMemberResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <c>TeamMember</c> object for the given <c>TeamMember.id</c>.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#retrieve-a-team-member">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<RetrieveTeamMemberResponse> RetrieveTeamMember(string teamMemberId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTeamMemberResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveWageSetting
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member for which to retrieve the wage setting.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveWageSettingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a <c>WageSetting</c> object for a team member specified
    /// by <c>TeamMember.id</c>.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#retrievewagesetting">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<RetrieveWageSettingResponse> RetrieveWageSetting(string teamMemberId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}/wage-setting"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveWageSettingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchTeamMembers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchTeamMembersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>TeamMember</c> objects for a business.
    /// The list can be filtered by the following:
    /// - location IDs
    /// - <c>status</c>
    /// </remarks>
    public Task<SearchTeamMembersResponse> SearchTeamMembers(SearchTeamMembersRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchTeamMembersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateTeamMember
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateTeamMemberResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a single <c>TeamMember</c> object. The <c>TeamMember</c> object is returned on successful updates.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#update-a-team-member">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<UpdateTeamMemberResponse> UpdateTeamMember(string teamMemberId,
        UpdateTeamMemberRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateTeamMemberResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateWageSetting
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member for which to update the <c>WageSetting</c> object.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateWageSettingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates a <c>WageSetting</c> object. The object is created if a
    /// <c>WageSetting</c> with the specified <c>team_member_id</c> does not exist. Otherwise,
    /// it fully replaces the <c>WageSetting</c> object for the team member.
    /// The <c>WageSetting</c> is returned on a successful update.
    /// Learn about <see href="https://developer.squareup.com/docs/team/troubleshooting#create-or-update-a-wage-setting">Troubleshooting the Team API</see>.
    /// </remarks>
    public Task<UpdateWageSettingResponse> UpdateWageSetting(string teamMemberId,
        UpdateWageSettingRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/team-members/{team_member_id}/wage-setting"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateWageSettingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
