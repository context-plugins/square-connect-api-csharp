using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Response object returned by ListBankAccounts.
/// </summary>
public record ListBankAccountsResponse
{
    /// <summary>
    /// List of BankAccounts associated with this account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_accounts")]
    public IReadOnlyList<BankAccount>? BankAccounts { get; init; }

    /// <summary>
    /// When a response is truncated, it includes a cursor that you can
    /// use in a subsequent request to fetch next set of bank accounts.
    /// If empty, this is the final response.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
