using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the naming used for loyalty points.
/// </summary>
public record LoyaltyProgramTerminology
{
    /// <summary>
    /// A singular unit for a point (for example, 1 point is called 1 star).
    /// </summary>
    [JsonPropertyName("one")]
    [MinLength(1)]
    public required string One { get; init; }

    /// <summary>
    /// A plural unit for point (for example, 10 points is called 10 stars).
    /// </summary>
    [JsonPropertyName("other")]
    [MinLength(1)]
    public required string Other { get; init; }
}
