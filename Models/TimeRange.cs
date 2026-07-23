using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a generic time range. The start and end values are
/// represented in RFC 3339 format. Time ranges are customized to be
/// inclusive or exclusive based on the needs of a particular endpoint.
/// Refer to the relevant endpoint-specific documentation to determine
/// how time ranges are handled.
/// </summary>
public record TimeRange
{
    /// <summary>
    /// A datetime value in RFC 3339 format indicating when the time range
    /// ends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_at")]
    public string? EndAt { get; init; }

    /// <summary>
    /// A datetime value in RFC 3339 format indicating when the time range
    /// starts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_at")]
    public string? StartAt { get; init; }
}
