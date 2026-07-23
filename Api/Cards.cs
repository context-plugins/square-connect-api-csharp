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

public sealed class Cards
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Cards(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateCard
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a card on file to an existing merchant.
    /// </remarks>
    public Task<CreateCardResponse> CreateCard(CreateCardRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/cards"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DisableCard
    /// </summary>
    /// <param name="cardId">Unique ID for the desired Card.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisableCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disables the card, preventing any further updates or charges.
    /// Disabling an already disabled card is allowed but has no effect.
    /// </remarks>
    public Task<DisableCardResponse> DisableCard(string cardId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/cards/{card_id}/disable"),
            [new TemplateParam("card_id", cardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DisableCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListCards
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see> for more information.</param>
    /// <param name="customerId">Limit results to cards associated with the customer supplied. By default, all cards owned by the merchant are returned.</param>
    /// <param name="includeDisabled">Includes disabled cards. By default, all enabled cards owned by the merchant are returned.</param>
    /// <param name="referenceId">Limit results to cards associated with the reference_id supplied.</param>
    /// <param name="sortOrder">Sorts the returned list by when the card was created with the specified order. This field defaults to ASC.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCardsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of cards owned by the account making the request.
    /// A max of 25 cards will be returned.
    /// </remarks>
    public Task<ListCardsResponse> ListCards(string? cursor,
        string? customerId,
        bool? includeDisabled,
        string? referenceId,
        string? sortOrder,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/cards"),
            [],
            [new Param("cursor", cursor),
                new Param("customer_id", customerId),
                new Param("include_disabled", includeDisabled),
                new Param("reference_id", referenceId),
                new Param("sort_order", sortOrder)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCardsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveCard
    /// </summary>
    /// <param name="cardId">Unique ID for the desired Card.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves details for a specific Card.
    /// </remarks>
    public Task<RetrieveCardResponse> RetrieveCard(string cardId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/cards/{card_id}"),
            [new TemplateParam("card_id", cardId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
