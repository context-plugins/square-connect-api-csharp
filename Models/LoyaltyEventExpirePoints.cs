using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>EXPIRE_POINTS</c>.
/// </summary>
public record LoyaltyEventExpirePoints
{
    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonPropertyName("loyalty_program_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string LoyaltyProgramId { get; init; }

    /// <summary>
    /// The number of points expired.
    /// </summary>
    [JsonPropertyName("points")]
    [Maximum(0)]
    public required int Points { get; init; }
}
