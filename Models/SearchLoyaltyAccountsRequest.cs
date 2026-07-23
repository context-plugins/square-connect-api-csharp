using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to search for loyalty accounts.
/// </summary>
public record SearchLoyaltyAccountsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to
    /// this endpoint. Provide this to retrieve the next set of
    /// results for the original query.
    /// <para>
    /// For more information,
    /// see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to include in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(30)]
    public int? Limit { get; init; }

    /// <summary>
    /// The search criteria for the loyalty accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchLoyaltyAccountsRequestLoyaltyAccountQuery? Query { get; init; }
}
