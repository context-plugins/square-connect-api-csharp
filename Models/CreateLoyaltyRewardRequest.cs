using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to create a loyalty reward.
/// </summary>
public record CreateLoyaltyRewardRequest
{
    /// <summary>
    /// A unique string that identifies this <c>CreateLoyaltyReward</c> request.
    /// Keys can be any valid string, but must be unique for every request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents a contract to redeem loyalty points for a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgramRewardTier">reward tier</see> discount. Loyalty rewards can be in an ISSUED, REDEEMED, or DELETED state. For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/overview#redeem-loyalty-rewards">Redeem loyalty rewards</see>.
    /// </summary>
    [JsonPropertyName("reward")]
    public required LoyaltyReward Reward { get; init; }
}
