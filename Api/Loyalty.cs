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

public sealed class Loyalty
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Loyalty(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// AccumulateLoyaltyPoints
    /// </summary>
    /// <param name="accountId">The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount">loyalty account</see> ID to which to add the points.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccumulateLoyaltyPointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds points to a loyalty account.
    /// <para>
    /// - If you are using the Orders API to manage orders, you only provide the <c>order_id</c>.
    /// The endpoint reads the order to compute points to add to the buyer's account.
    /// - If you are not using the Orders API to manage orders,
    /// you first perform a client-side computation to compute the points.
    /// For spend-based and visit-based programs, you can first call
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/calculate-loyalty-points">CalculateLoyaltyPoints</see> to compute the points
    /// that you provide to this endpoint.
    /// </para>
    /// <para>
    /// __Note:__ The country of the seller's Square account determines whether tax is included in the purchase amount when accruing points for spend-based and visit-based programs.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/overview#loyalty-market-availability">Availability of Square Loyalty</see>.
    /// </para>
    /// </remarks>
    public Task<AccumulateLoyaltyPointsResponse> AccumulateLoyaltyPoints(string accountId,
        AccumulateLoyaltyPointsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/{account_id}/accumulate"),
            [new TemplateParam("account_id", accountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccumulateLoyaltyPointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// AdjustLoyaltyPoints
    /// </summary>
    /// <param name="accountId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount">loyalty account</see> in which to adjust the points.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdjustLoyaltyPointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds points to or subtracts points from a buyer's account.
    /// <para>
    /// Use this endpoint only when you need to manually adjust points. Otherwise, in your application flow, you call
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/accumulate-loyalty-points">AccumulateLoyaltyPoints</see>
    /// to add points when a buyer pays for the purchase.
    /// </para>
    /// </remarks>
    public Task<AdjustLoyaltyPointsResponse> AdjustLoyaltyPoints(string accountId,
        AdjustLoyaltyPointsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/{account_id}/adjust"),
            [new TemplateParam("account_id", accountId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AdjustLoyaltyPointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CalculateLoyaltyPoints
    /// </summary>
    /// <param name="programId">The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgram">loyalty program</see> ID, which defines the rules for accruing points.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculateLoyaltyPointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculates the points a purchase earns.
    /// <para>
    /// - If you are using the Orders API to manage orders, you provide <c>order_id</c> in the request. The
    /// endpoint calculates the points by reading the order.
    /// - If you are not using the Orders API to manage orders, you provide the purchase amount in
    /// the request for the endpoint to calculate the points.
    /// </para>
    /// <para>
    /// An application might call this endpoint to show the points that a buyer can earn with the
    /// specific purchase.
    /// </para>
    /// <para>
    /// __Note:__ The country of the seller's Square account determines whether tax is included in the purchase amount when accruing points for spend-based and visit-based programs.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/overview#loyalty-market-availability">Availability of Square Loyalty</see>.
    /// </para>
    /// </remarks>
    public Task<CalculateLoyaltyPointsResponse> CalculateLoyaltyPoints(string programId,
        CalculateLoyaltyPointsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}/calculate"),
            [new TemplateParam("program_id", programId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CalculateLoyaltyPointsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateLoyaltyAccount
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateLoyaltyAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a loyalty account. To create a loyalty account, you must provide the <c>program_id</c> and a <c>mapping</c> with the <c>phone_number</c> of the buyer.
    /// </remarks>
    public Task<CreateLoyaltyAccountResponse> CreateLoyaltyAccount(CreateLoyaltyAccountRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateLoyaltyAccountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateLoyaltyReward
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a loyalty reward. In the process, the endpoint does following:
    /// <para>
    /// - Uses the <c>reward_tier_id</c> in the request to determine the number of points
    /// to lock for this reward.
    /// - If the request includes <c>order_id</c>, it adds the reward and related discount to the order.
    /// </para>
    /// <para>
    /// After a reward is created, the points are locked and
    /// not available for the buyer to redeem another reward.
    /// </para>
    /// </remarks>
    public Task<CreateLoyaltyRewardResponse> CreateLoyaltyReward(CreateLoyaltyRewardRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteLoyaltyReward
    /// </summary>
    /// <param name="rewardId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyReward">loyalty reward</see> to delete.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a loyalty reward by doing the following:
    /// <para>
    /// - Returns the loyalty points back to the loyalty account.
    /// - If an order ID was specified when the reward was created
    /// (see <see href="https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/create-loyalty-reward">CreateLoyaltyReward</see>),
    /// it updates the order by removing the reward and related
    /// discounts.
    /// </para>
    /// <para>
    /// You cannot delete a reward that has reached the terminal state (REDEEMED).
    /// </para>
    /// </remarks>
    public Task<DeleteLoyaltyRewardResponse> DeleteLoyaltyReward(string rewardId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/{reward_id}"),
            [new TemplateParam("reward_id", rewardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListLoyaltyPrograms
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListLoyaltyProgramsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of loyalty programs in the seller's account.
    /// Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
    /// <para>
    ///
    /// Replaced with <see href="https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/retrieve-loyalty-program">RetrieveLoyaltyProgram</see> when used with the keyword <c>main</c>.
    /// </para>
    /// </remarks>
    public Task<ListLoyaltyProgramsResponse> ListLoyaltyPrograms(CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListLoyaltyProgramsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RedeemLoyaltyReward
    /// </summary>
    /// <param name="rewardId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyReward">loyalty reward</see> to redeem.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RedeemLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Redeems a loyalty reward.
    /// <para>
    /// The endpoint sets the reward to the <c>REDEEMED</c> terminal state.
    /// </para>
    /// <para>
    /// If you are using your own order processing system (not using the
    /// Orders API), you call this endpoint after the buyer paid for the
    /// purchase.
    /// </para>
    /// <para>
    /// After the reward reaches the terminal state, it cannot be deleted.
    /// In other words, points used for the reward cannot be returned
    /// to the account.
    /// </para>
    /// </remarks>
    public Task<RedeemLoyaltyRewardResponse> RedeemLoyaltyReward(string rewardId,
        RedeemLoyaltyRewardRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/{reward_id}/redeem"),
            [new TemplateParam("reward_id", rewardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RedeemLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveLoyaltyAccount
    /// </summary>
    /// <param name="accountId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount">loyalty account</see> to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLoyaltyAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a loyalty account.
    /// </remarks>
    public Task<RetrieveLoyaltyAccountResponse> RetrieveLoyaltyAccount(string accountId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/{account_id}"),
            [new TemplateParam("account_id", accountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLoyaltyAccountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveLoyaltyProgram
    /// </summary>
    /// <param name="programId">The ID of the loyalty program or the keyword <c>main</c>. Either value can be used to retrieve the single loyalty program that belongs to the seller.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLoyaltyProgramResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the loyalty program in a seller's account, specified by the program ID or the keyword <c>main</c>.
    /// <para>
    /// Loyalty programs define how buyers can earn points and redeem points for rewards. Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard. For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
    /// </para>
    /// </remarks>
    public Task<RetrieveLoyaltyProgramResponse> RetrieveLoyaltyProgram(string programId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/programs/{program_id}"),
            [new TemplateParam("program_id", programId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLoyaltyProgramResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveLoyaltyReward
    /// </summary>
    /// <param name="rewardId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyReward">loyalty reward</see> to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveLoyaltyRewardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a loyalty reward.
    /// </remarks>
    public Task<RetrieveLoyaltyRewardResponse> RetrieveLoyaltyReward(string rewardId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/{reward_id}"),
            [new TemplateParam("reward_id", rewardId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveLoyaltyRewardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchLoyaltyAccounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchLoyaltyAccountsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for loyalty accounts in a loyalty program.
    /// <para>
    /// You can search for a loyalty account using the phone number or customer ID associated with the account. To return all loyalty accounts, specify an empty <c>query</c> object or omit it entirely.
    /// </para>
    /// <para>
    /// Search results are sorted by <c>created_at</c> in ascending order.
    /// </para>
    /// </remarks>
    public Task<SearchLoyaltyAccountsResponse> SearchLoyaltyAccounts(SearchLoyaltyAccountsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/accounts/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchLoyaltyAccountsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchLoyaltyEvents
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchLoyaltyEventsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for loyalty events.
    /// <para>
    /// A Square loyalty program maintains a ledger of events that occur during the lifetime of a
    /// buyer's loyalty account. Each change in the point balance
    /// (for example, points earned, points redeemed, and points expired) is
    /// recorded in the ledger. Using this endpoint, you can search the ledger for events.
    /// </para>
    /// <para>
    /// Search results are sorted by <c>created_at</c> in descending order.
    /// </para>
    /// </remarks>
    public Task<SearchLoyaltyEventsResponse> SearchLoyaltyEvents(SearchLoyaltyEventsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/events/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchLoyaltyEventsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchLoyaltyRewards
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchLoyaltyRewardsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for loyalty rewards in a loyalty account.
    /// <para>
    /// In the current implementation, the endpoint supports search by the reward <c>status</c>.
    /// </para>
    /// <para>
    /// If you know a reward ID, use the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/loyalty-api/retrieve-loyalty-reward">RetrieveLoyaltyReward</see> endpoint.
    /// </para>
    /// <para>
    /// Search results are sorted by <c>updated_at</c> in descending order.
    /// </para>
    /// </remarks>
    public Task<SearchLoyaltyRewardsResponse> SearchLoyaltyRewards(SearchLoyaltyRewardsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/loyalty/rewards/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchLoyaltyRewardsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
