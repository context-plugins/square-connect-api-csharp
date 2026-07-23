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

public sealed class CustomerGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CustomerGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateCustomerGroup
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new customer group for a business.
    /// <para>
    /// The request must include the <c>name</c> value of the group.
    /// </para>
    /// </remarks>
    public Task<CreateCustomerGroupResponse> CreateCustomerGroup(CreateCustomerGroupRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/groups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteCustomerGroup
    /// </summary>
    /// <param name="groupId">The ID of the customer group to delete.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a customer group as identified by the <c>group_id</c> value.
    /// </remarks>
    public Task<DeleteCustomerGroupResponse> DeleteCustomerGroup(string groupId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/groups/{group_id}"),
            [new TemplateParam("group_id", groupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListCustomerGroups
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for your original query.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.  The limit is ignored if it is less than 1 or greater than 50. The default value is 50.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomerGroupsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the list of customer groups of a business.
    /// </remarks>
    public Task<ListCustomerGroupsResponse> ListCustomerGroups(string? cursor,
        int? limit,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/groups"),
            [],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomerGroupsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveCustomerGroup
    /// </summary>
    /// <param name="groupId">The ID of the customer group to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific customer group as identified by the <c>group_id</c> value.
    /// </remarks>
    public Task<RetrieveCustomerGroupResponse> RetrieveCustomerGroup(string groupId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/groups/{group_id}"),
            [new TemplateParam("group_id", groupId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateCustomerGroup
    /// </summary>
    /// <param name="groupId">The ID of the customer group to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateCustomerGroupResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a customer group as identified by the <c>group_id</c> value.
    /// </remarks>
    public Task<UpdateCustomerGroupResponse> UpdateCustomerGroup(string groupId,
        UpdateCustomerGroupRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/groups/{group_id}"),
            [new TemplateParam("group_id", groupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateCustomerGroupResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
