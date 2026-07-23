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

public sealed class Transactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Transactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CaptureTransaction
    /// </summary>
    /// <param name="locationId"></param>
    /// <param name="transactionId"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CaptureTransactionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Captures a transaction that was created with the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/charge">Charge</see>
    /// endpoint with a <c>delay_capture</c> value of <c>true</c>.
    /// <para>
    ///
    /// See <see href="https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture">Delayed capture transactions</see>
    /// for more information.
    /// </para>
    /// </remarks>
    public Task<CaptureTransactionResponse> CaptureTransaction(string locationId,
        string transactionId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions/{transaction_id}/capture"),
            [new TemplateParam("location_id", locationId), new TemplateParam("transaction_id", transactionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CaptureTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// Charge
    /// </summary>
    /// <param name="locationId">The ID of the location to associate the created transaction with.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ChargeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Charges a card represented by a card nonce or a customer's card on file.
    /// <para>
    /// Your request to this endpoint must include _either_:
    /// </para>
    /// <para>
    /// - A value for the <c>card_nonce</c> parameter (to charge a card payment token generated
    /// with the Web Payments SDK)
    /// - Values for the <c>customer_card_id</c> and <c>customer_id</c> parameters (to charge
    /// a customer's card on file)
    /// </para>
    /// <para>
    /// In order for an eCommerce payment to potentially qualify for
    /// <see href="https://squareup.com/help/article/5394">Square chargeback protection</see>, you
    /// _must_ provide values for the following parameters in your request:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>buyer_email_address</c></description></item>
    ///   <item><description>At least one of <c>billing_address</c> or <c>shipping_address</c></description></item>
    /// </list>
    /// <para>
    /// When this response is returned, the amount of Square's processing fee might not yet be
    /// calculated. To obtain the processing fee, wait about ten seconds and call
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/retrieve-transaction">RetrieveTransaction</see>. See the <c>processing_fee_money</c>
    /// field of each <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Tender">Tender included</see> in the transaction.
    /// </para>
    /// </remarks>
    public Task<ChargeResponse> Charge(string locationId, ChargeRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions"),
            [new TemplateParam("location_id", locationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ChargeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateRefund
    /// </summary>
    /// <param name="locationId">The ID of the original transaction's associated location.</param>
    /// <param name="transactionId">The ID of the original transaction that includes the tender to refund.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateRefundResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Initiates a refund for a previously charged tender.
    /// <para>
    /// You must issue a refund within 120 days of the associated payment. See
    /// <see href="https://squareup.com/help/us/en/article/5060">this article</see> for more information
    /// on refund behavior.
    /// </para>
    /// <para>
    /// NOTE: Card-present transactions with Interac credit cards **cannot be
    /// refunded using the Connect API**. Interac transactions must refunded
    /// in-person (e.g., dipping the card using POS app).
    /// </para>
    /// </remarks>
    public Task<CreateRefundResponse> CreateRefund(string locationId,
        string transactionId,
        CreateRefundRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions/{transaction_id}/refund"),
            [new TemplateParam("location_id", locationId), new TemplateParam("transaction_id", transactionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateRefundResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListRefunds
    /// </summary>
    /// <param name="locationId">The ID of the location to list refunds for.</param>
    /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format.  See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.  Default value: The current time minus one year.</param>
    /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format.  See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.  Default value: The current time.</param>
    /// <param name="sortOrder">The order in which results are listed in the response (<c>ASC</c> for oldest first, <c>DESC</c> for newest first).  Default value: <c>DESC</c></param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListRefundsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists refunds for one of a business's locations.
    /// <para>
    /// In addition to full or partial tender refunds processed through Square APIs,
    /// refunds may result from itemized returns or exchanges through Square's
    /// Point of Sale applications.
    /// </para>
    /// <para>
    /// Refunds with a <c>status</c> of <c>PENDING</c> are not currently included in this
    /// endpoint's response.
    /// </para>
    /// <para>
    /// Max results per <see href="https://developer.squareup.com/docs/working-with-apis/pagination">page</see>: 50
    /// </para>
    /// </remarks>
    public Task<ListRefundsResponse> ListRefunds(string locationId,
        string? beginTime,
        string? endTime,
        string? sortOrder,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/refunds"),
            [new TemplateParam("location_id", locationId)],
            [new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("sort_order", sortOrder),
                new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListRefundsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListTransactions
    /// </summary>
    /// <param name="locationId">The ID of the location to list transactions for.</param>
    /// <param name="beginTime">The beginning of the requested reporting period, in RFC 3339 format.  See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.  Default value: The current time minus one year.</param>
    /// <param name="endTime">The end of the requested reporting period, in RFC 3339 format.  See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.  Default value: The current time.</param>
    /// <param name="sortOrder">The order in which results are listed in the response (<c>ASC</c> for oldest first, <c>DESC</c> for newest first).  Default value: <c>DESC</c></param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTransactionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists transactions for a particular location.
    /// <para>
    /// Transactions include payment information from sales and exchanges and refund
    /// information from returns and exchanges.
    /// </para>
    /// <para>
    /// Max results per <see href="https://developer.squareup.com/docs/working-with-apis/pagination">page</see>: 50
    /// </para>
    /// </remarks>
    public Task<ListTransactionsResponse> ListTransactions(string locationId,
        string? beginTime,
        string? endTime,
        string? sortOrder,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions"),
            [new TemplateParam("location_id", locationId)],
            [new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("sort_order", sortOrder),
                new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTransactionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveTransaction
    /// </summary>
    /// <param name="locationId">The ID of the transaction's associated location.</param>
    /// <param name="transactionId">The ID of the transaction to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTransactionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details for a single transaction.
    /// </remarks>
    public Task<RetrieveTransactionResponse> RetrieveTransaction(string locationId,
        string transactionId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions/{transaction_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("transaction_id", transactionId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// VoidTransaction
    /// </summary>
    /// <param name="locationId"></param>
    /// <param name="transactionId"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="VoidTransactionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a transaction that was created with the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/charge">Charge</see>
    /// endpoint with a <c>delay_capture</c> value of <c>true</c>.
    /// <para>
    ///
    /// See <see href="https://developer.squareup.com/docs/payments/transactions/overview#delayed-capture">Delayed capture transactions</see>
    /// for more information.
    /// </para>
    /// </remarks>
    public Task<VoidTransactionResponse> VoidTransaction(string locationId,
        string transactionId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/locations/{location_id}/transactions/{transaction_id}/void"),
            [new TemplateParam("location_id", locationId), new TemplateParam("transaction_id", transactionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<VoidTransactionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
