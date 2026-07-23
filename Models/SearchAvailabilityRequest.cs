using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record SearchAvailabilityRequest
{
    /// <summary>
    /// Query conditions to search for availabilities of bookings.
    /// </summary>
    [JsonPropertyName("query")]
    public required SearchAvailabilityQuery Query { get; init; }
}
