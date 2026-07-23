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

public sealed class GiftCardActivities
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GiftCardActivities(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateGiftCardActivity
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateGiftCardActivityResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a gift card activity. For more information, see
    /// <see href="https://developer.squareup.com/docs/gift-cards/using-gift-cards-api#giftcardactivity">GiftCardActivity</see> and
    /// <see href="https://developer.squareup.com/docs/gift-cards/using-gift-cards-api#using-activated-gift-cards">Using activated gift cards</see>.
    /// </remarks>
    public Task<CreateGiftCardActivityResponse> CreateGiftCardActivity(CreateGiftCardActivityRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/activities"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateGiftCardActivityResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListGiftCardActivities
    /// </summary>
    /// <param name="giftCardId">If you provide a gift card ID, the endpoint returns activities that belong  to the specified gift card. Otherwise, the endpoint returns all gift card activities for  the seller.</param>
    /// <param name="type">If you provide a type, the endpoint returns gift card activities of this type.  Otherwise, the endpoint returns all types of gift card activities.</param>
    /// <param name="locationId">If you provide a location ID, the endpoint returns gift card activities for that location.  Otherwise, the endpoint returns gift card activities for all locations.</param>
    /// <param name="beginTime">The timestamp for the beginning of the reporting period, in RFC 3339 format. Inclusive. Default: The current time minus one year.</param>
    /// <param name="endTime">The timestamp for the end of the reporting period, in RFC 3339 format. Inclusive. Default: The current time.</param>
    /// <param name="limit">If you provide a limit value, the endpoint returns the specified number  of results (or less) per page. A maximum value is 100. The default value is 50.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. If you do not provide the cursor, the call returns the first page of the results.</param>
    /// <param name="sortOrder">The order in which the endpoint returns the activities, based on <c>created_at</c>. - <c>ASC</c> - Oldest to newest. - <c>DESC</c> - Newest to oldest (default).</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListGiftCardActivitiesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists gift card activities. By default, you get gift card activities for all
    /// gift cards in the seller's account. You can optionally specify query parameters to
    /// filter the list. For example, you can get a list of gift card activities for a gift card,
    /// for all gift cards in a specific region, or for activities within a time window.
    /// </remarks>
    public Task<ListGiftCardActivitiesResponse> ListGiftCardActivities(string? giftCardId,
        string? type,
        string? locationId,
        string? beginTime,
        string? endTime,
        int? limit,
        string? cursor,
        string? sortOrder,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/activities"),
            [],
            [new Param("gift_card_id", giftCardId),
                new Param("type", type),
                new Param("location_id", locationId),
                new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("sort_order", sortOrder)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListGiftCardActivitiesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
