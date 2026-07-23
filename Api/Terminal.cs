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

public sealed class Terminal
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Terminal(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CancelTerminalCheckout
    /// </summary>
    /// <param name="checkoutId">The unique ID for the desired <c>TerminalCheckout</c>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelTerminalCheckoutResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a Terminal checkout request if the status of the request permits it.
    /// </remarks>
    public Task<CancelTerminalCheckoutResponse> CancelTerminalCheckout(string checkoutId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/checkouts/{checkout_id}/cancel"),
            [new TemplateParam("checkout_id", checkoutId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelTerminalCheckoutResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CancelTerminalRefund
    /// </summary>
    /// <param name="terminalRefundId">The unique ID for the desired <c>TerminalRefund</c>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelTerminalRefundResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an Interac Terminal refund request by refund request ID if the status of the request permits it.
    /// </remarks>
    public Task<CancelTerminalRefundResponse> CancelTerminalRefund(string terminalRefundId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/refunds/{terminal_refund_id}/cancel"),
            [new TemplateParam("terminal_refund_id", terminalRefundId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelTerminalRefundResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateTerminalCheckout
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTerminalCheckoutResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a Terminal checkout request and sends it to the specified device to take a payment
    /// for the requested amount.
    /// </remarks>
    public Task<CreateTerminalCheckoutResponse> CreateTerminalCheckout(CreateTerminalCheckoutRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/checkouts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateTerminalCheckoutResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateTerminalRefund
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTerminalRefundResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a request to refund an Interac payment completed on a Square Terminal.
    /// </remarks>
    public Task<CreateTerminalRefundResponse> CreateTerminalRefund(CreateTerminalRefundRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/refunds"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateTerminalRefundResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetTerminalCheckout
    /// </summary>
    /// <param name="checkoutId">The unique ID for the desired <c>TerminalCheckout</c>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTerminalCheckoutResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a Terminal checkout request by <c>checkout_id</c>.
    /// </remarks>
    public Task<GetTerminalCheckoutResponse> GetTerminalCheckout(string checkoutId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/checkouts/{checkout_id}"),
            [new TemplateParam("checkout_id", checkoutId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTerminalCheckoutResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetTerminalRefund
    /// </summary>
    /// <param name="terminalRefundId">The unique ID for the desired <c>TerminalRefund</c>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTerminalRefundResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an Interac Terminal refund object by ID.
    /// </remarks>
    public Task<GetTerminalRefundResponse> GetTerminalRefund(string terminalRefundId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/refunds/{terminal_refund_id}"),
            [new TemplateParam("terminal_refund_id", terminalRefundId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTerminalRefundResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchTerminalCheckouts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchTerminalCheckoutsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a filtered list of Terminal checkout requests created by the account making the request.
    /// </remarks>
    public Task<SearchTerminalCheckoutsResponse> SearchTerminalCheckouts(SearchTerminalCheckoutsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/checkouts/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchTerminalCheckoutsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchTerminalRefunds
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchTerminalRefundsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a filtered list of Interac Terminal refund requests created by the seller making the request.
    /// </remarks>
    public Task<SearchTerminalRefundsResponse> SearchTerminalRefunds(SearchTerminalRefundsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/terminals/refunds/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchTerminalRefundsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
