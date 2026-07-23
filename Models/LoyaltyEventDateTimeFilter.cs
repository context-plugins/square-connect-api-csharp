using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Filter events by date time range.
/// </summary>
public record LoyaltyEventDateTimeFilter
{
    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required TimeRange CreatedAt { get; init; }
}
