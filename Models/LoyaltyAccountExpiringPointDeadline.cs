using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a set of points for a loyalty account that are scheduled to expire on a specific date.
/// </summary>
public record LoyaltyAccountExpiringPointDeadline
{
    /// <summary>
    /// The timestamp of when the points are scheduled to expire, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("expires_at")]
    [MinLength(1)]
    public required string ExpiresAt { get; init; }

    /// <summary>
    /// The number of points scheduled to expire at the <c>expires_at</c> timestamp.
    /// </summary>
    [JsonPropertyName("points")]
    public required int Points { get; init; }
}
