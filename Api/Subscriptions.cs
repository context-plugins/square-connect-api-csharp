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

public sealed class Subscriptions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Subscriptions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CancelSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to cancel.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets the <c>canceled_date</c> field to the end of the active billing period.
    /// After this date, the status changes from ACTIVE to CANCELED.
    /// </remarks>
    public Task<CancelSubscriptionResponse> CancelSubscription(string subscriptionId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/cancel"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<CancelSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateSubscription
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a subscription for a customer to a subscription plan.
    /// <para>
    /// If you provide a card on file in the request, Square charges the card for
    /// the subscription. Otherwise, Square bills an invoice to the customer's email
    /// address. The subscription starts immediately, unless the request includes
    /// the optional <c>start_date</c>. Each individual subscription is associated with a particular location.
    /// </para>
    /// </remarks>
    public Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscriptionRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListSubscriptionEvents
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to retrieve the events for.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="limit">The upper limit on the number of subscription events to return in the response.  Default: <c>200</c></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListSubscriptionEventsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all events for a specific subscription.
    /// In the current implementation, only <c>START_SUBSCRIPTION</c> and <c>STOP_SUBSCRIPTION</c> (when the subscription was canceled) events are returned.
    /// </remarks>
    public Task<ListSubscriptionEventsResponse> ListSubscriptionEvents(string subscriptionId,
        string? cursor,
        int? limit,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/events"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListSubscriptionEventsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ResumeSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to resume.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ResumeSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Resumes a deactivated subscription.
    /// </remarks>
    public Task<ResumeSubscriptionResponse> ResumeSubscription(string subscriptionId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}/resume"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<ResumeSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID of the subscription to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a subscription.
    /// </remarks>
    public Task<RetrieveSubscriptionResponse> RetrieveSubscription(string subscriptionId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchSubscriptions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchSubscriptionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for subscriptions.
    /// Results are ordered chronologically by subscription creation date. If
    /// the request specifies more than one location ID,
    /// the endpoint orders the result
    /// by location ID, and then by creation date within each location. If no locations are given
    /// in the query, all locations are searched.
    /// <para>
    /// You can also optionally specify <c>customer_ids</c> to search by customer.
    /// If left unset, all customers
    /// associated with the specified locations are returned.
    /// If the request specifies customer IDs, the endpoint orders results
    /// first by location, within location by customer ID, and within
    /// customer by subscription creation date.
    /// </para>
    /// <para>
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/overview#retrieve-subscriptions">Retrieve subscriptions</see>.
    /// </para>
    /// </remarks>
    public Task<SearchSubscriptionsResponse> SearchSubscriptions(SearchSubscriptionsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchSubscriptionsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateSubscription
    /// </summary>
    /// <param name="subscriptionId">The ID for the subscription to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateSubscriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a subscription. You can set, modify, and clear the
    /// <c>subscription</c> field values.
    /// </remarks>
    public Task<UpdateSubscriptionResponse> UpdateSubscription(string subscriptionId,
        UpdateSubscriptionRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/subscriptions/{subscription_id}"),
            [new TemplateParam("subscription_id", subscriptionId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateSubscriptionResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
