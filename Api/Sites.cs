using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SquareConnectApi.Core;
using SquareConnectApi.Core.ErrorResponse;
using SquareConnectApi.Core.Exceptions;
using SquareConnectApi.Core.Request;
using SquareConnectApi.Core.Response;
using SquareConnectApi.Models;

namespace SquareConnectApi.Api;

public sealed class Sites
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Sites(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ListSites
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListSitesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the Square Online sites that belong to a seller.
    /// <para>
    ///
    /// __Note:__ Square Online APIs are publicly available as part of an early access program. For more information, see <see href="https://developer.squareup.com/docs/online-api#early-access-program-for-square-online-apis">Early access program for Square Online APIs</see>.
    /// </para>
    /// </remarks>
    public Task<ListSitesResponse> ListSites(CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/sites"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListSitesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
