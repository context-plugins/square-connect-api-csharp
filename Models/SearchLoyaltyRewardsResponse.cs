using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that includes the loyalty rewards satisfying the search criteria.
/// </summary>
public record SearchLoyaltyRewardsResponse
{
    /// <summary>
    /// The pagination cursor to be used in a subsequent
    /// request. If empty, this is the final response.
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
    /// The loyalty rewards that satisfy the search criteria.
    /// These are returned in descending order by <c>updated_at</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rewards")]
    public IReadOnlyList<LoyaltyReward>? Rewards { get; init; }
}
