using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a period of time during which a business location is open.
/// </summary>
public record BusinessHoursPeriod
{
    /// <summary>
    /// The day of week for this time period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("day_of_week")]
    public string? DayOfWeek { get; init; }

    /// <summary>
    /// The end time of a business hours period, specified in local time using partial-time
    /// RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_local_time")]
    public string? EndLocalTime { get; init; }

    /// <summary>
    /// The start time of a business hours period, specified in local time using partial-time
    /// RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_local_time")]
    public string? StartLocalTime { get; init; }
}
