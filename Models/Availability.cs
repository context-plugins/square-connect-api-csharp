using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a slot available for booking, encapsulating appointment segments, the location and starting time.
/// </summary>
public record Availability
{
    /// <summary>
    /// The list of appointment segments available for booking
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appointment_segments")]
    public IReadOnlyList<AppointmentSegment>? AppointmentSegments { get; init; }

    /// <summary>
    /// The ID of the location available for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the beginning time of the slot available for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_at")]
    public string? StartAt { get; init; }
}
