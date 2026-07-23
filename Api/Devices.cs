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

public sealed class Devices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Devices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateDeviceCode
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateDeviceCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a DeviceCode that can be used to login to a Square Terminal device to enter the connected
    /// terminal mode.
    /// </remarks>
    public Task<CreateDeviceCodeResponse> CreateDeviceCode(CreateDeviceCodeRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices/codes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateDeviceCodeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetDeviceCode
    /// </summary>
    /// <param name="id">The unique identifier for the device code.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetDeviceCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves DeviceCode with the associated ID.
    /// </remarks>
    public Task<GetDeviceCodeResponse> GetDeviceCode(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices/codes/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetDeviceCodeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListDeviceCodes
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.</param>
    /// <param name="locationId">If specified, only returns DeviceCodes of the specified location. Returns DeviceCodes of all locations if empty.</param>
    /// <param name="productType">If specified, only returns DeviceCodes targeting the specified product type. Returns DeviceCodes of all product types if empty.</param>
    /// <param name="status">If specified, returns DeviceCodes with the specified statuses. Returns DeviceCodes of status <c>PAIRED</c> and <c>UNPAIRED</c> if empty.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDeviceCodesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all DeviceCodes associated with the merchant.
    /// </remarks>
    public Task<ListDeviceCodesResponse> ListDeviceCodes(string? cursor,
        string? locationId,
        string? productType,
        string? status,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/devices/codes"),
            [],
            [new Param("cursor", cursor),
                new Param("location_id", locationId),
                new Param("product_type", productType),
                new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDeviceCodesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
