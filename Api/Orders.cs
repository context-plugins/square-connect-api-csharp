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

public sealed class Orders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Orders(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BatchRetrieveOrders
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a set of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">orders</see> by their IDs.
    /// <para>
    /// If a given order ID does not exist, the ID is ignored instead of generating an error.
    /// </para>
    /// </remarks>
    public Task<BatchRetrieveOrdersResponse> BatchRetrieveOrders(BatchRetrieveOrdersRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/batch-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchRetrieveOrdersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CalculateOrder
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculateOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Enables applications to preview order pricing without creating an order.
    /// </remarks>
    public Task<CalculateOrderResponse> CalculateOrder(CalculateOrderRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/calculate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CalculateOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateOrder
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> that can include information about products for
    /// purchase and settings to apply to the purchase.
    /// <para>
    /// To pay for a created order, see
    /// <see href="https://developer.squareup.com/docs/orders-api/pay-for-orders">Pay for Orders</see>.
    /// </para>
    /// <para>
    /// You can modify open orders using the <see href="https://developer.squareup.com/reference/square_2021-08-18/orders-api/update-order">UpdateOrder</see> endpoint.
    /// </para>
    /// </remarks>
    public Task<CreateOrderResponse> CreateOrder(CreateOrderRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// PayOrder
    /// </summary>
    /// <param name="orderId">The ID of the order being paid.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Pay for an <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> using one or more approved <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Payment">payments</see>
    /// or settle an order with a total of <c>0</c>.
    /// <para>
    /// The total of the <c>payment_ids</c> listed in the request must be equal to the order
    /// total. Orders with a total amount of <c>0</c> can be marked as paid by specifying an empty
    /// array of <c>payment_ids</c> in the request.
    /// </para>
    /// <para>
    /// To be used with <c>PayOrder</c>, a payment must:
    /// </para>
    /// <para>
    /// - Reference the order by specifying the <c>order_id</c> when <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/create-payment">creating the payment</see>.
    /// Any approved payments that reference the same <c>order_id</c> not specified in the
    /// <c>payment_ids</c> is canceled.
    /// - Be approved with <see href="https://developer.squareup.com/docs/payments-api/take-payments#delayed-capture">delayed capture</see>.
    /// Using a delayed capture payment with <c>PayOrder</c> completes the approved payment.
    /// </para>
    /// </remarks>
    public Task<PayOrderResponse> PayOrder(string orderId, PayOrderRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}/pay"),
            [new TemplateParam("order_id", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PayOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveOrder
    /// </summary>
    /// <param name="orderId">The ID of the order to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">Order</see> by ID.
    /// </remarks>
    public Task<RetrieveOrderResponse> RetrieveOrder(string orderId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}"),
            [new TemplateParam("order_id", orderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchOrders
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Search all orders for one or more locations. Orders include all sales,
    /// returns, and exchanges regardless of how or when they entered the Square
    /// ecosystem (such as Point of Sale, Invoices, and Connect APIs).
    /// <para>
    /// <c>SearchOrders</c> requests need to specify which locations to search and define a
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/SearchOrdersQuery">SearchOrdersQuery</see> object that controls
    /// how to sort or filter the results. Your <c>SearchOrdersQuery</c> can:
    /// </para>
    /// <para>
    ///   Set filter criteria.
    ///   Set the sort order.
    ///   Determine whether to return results as complete <c>Order</c> objects or as
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderEntry">OrderEntry</see> objects.
    /// </para>
    /// <para>
    /// Note that details for orders processed with Square Point of Sale while in
    /// offline mode might not be transmitted to Square for up to 72 hours. Offline
    /// orders have a <c>created_at</c> value that reflects the time the order was created,
    /// not the time it was subsequently transmitted to Square.
    /// </para>
    /// </remarks>
    public Task<SearchOrdersResponse> SearchOrders(SearchOrdersRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchOrdersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateOrder
    /// </summary>
    /// <param name="orderId">The ID of the order to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an open <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> by adding, replacing, or deleting
    /// fields. Orders with a <c>COMPLETED</c> or <c>CANCELED</c> state cannot be updated.
    /// <para>
    /// An <c>UpdateOrder</c> request requires the following:
    /// </para>
    /// <para>
    /// - The <c>order_id</c> in the endpoint path, identifying the order to update.
    /// - The latest <c>version</c> of the order to update.
    /// - The <see href="https://developer.squareup.com/docs/orders-api/manage-orders#sparse-order-objects">sparse order</see>
    /// containing only the fields to update and the version to which the update is
    /// being applied.
    /// - If deleting fields, the <see href="https://developer.squareup.com/docs/orders-api/manage-orders#on-dot-notation">dot notation paths</see>
    /// identifying the fields to clear.
    /// </para>
    /// <para>
    /// To pay for an order, see
    /// <see href="https://developer.squareup.com/docs/orders-api/pay-for-orders">Pay for Orders</see>.
    /// </para>
    /// </remarks>
    public Task<UpdateOrderResponse> UpdateOrder(string orderId,
        UpdateOrderRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}"),
            [new TemplateParam("order_id", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateOrderResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
