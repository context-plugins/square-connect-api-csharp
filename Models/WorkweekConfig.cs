using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Sets the day of the week and hour of the day that a business starts a
/// workweek. This is used to calculate overtime pay.
/// </summary>
public record WorkweekConfig
{
    /// <summary>
    /// A read-only timestamp in RFC 3339 format; presented in UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The local time at which a business week ends. Represented as a
    /// string in <c>HH:MM</c> format (<c>HH:MM:SS</c> is also accepted, but seconds are
    /// truncated).
    /// </summary>
    [JsonPropertyName("start_of_day_local_time")]
    [MinLength(1)]
    public required string StartOfDayLocalTime { get; init; }

    /// <summary>
    /// The day of the week on which a business week ends for
    /// compensation purposes.
    /// </summary>
    [JsonPropertyName("start_of_week")]
    public required string StartOfWeek { get; init; }

    /// <summary>
    /// A read-only timestamp in RFC 3339 format; presented in UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// Used for resolving concurrency issues. The request fails if the version
    /// provided does not match the server version at the time of the request. If not provided,
    /// Square executes a blind write; potentially overwriting data from another
    /// write.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
