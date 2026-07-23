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

public sealed class MobileAuthorization
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal MobileAuthorization(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateMobileAuthorizationCode
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateMobileAuthorizationCodeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates code to authorize a mobile application to connect to a Square card reader
    /// <para>
    /// Authorization codes are one-time-use and expire __60 minutes__ after being issued.
    /// </para>
    /// <para>
    /// __Important:__ The <c>Authorization</c> header you provide to this endpoint must have the following format:
    /// </para>
    /// <code>
    /// Authorization: Bearer ACCESS_TOKEN
    /// </code>
    /// <para>
    /// Replace <c>ACCESS_TOKEN</c> with a
    /// <see href="https://developer.squareup.com/docs/build-basics/access-tokens">valid production authorization credential</see>.
    /// </para>
    /// </remarks>
    public Task<CreateMobileAuthorizationCodeResponse> CreateMobileAuthorizationCode(CreateMobileAuthorizationCodeRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/mobile/authorization-code"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateMobileAuthorizationCodeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
