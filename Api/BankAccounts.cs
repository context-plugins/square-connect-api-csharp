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

public sealed class BankAccounts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal BankAccounts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// GetBankAccount
    /// </summary>
    /// <param name="bankAccountId">Square-issued ID of the desired <c>BankAccount</c>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetBankAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details of a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/BankAccount">BankAccount</see>
    /// linked to a Square account.
    /// </remarks>
    public Task<GetBankAccountResponse> GetBankAccount(string bankAccountId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bank-accounts/{bank_account_id}"),
            [new TemplateParam("bank_account_id", bankAccountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetBankAccountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetBankAccountByV1Id
    /// </summary>
    /// <param name="v1BankAccountId">Connect V1 ID of the desired <c>BankAccount</c>. For more information, see  <see href="https://developer.squareup.com/docs/bank-accounts-api#retrieve-a-bank-account-by-using-an-id-issued-by-v1-bank-accounts-api">Retrieve a bank account by using an ID issued by V1 Bank Accounts API</see>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetBankAccountByV1IdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details of a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/BankAccount">BankAccount</see> identified by V1 bank account ID.
    /// </remarks>
    public Task<GetBankAccountByV1IdResponse> GetBankAccountByV1Id(string v1BankAccountId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bank-accounts/by-v1-id/{v1_bank_account_id}"),
            [new TemplateParam("v1_bank_account_id", v1BankAccountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetBankAccountByV1IdResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListBankAccounts
    /// </summary>
    /// <param name="cursor">The pagination cursor returned by a previous call to this endpoint. Use it in the next <c>ListBankAccounts</c> request to retrieve the next set  of results.  See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.</param>
    /// <param name="limit">Upper limit on the number of bank accounts to return in the response.  Currently, 1000 is the largest supported limit. You can specify a limit  of up to 1000 bank accounts. This is also the default limit.</param>
    /// <param name="locationId">Location ID. You can specify this optional filter  to retrieve only the linked bank accounts belonging to a specific location.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBankAccountsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/BankAccount">BankAccount</see> objects linked to a Square account.
    /// </remarks>
    public Task<ListBankAccountsResponse> ListBankAccounts(string? cursor,
        int? limit,
        string? locationId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bank-accounts"),
            [],
            [new Param("cursor", cursor), new Param("limit", limit), new Param("location_id", locationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBankAccountsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
