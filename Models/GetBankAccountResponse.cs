using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Response object returned by <c>GetBankAccount</c>.
/// </summary>
public record GetBankAccountResponse
{
    /// <summary>
    /// Represents a bank account. For more information about
    /// linking a bank account to a Square account, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account")]
    public BankAccount? BankAccount { get; init; }

    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
