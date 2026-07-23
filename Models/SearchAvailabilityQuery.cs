using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Query conditions to search for availabilities of bookings.
/// </summary>
public record SearchAvailabilityQuery
{
    /// <summary>
    /// A query filter to search for availabilities by.
    /// </summary>
    [JsonPropertyName("filter")]
    public required SearchAvailabilityFilter Filter { get; init; }
}
