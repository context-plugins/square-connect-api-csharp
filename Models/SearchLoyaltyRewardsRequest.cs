using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to search for loyalty rewards.
/// </summary>
public record SearchLoyaltyRewardsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to
    /// this endpoint. Provide this to retrieve the next set of
    /// results for the original query.
    /// For more information,
    /// see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(30)]
    public int? Limit { get; init; }

    /// <summary>
    /// The set of search requirements.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchLoyaltyRewardsRequestLoyaltyRewardQuery? Query { get; init; }
}
