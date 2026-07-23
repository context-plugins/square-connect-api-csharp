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

public sealed class GiftCards
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GiftCards(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateGiftCard
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a digital gift card or registers a physical (plastic) gift card. You must activate the gift card before
    /// it can be used for payment. For more information, see
    /// <see href="https://developer.squareup.com/docs/gift-cards/using-gift-cards-api#selling-square-gift-cards">Selling gift cards</see>.
    /// </remarks>
    public Task<CreateGiftCardResponse> CreateGiftCard(CreateGiftCardRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// LinkCustomerToGiftCard
    /// </summary>
    /// <param name="giftCardId">The ID of the gift card to link.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LinkCustomerToGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Links a customer to a gift card
    /// </remarks>
    public Task<LinkCustomerToGiftCardResponse> LinkCustomerToGiftCard(string giftCardId,
        LinkCustomerToGiftCardRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/{gift_card_id}/link-customer"),
            [new TemplateParam("gift_card_id", giftCardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LinkCustomerToGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListGiftCards
    /// </summary>
    /// <param name="type">If a type is provided, gift cards of this type are returned  (see <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/GiftCardType">GiftCardType</see>). If no type is provided, it returns gift cards of all types.</param>
    /// <param name="state">If the state is provided, it returns the gift cards in the specified state  (see <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/GiftCardStatus">GiftCardStatus</see>). Otherwise, it returns the gift cards of all states.</param>
    /// <param name="limit">If a value is provided, it returns only that number of results per page. The maximum number of results allowed per page is 50. The default value is 30.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. If a cursor is not provided, it returns the first page of the results.  For more information, see <see href="https://developer.squareup.com/docs/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="customerId">If a value is provided, returns only the gift cards linked to the specified customer</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListGiftCardsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all gift cards. You can specify optional filters to retrieve
    /// a subset of the gift cards.
    /// </remarks>
    public Task<ListGiftCardsResponse> ListGiftCards(string? type,
        string? state,
        int? limit,
        string? cursor,
        string? customerId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards"),
            [],
            [new Param("type", type),
                new Param("state", state),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("customer_id", customerId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListGiftCardsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveGiftCard
    /// </summary>
    /// <param name="id">The ID of the gift card to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a gift card using its ID.
    /// </remarks>
    public Task<RetrieveGiftCardResponse> RetrieveGiftCard(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveGiftCardFromGAN
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveGiftCardFromGanresponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a gift card using the gift card account number (GAN).
    /// </remarks>
    public Task<RetrieveGiftCardFromGanresponse> RetrieveGiftCardFromGan(RetrieveGiftCardFromGanrequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/from-gan"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RetrieveGiftCardFromGanresponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveGiftCardFromNonce
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveGiftCardFromNonceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a gift card using a nonce (a secure token) that represents the gift card.
    /// </remarks>
    public Task<RetrieveGiftCardFromNonceResponse> RetrieveGiftCardFromNonce(RetrieveGiftCardFromNonceRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/from-nonce"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RetrieveGiftCardFromNonceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UnlinkCustomerFromGiftCard
    /// </summary>
    /// <param name="giftCardId"></param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UnlinkCustomerFromGiftCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Unlinks a customer from a gift card
    /// </remarks>
    public Task<UnlinkCustomerFromGiftCardResponse> UnlinkCustomerFromGiftCard(string giftCardId,
        UnlinkCustomerFromGiftCardRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/gift-cards/{gift_card_id}/unlink-customer"),
            [new TemplateParam("gift_card_id", giftCardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UnlinkCustomerFromGiftCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
