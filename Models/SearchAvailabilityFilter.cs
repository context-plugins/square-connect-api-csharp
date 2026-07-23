using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A query filter to search for availabilities by.
/// </summary>
public record SearchAvailabilityFilter
{
    /// <summary>
    /// The query expression to search for availabilities for an existing booking by matching the specified <c>booking_id</c> value.
    /// This is commonly used to reschedule an appointment.
    /// If this expression is specified, the <c>location_id</c> and <c>segment_filters</c> expressions are not allowed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_id")]
    public string? BookingId { get; init; }

    /// <summary>
    /// The query expression to search for availabilities matching the specified seller location IDs.
    /// This query expression is not applicable when <c>booking_id</c> is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The list of segment filters to apply. A query with <c>n</c> segment filters returns availabilities with <c>n</c> segments per
    /// availability. It is not applicable when <c>booking_id</c> is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segment_filters")]
    public IReadOnlyList<SegmentFilter>? SegmentFilters { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonPropertyName("start_at_range")]
    public required TimeRange StartAtRange { get; init; }
}
