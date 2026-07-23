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

public sealed class ApplePay
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApplePay(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// RegisterDomain
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RegisterDomainResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Activates a domain for use with Apple Pay on the Web and Square. A validation
    /// is performed on this domain by Apple to ensure that it is properly set up as
    /// an Apple Pay enabled domain.
    /// <para>
    /// This endpoint provides an easy way for platform developers to bulk activate
    /// Apple Pay on the Web with Square for merchants using their platform.
    /// </para>
    /// <para>
    /// To learn more about Web Apple Pay, see
    /// <see href="https://developer.squareup.com/docs/payment-form/add-digital-wallets/apple-pay">Add the Apple Pay on the Web Button</see>.
    /// </para>
    /// </remarks>
    public Task<RegisterDomainResponse> RegisterDomain(RegisterDomainRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/apple-pay/domains"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RegisterDomainResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
