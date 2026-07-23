using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to accumulate points for a purchase.
/// </summary>
public record AccumulateLoyaltyPointsRequest
{
    /// <summary>
    /// Provides metadata when the event <c>type</c> is <c>ACCUMULATE_POINTS</c>.
    /// </summary>
    [JsonPropertyName("accumulate_points")]
    public required LoyaltyEventAccumulatePoints AccumulatePoints { get; init; }

    /// <summary>
    /// A unique string that identifies the <c>AccumulateLoyaltyPoints</c> request.
    /// Keys can be any valid string but must be unique for every request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">location</see> where the purchase was made.
    /// </summary>
    [JsonPropertyName("location_id")]
    public required string LocationId { get; init; }
}
