using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a time period - either a single period or a repeating period.
/// </summary>
public record CatalogTimePeriod
{
    /// <summary>
    /// An iCalendar (RFC 5545) <see href="https://tools.ietf.org/html/rfc5545#section-3.6.1">event</see>, which
    /// specifies the name, timing, duration and recurrence of this time period.
    /// <para>
    /// Example:
    /// </para>
    /// <code>
    /// DTSTART:20190707T180000
    /// DURATION:P2H
    /// RRULE:FREQ=WEEKLY;BYDAY=MO,WE,FR
    /// </code>
    /// <para>
    /// Only <c>SUMMARY</c>, <c>DTSTART</c>, <c>DURATION</c> and <c>RRULE</c> fields are supported.
    /// <c>DTSTART</c> must be in local (unzoned) time format. Note that while <c>BEGIN:VEVENT</c>
    /// and <c>END:VEVENT</c> is not required in the request. The response will always
    /// include them.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public string? Event { get; init; }
}
