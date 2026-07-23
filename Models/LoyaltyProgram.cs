using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a Square loyalty program. Loyalty programs define how buyers can earn points and redeem points for rewards.
/// Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard.
/// For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
/// </summary>
public record LoyaltyProgram
{
    /// <summary>
    /// Defines how buyers can earn loyalty points.
    /// </summary>
    [JsonPropertyName("accrual_rules")]
    public required IReadOnlyList<LoyaltyProgramAccrualRule> AccrualRules { get; init; }

    /// <summary>
    /// The timestamp when the program was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("created_at")]
    [MinLength(1)]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// Describes when the loyalty program expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration_policy")]
    public LoyaltyProgramExpirationPolicy? ExpirationPolicy { get; init; }

    /// <summary>
    /// The Square-assigned ID of the loyalty program. Updates to
    /// the loyalty program do not modify the identifier.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(36, MinimumLength = 1)]
    public required string Id { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">locations</see> at which the program is active.
    /// </summary>
    [JsonPropertyName("location_ids")]
    public required IReadOnlyList<string> LocationIds { get; init; }

    /// <summary>
    /// The list of rewards for buyers, sorted by ascending points.
    /// </summary>
    [JsonPropertyName("reward_tiers")]
    public required IReadOnlyList<LoyaltyProgramRewardTier> RewardTiers { get; init; }

    /// <summary>
    /// Whether the program is currently active.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// Represents the naming used for loyalty points.
    /// </summary>
    [JsonPropertyName("terminology")]
    public required LoyaltyProgramTerminology Terminology { get; init; }

    /// <summary>
    /// The timestamp when the reward was last updated, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updated_at")]
    [MinLength(1)]
    public required string UpdatedAt { get; init; }
}
