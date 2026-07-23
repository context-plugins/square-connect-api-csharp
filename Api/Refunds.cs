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

public sealed class Refunds
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Refunds(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// GetPaymentRefund
    /// </summary>
    /// <param name="refundId">The unique ID for the desired <c>PaymentRefund</c>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPaymentRefundResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific refund using the <c>refund_id</c>.
    /// </remarks>
    public Task<GetPaymentRefundResponse> GetPaymentRefund(string refundId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/refunds/{refund_id}"),
            [new TemplateParam("refund_id", refundId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPaymentRefundResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListPaymentRefunds
    /// </summary>
    /// <param name="beginTime">The timestamp for the beginning of the requested reporting period, in RFC 3339 format.  Default: The current time minus one year.</param>
    /// <param name="endTime">The timestamp for the end of the requested reporting period, in RFC 3339 format.  Default: The current time.</param>
    /// <param name="sortOrder">The order in which results are listed: - <c>ASC</c> - Oldest to newest. - <c>DESC</c> - Newest to oldest (default).</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query.  For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.</param>
    /// <param name="locationId">Limit results to the location supplied. By default, results are returned for all locations associated with the seller.</param>
    /// <param name="status">If provided, only refunds with the given status are returned. For a list of refund status values, see <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/PaymentRefund">PaymentRefund</see>.  Default: If omitted, refunds are returned regardless of their status.</param>
    /// <param name="sourceType">If provided, only refunds with the given source type are returned. - <c>CARD</c> - List refunds only for payments where <c>CARD</c> was specified as the payment source.  Default: If omitted, refunds are returned regardless of the source type.</param>
    /// <param name="limit">The maximum number of results to be returned in a single page.  It is possible to receive fewer results than the specified limit on a given page.  If the supplied value is greater than 100, no more than 100 results are returned.  Default: 100</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPaymentRefundsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of refunds for the account making the request.
    /// <para>
    /// Results are eventually consistent, and new refunds or changes to refunds might take several
    /// seconds to appear.
    /// </para>
    /// <para>
    /// The maximum results per page is 100.
    /// </para>
    /// </remarks>
    public Task<ListPaymentRefundsResponse> ListPaymentRefunds(string? beginTime,
        string? endTime,
        string? sortOrder,
        string? cursor,
        string? locationId,
        string? status,
        string? sourceType,
        int? limit,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/refunds"),
            [],
            [new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("sort_order", sortOrder),
                new Param("cursor", cursor),
                new Param("location_id", locationId),
                new Param("status", status),
                new Param("source_type", sourceType),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPaymentRefundsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RefundPayment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RefundPaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds a payment. You can refund the entire payment amount or a
    /// portion of it. You can use this endpoint to refund a card payment or record a
    /// refund of a cash or external payment. For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/refund-payments">Refund Payment</see>.
    /// </remarks>
    public Task<RefundPaymentResponse> RefundPayment(RefundPaymentRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/refunds"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RefundPaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
