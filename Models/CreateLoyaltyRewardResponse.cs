using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that includes the loyalty reward created.
/// </summary>
public record CreateLoyaltyRewardResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a contract to redeem loyalty points for a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgramRewardTier">reward tier</see> discount. Loyalty rewards can be in an ISSUED, REDEEMED, or DELETED state. For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/overview#redeem-loyalty-rewards">Redeem loyalty rewards</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reward")]
    public LoyaltyReward? Reward { get; init; }
}
