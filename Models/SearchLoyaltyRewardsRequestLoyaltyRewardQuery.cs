using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The set of search requirements.
/// </summary>
public record SearchLoyaltyRewardsRequestLoyaltyRewardQuery
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount">loyalty account</see> to which the loyalty reward belongs.
    /// </summary>
    [JsonPropertyName("loyalty_account_id")]
    public required string LoyaltyAccountId { get; init; }

    /// <summary>
    /// The status of the loyalty reward.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
