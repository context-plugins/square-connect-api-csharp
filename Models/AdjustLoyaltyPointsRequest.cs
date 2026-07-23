using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to adjust (add or subtract) points manually.
/// </summary>
public record AdjustLoyaltyPointsRequest
{
    /// <summary>
    /// Provides metadata when the event <c>type</c> is <c>ADJUST_POINTS</c>.
    /// </summary>
    [JsonPropertyName("adjust_points")]
    public required LoyaltyEventAdjustPoints AdjustPoints { get; init; }

    /// <summary>
    /// A unique string that identifies this <c>AdjustLoyaltyPoints</c> request.
    /// Keys can be any valid string, but must be unique for every request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
