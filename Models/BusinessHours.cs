using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the hours of operation for a business location.
/// </summary>
public record BusinessHours
{
    /// <summary>
    /// The list of time periods during which the business is open. There may be at most 10
    /// periods per day.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periods")]
    public IReadOnlyList<BusinessHoursPeriod>? Periods { get; init; }
}
