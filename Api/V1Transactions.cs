using System;
using System.Collections.Generic;
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

public sealed class V1Transactions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal V1Transactions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateRefund
    /// </summary>
    /// <param name="locationId">The ID of the original payment's associated location.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Refund"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Issues a refund for a previously processed payment. You must issue
    /// a refund within 60 days of the associated payment.
    /// <para>
    /// You cannot issue a partial refund for a split tender payment. You must
    /// instead issue a full or partial refund for a particular tender, by
    /// providing the applicable tender id to the V1CreateRefund endpoint.
    /// Issuing a full refund for a split tender payment refunds all tenders
    /// associated with the payment.
    /// </para>
    /// <para>
    /// Issuing a refund for a card payment is not reversible. For development
    /// purposes, you can create fake cash payments in Square Point of Sale and
    /// refund them.
    /// </para>
    /// </remarks>
    public Task<V1Refund> CreateRefund(string locationId,
        V1CreateRefundRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/refunds"),
            [new TemplateParam("location_id", locationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1Refund>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListOrders
    /// </summary>
    /// <param name="locationId">The ID of the location to list online store orders for.</param>
    /// <param name="order">The order in which payments are listed in the response.</param>
    /// <param name="limit">The maximum number of payments to return in a single response. This value cannot exceed 200.</param>
    /// <param name="batchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V1Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides summary information for a merchant's online store orders.
    /// </remarks>
    public Task<IReadOnlyList<V1Order>> ListOrders(string locationId,
        string? order,
        int? limit,
        string? batchToken,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/orders"),
            [new TemplateParam("location_id", locationId)],
            [new Param("order", order), new Param("limit", limit), new Param("batch_token", batchToken)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V1Order>>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListPayments
    /// </summary>
    /// <param name="locationId">The ID of the location to list payments for. If you specify me, this endpoint returns payments aggregated from all of the business's locations.</param>
    /// <param name="order">The order in which payments are listed in the response.</param>
    /// <param name="beginTime">The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year.</param>
    /// <param name="endTime">The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time.</param>
    /// <param name="limit">The maximum number of payments to return in a single response. This value cannot exceed 200.</param>
    /// <param name="batchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint.</param>
    /// <param name="includePartial">Indicates whether or not to include partial payments in the response. Partial payments will have the tenders collected so far, but the itemizations will be empty until the payment is completed.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V1Payment"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides summary information for all payments taken for a given
    /// Square account during a date range. Date ranges cannot exceed 1 year in
    /// length. See Date ranges for details of inclusive and exclusive dates.
    /// <para>
    /// *Note**: Details for payments processed with Square Point of Sale while
    /// in offline mode may not be transmitted to Square for up to 72 hours.
    /// Offline payments have a <c>created_at</c> value that reflects the time the
    /// payment was originally processed, not the time it was subsequently
    /// transmitted to Square. Consequently, the ListPayments endpoint might
    /// list an offline payment chronologically between online payments that
    /// were seen in a previous request.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<V1Payment>> ListPayments(string locationId,
        string? order,
        string? beginTime,
        string? endTime,
        int? limit,
        string? batchToken,
        bool? includePartial,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/payments"),
            [new TemplateParam("location_id", locationId)],
            [new Param("order", order),
                new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("limit", limit),
                new Param("batch_token", batchToken),
                new Param("include_partial", includePartial)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V1Payment>>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListRefunds
    /// </summary>
    /// <param name="locationId">The ID of the location to list refunds for.</param>
    /// <param name="order">The order in which payments are listed in the response.</param>
    /// <param name="beginTime">The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year.</param>
    /// <param name="endTime">The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time.</param>
    /// <param name="limit">The approximate number of refunds to return in a single response. Default: 100. Max: 200. Response may contain more results than the prescribed limit when refunds are made simultaneously to multiple tenders in a payment or when refunds are generated in an exchange to account for the value of returned goods.</param>
    /// <param name="batchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V1Refund"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides the details for all refunds initiated by a merchant or any of the merchant's mobile staff during a date range. Date ranges cannot exceed one year in length.
    /// </remarks>
    public Task<IReadOnlyList<V1Refund>> ListRefunds(string locationId,
        string? order,
        string? beginTime,
        string? endTime,
        int? limit,
        string? batchToken,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/refunds"),
            [new TemplateParam("location_id", locationId)],
            [new Param("order", order),
                new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("limit", limit),
                new Param("batch_token", batchToken)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V1Refund>>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListSettlements
    /// </summary>
    /// <param name="locationId">The ID of the location to list settlements for. If you specify me, this endpoint returns settlements aggregated from all of the business's locations.</param>
    /// <param name="order">The order in which settlements are listed in the response.</param>
    /// <param name="beginTime">The beginning of the requested reporting period, in ISO 8601 format. If this value is before January 1, 2013 (2013-01-01T00:00:00Z), this endpoint returns an error. Default value: The current time minus one year.</param>
    /// <param name="endTime">The end of the requested reporting period, in ISO 8601 format. If this value is more than one year greater than begin_time, this endpoint returns an error. Default value: The current time.</param>
    /// <param name="limit">The maximum number of settlements to return in a single response. This value cannot exceed 200.</param>
    /// <param name="status">Provide this parameter to retrieve only settlements with a particular status (SENT or FAILED).</param>
    /// <param name="batchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V1Settlement"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides summary information for all deposits and withdrawals
    /// initiated by Square to a linked bank account during a date range. Date
    /// ranges cannot exceed one year in length.
    /// <para>
    /// *Note**: the ListSettlements endpoint does not provide entry
    /// information.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<V1Settlement>> ListSettlements(string locationId,
        string? order,
        string? beginTime,
        string? endTime,
        int? limit,
        string? status,
        string? batchToken,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/settlements"),
            [new TemplateParam("location_id", locationId)],
            [new Param("order", order),
                new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("limit", limit),
                new Param("status", status),
                new Param("batch_token", batchToken)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V1Settlement>>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveOrder
    /// </summary>
    /// <param name="locationId">The ID of the order's associated location.</param>
    /// <param name="orderId">The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides comprehensive information for a single online store order, including the order's history.
    /// </remarks>
    public Task<V1Order> RetrieveOrder(string locationId, string orderId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/orders/{order_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("order_id", orderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1Order>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrievePayment
    /// </summary>
    /// <param name="locationId">The ID of the payment's associated location.</param>
    /// <param name="paymentId">The Square-issued payment ID. payment_id comes from Payment objects returned by the List Payments endpoint, Settlement objects returned by the List Settlements endpoint, or Refund objects returned by the List Refunds endpoint.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Payment"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides comprehensive information for a single payment.
    /// </remarks>
    public Task<V1Payment> RetrievePayment(string locationId, string paymentId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/payments/{payment_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("payment_id", paymentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1Payment>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveSettlement
    /// </summary>
    /// <param name="locationId">The ID of the settlements's associated location.</param>
    /// <param name="settlementId">The settlement's Square-issued ID. You obtain this value from Settlement objects returned by the List Settlements endpoint.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Settlement"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides comprehensive information for a single settlement.
    /// <para>
    /// The returned <c>Settlement</c> objects include an <c>entries</c> field that lists
    /// the transactions that contribute to the settlement total. Most
    /// settlement entries correspond to a payment payout, but settlement
    /// entries are also generated for less common events, like refunds, manual
    /// adjustments, or chargeback holds.
    /// </para>
    /// <para>
    /// Square initiates its regular deposits as indicated in the
    /// <see href="https://squareup.com/help/us/en/article/3807">Deposit Options with Square</see>
    /// help article. Details for a regular deposit are usually not available
    /// from Connect API endpoints before 10 p.m. PST the same day.
    /// </para>
    /// <para>
    /// Square does not know when an initiated settlement <b>completes</b>, only
    /// whether it has failed. A completed settlement is typically reflected in
    /// a bank account within 3 business days, but in exceptional cases it may
    /// take longer.
    /// </para>
    /// </remarks>
    public Task<V1Settlement> RetrieveSettlement(string locationId,
        string settlementId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/settlements/{settlement_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("settlement_id", settlementId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1Settlement>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateOrder
    /// </summary>
    /// <param name="locationId">The ID of the order's associated location.</param>
    /// <param name="orderId">The order's Square-issued ID. You obtain this value from Order objects returned by the List Orders endpoint</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the details of an online store order. Every update you perform on an order corresponds to one of three actions:
    /// </remarks>
    public Task<V1Order> UpdateOrder(string locationId,
        string orderId,
        V1UpdateOrderRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/{location_id}/orders/{order_id}"),
            [new TemplateParam("location_id", locationId), new TemplateParam("order_id", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1Order>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
