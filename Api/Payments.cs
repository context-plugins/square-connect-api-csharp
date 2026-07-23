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

public sealed class Payments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Payments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CancelPayment
    /// </summary>
    /// <param name="paymentId">The ID of the payment to cancel.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelPaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels (voids) a payment. You can use this endpoint to cancel a payment with
    /// the APPROVED <c>status</c>.
    /// </remarks>
    public Task<CancelPaymentResponse> CancelPayment(string paymentId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payments/{payment_id}/cancel"),
            [new TemplateParam("payment_id", paymentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelPaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CancelPaymentByIdempotencyKey
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelPaymentByIdempotencyKeyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels (voids) a payment identified by the idempotency key that is specified in the
    /// request.
    /// <para>
    /// Use this method when the status of a <c>CreatePayment</c> request is unknown (for example, after you send a
    /// <c>CreatePayment</c> request, a network error occurs and you do not get a response). In this case, you can
    /// direct Square to cancel the payment using this endpoint. In the request, you provide the same
    /// idempotency key that you provided in your <c>CreatePayment</c> request that you want to cancel. After
    /// canceling the payment, you can submit your <c>CreatePayment</c> request again.
    /// </para>
    /// <para>
    /// Note that if no payment with the specified idempotency key is found, no action is taken and the endpoint
    /// returns successfully.
    /// </para>
    /// </remarks>
    public Task<CancelPaymentByIdempotencyKeyResponse> CancelPaymentByIdempotencyKey(CancelPaymentByIdempotencyKeyRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payments/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CancelPaymentByIdempotencyKeyResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CompletePayment
    /// </summary>
    /// <param name="paymentId">The unique ID identifying the payment to be completed.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompletePaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Completes (captures) a payment.
    /// By default, payments are set to complete immediately after they are created.
    /// <para>
    /// You can use this endpoint to complete a payment with the APPROVED <c>status</c>.
    /// </para>
    /// </remarks>
    public Task<CompletePaymentResponse> CompletePayment(string paymentId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payments/{payment_id}/complete"),
            [new TemplateParam("payment_id", paymentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CompletePaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreatePayment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreatePaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment using the provided source. You can use this endpoint
    /// to charge a card (credit/debit card or
    /// Square gift card) or record a payment that the seller received outside of Square
    /// (cash payment from a buyer or a payment that an external entity
    /// processed on behalf of the seller).
    /// <para>
    /// The endpoint creates a
    /// <c>Payment</c> object and returns it in the response.
    /// </para>
    /// </remarks>
    public Task<CreatePaymentResponse> CreatePayment(CreatePaymentRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreatePaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetPayment
    /// </summary>
    /// <param name="paymentId">A unique ID for the desired payment.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details for a specific payment.
    /// </remarks>
    public Task<GetPaymentResponse> GetPayment(string paymentId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payments/{payment_id}"),
            [new TemplateParam("payment_id", paymentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListPayments
    /// </summary>
    /// <param name="beginTime">The timestamp for the beginning of the reporting period, in RFC 3339 format. Inclusive. Default: The current time minus one year.</param>
    /// <param name="endTime">The timestamp for the end of the reporting period, in RFC 3339 format.  Default: The current time.</param>
    /// <param name="sortOrder">The order in which results are listed: - <c>ASC</c> - Oldest to newest. - <c>DESC</c> - Newest to oldest (default).</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query.  For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.</param>
    /// <param name="locationId">Limit results to the location supplied. By default, results are returned for the default (main) location associated with the seller.</param>
    /// <param name="total">The exact amount in the <c>total_money</c> for a payment.</param>
    /// <param name="last4">The last four digits of a payment card.</param>
    /// <param name="cardBrand">The brand of the payment card (for example, VISA).</param>
    /// <param name="limit">The maximum number of results to be returned in a single page. It is possible to receive fewer results than the specified limit on a given page.  The default value of 100 is also the maximum allowed value. If the provided value is  greater than 100, it is ignored and the default value is used instead.  Default: <c>100</c></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListPaymentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of payments taken by the account making the request.
    /// <para>
    /// Results are eventually consistent, and new payments or changes to payments might take several
    /// seconds to appear.
    /// </para>
    /// <para>
    /// The maximum results per page is 100.
    /// </para>
    /// </remarks>
    public Task<ListPaymentsResponse> ListPayments(string? beginTime,
        string? endTime,
        string? sortOrder,
        string? cursor,
        string? locationId,
        long? total,
        string? last4,
        string? cardBrand,
        int? limit,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payments"),
            [],
            [new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("sort_order", sortOrder),
                new Param("cursor", cursor),
                new Param("location_id", locationId),
                new Param("total", total),
                new Param("last_4", last4),
                new Param("card_brand", cardBrand),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListPaymentsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdatePayment
    /// </summary>
    /// <param name="paymentId">The ID of the payment to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdatePaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a payment with the APPROVED status.
    /// You can update the <c>amount_money</c> and <c>tip_money</c> using this endpoint.
    /// </remarks>
    public Task<UpdatePaymentResponse> UpdatePayment(string paymentId,
        UpdatePaymentRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/payments/{payment_id}"),
            [new TemplateParam("payment_id", paymentId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdatePaymentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
