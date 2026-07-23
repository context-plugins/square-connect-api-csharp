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

public sealed class CheckoutModel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CheckoutModel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateCheckout
    /// </summary>
    /// <param name="locationId">The ID of the business location to associate the checkout with.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCheckoutResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Links a <c>checkoutId</c> to a <c>checkout_page_url</c> that customers are
    /// directed to in order to provide their payment information using a
    /// payment processing workflow hosted on connect.squareup.com.
    /// </remarks>
    public Task<CreateCheckoutResponse> CreateCheckout(string locationId,
        CreateCheckoutRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/checkouts"),
            [new TemplateParam("location_id", locationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCheckoutResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
