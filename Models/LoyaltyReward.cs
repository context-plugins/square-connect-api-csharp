using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a contract to redeem loyalty points for a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgramRewardTier">reward tier</see> discount. Loyalty rewards can be in an ISSUED, REDEEMED, or DELETED state. For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/overview#redeem-loyalty-rewards">Redeem loyalty rewards</see>.
/// </summary>
public record LoyaltyReward
{
    /// <summary>
    /// The timestamp when the reward was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The Square-assigned ID of the loyalty reward.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(36)]
    public string? Id { get; init; }

    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount">loyalty account</see> to which the reward belongs.
    /// </summary>
    [JsonPropertyName("loyalty_account_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string LoyaltyAccountId { get; init; }

    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> to which the reward is attached.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// The number of loyalty points used for the reward.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points")]
    [Minimum(1)]
    public int? Points { get; init; }

    /// <summary>
    /// The timestamp when the reward was redeemed, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redeemed_at")]
    public string? RedeemedAt { get; init; }

    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgramRewardTier">reward tier</see> used to create the reward.
    /// </summary>
    [JsonPropertyName("reward_tier_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string RewardTierId { get; init; }

    /// <summary>
    /// The status of a loyalty reward.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The timestamp when the reward was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
