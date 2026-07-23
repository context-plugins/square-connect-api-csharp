using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a reward that can be applied to an order if the necessary
/// reward tier criteria are met. Rewards are created through the Loyalty API.
/// </summary>
public record OrderReward
{
    /// <summary>
    /// The identifier of the reward.
    /// </summary>
    [JsonPropertyName("id")]
    [MinLength(1)]
    public required string Id { get; init; }

    /// <summary>
    /// The identifier of the reward tier corresponding to this reward.
    /// </summary>
    [JsonPropertyName("reward_tier_id")]
    [MinLength(1)]
    public required string RewardTierId { get; init; }
}
