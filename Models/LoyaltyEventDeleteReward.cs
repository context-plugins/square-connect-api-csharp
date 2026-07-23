using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>DELETE_REWARD</c>.
/// </summary>
public record LoyaltyEventDeleteReward
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonPropertyName("loyalty_program_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string LoyaltyProgramId { get; init; }

    /// <summary>
    /// The number of points returned to the loyalty account.
    /// </summary>
    [JsonPropertyName("points")]
    [Minimum(0)]
    public required int Points { get; init; }

    /// <summary>
    /// The ID of the deleted <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyReward">loyalty reward</see>.
    /// This field is returned only if the event source is <c>LOYALTY_API</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reward_id")]
    [MaxLength(36)]
    public string? RewardId { get; init; }
}
