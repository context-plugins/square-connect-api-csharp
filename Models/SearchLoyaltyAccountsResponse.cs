using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that includes loyalty accounts that satisfy the search criteria.
/// </summary>
public record SearchLoyaltyAccountsResponse
{
    /// <summary>
    /// The pagination cursor to use in a subsequent
    /// request. If empty, this is the final response.
    /// For more information,
    /// see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The loyalty accounts that met the search criteria,
    /// in order of creation date.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_accounts")]
    public IReadOnlyList<LoyaltyAccount>? LoyaltyAccounts { get; init; }
}
