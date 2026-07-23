using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record SearchAvailabilityResponse
{
    /// <summary>
    /// List of slots available for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availabilities")]
    public IReadOnlyList<Availability>? Availabilities { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
