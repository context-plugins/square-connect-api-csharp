using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A range defined by two dates. Used for filtering a query for Connect v2
/// objects that have date properties.
/// </summary>
public record DateRange
{
    /// <summary>
    /// A string in <c>YYYY-MM-DD</c> format, such as <c>2017-10-31</c>, per the ISO 8601
    /// extended format for calendar dates.
    /// The end of a date range (inclusive).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public string? EndDate { get; init; }

    /// <summary>
    /// A string in <c>YYYY-MM-DD</c> format, such as <c>2017-10-31</c>, per the ISO 8601
    /// extended format for calendar dates.
    /// The beginning of a date range (inclusive).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }
}
