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

public sealed class Oauth
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Oauth(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ObtainToken
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ObtainTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an OAuth access token.
    /// <para>
    /// The endpoint supports distinct methods of obtaining OAuth access tokens.
    /// Applications specify a method by adding the <c>grant_type</c> parameter
    /// in the request and also provide relevant information.
    /// </para>
    /// <para>
    /// __Note:__ Regardless of the method application specified,
    /// the endpoint always returns two items; an OAuth access token and
    /// a refresh token in the response.
    /// </para>
    /// <para>
    /// __OAuth tokens should only live on secure servers. Application clients
    /// should never interact directly with OAuth tokens__.
    /// </para>
    /// </remarks>
    public Task<ObtainTokenResponse> ObtainToken(ObtainTokenRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth2/token"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ObtainTokenResponse>(),
            RawErrorResponse.Instance,
            [],
            ct);

    /// <summary>
    /// RenewToken
    /// </summary>
    /// <param name="clientId">Your application ID, available from the <see href="https://developer.squareup.com/apps">developer dashboard</see>.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RenewTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <c>RenewToken</c> is deprecated. For information about refreshing OAuth access tokens, see
    /// <see href="https://developer.squareup.com/docs/oauth-api/migrate-to-refresh-tokens">Migrate from Renew to Refresh OAuth Tokens</see>.
    /// <para>
    ///
    /// Renews an OAuth access token before it expires.
    /// </para>
    /// <para>
    /// OAuth access tokens besides your application's personal access token expire after __30 days__.
    /// You can also renew expired tokens within __15 days__ of their expiration.
    /// You cannot renew an access token that has been expired for more than 15 days.
    /// Instead, the associated user must re-complete the OAuth flow from the beginning.
    /// </para>
    /// <para>
    /// __Important:__ The <c>Authorization</c> header for this endpoint must have the
    /// following format:
    /// </para>
    /// <code>
    /// Authorization: Client APPLICATION_SECRET
    /// </code>
    /// <para>
    /// Replace <c>APPLICATION_SECRET</c> with the application secret on the Credentials
    /// page in the <see href="https://developer.squareup.com/apps">developer dashboard</see>.
    /// </para>
    /// </remarks>
    public Task<RenewTokenResponse> RenewToken(string clientId,
        RenewTokenRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth2/clients/{client_id}/access-token/renew"),
            [new TemplateParam("client_id", clientId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RenewTokenResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2ClientSecret],
            ct);

    /// <summary>
    /// RevokeToken
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevokeTokenResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Revokes an access token generated with the OAuth flow.
    /// <para>
    /// If an account has more than one OAuth access token for your application, this
    /// endpoint revokes all of them, regardless of which token you specify. When an
    /// OAuth access token is revoked, all of the active subscriptions associated
    /// with that OAuth token are canceled immediately.
    /// </para>
    /// <para>
    /// __Important:__ The <c>Authorization</c> header for this endpoint must have the
    /// following format:
    /// </para>
    /// <code>
    /// Authorization: Client APPLICATION_SECRET
    /// </code>
    /// <para>
    /// Replace <c>APPLICATION_SECRET</c> with the application secret on the OAuth
    /// page in the <see href="https://developer.squareup.com/apps">developer dashboard</see>.
    /// </para>
    /// </remarks>
    public Task<RevokeTokenResponse> RevokeToken(RevokeTokenRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/oauth2/revoke"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RevokeTokenResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2ClientSecret],
            ct);
}
