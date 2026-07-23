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

public sealed class Locations
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Locations(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateLocation
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateLocationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a location.
    /// </remarks>
    public Task<CreateLocationResponse> CreateLocation(CreateLocationRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateLocationResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListLocations
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLocationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides information of all locations of a business.
    /// <para>
    /// Many Square API endpoints require a <c>location_id</c> parameter.
    /// The <c>id</c> field of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location"><c>Location</c></see> objects returned by this
    /// endpoint correspond to that <c>location_id</c> parameter.
    /// </para>
    /// </remarks>
    public Task<ListLocationsResponse> ListLocations(CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLocationsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveLocation
    /// </summary>
    /// <param name="locationId">The ID of the location to retrieve. If you specify the string "main", then the endpoint returns the main location.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLocationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details of a location. You can specify "main"
    /// as the location ID to retrieve details of the
    /// main location.
    /// </remarks>
    public Task<RetrieveLocationResponse> RetrieveLocation(string locationId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}"),
            [new TemplateParam("location_id", locationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLocationResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateLocation
    /// </summary>
    /// <param name="locationId">The ID of the location to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateLocationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a location.
    /// </remarks>
    public Task<UpdateLocationResponse> UpdateLocation(string locationId,
        UpdateLocationRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}"),
            [new TemplateParam("location_id", locationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateLocationResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
