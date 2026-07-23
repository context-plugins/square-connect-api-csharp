using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The response to a request for a set of <c>WorkweekConfig</c> objects. The response contains
/// the requested <c>WorkweekConfig</c> objects and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record ListWorkweekConfigsResponse
{
    /// <summary>
    /// The value supplied in the subsequent request to fetch the next page of
    /// <c>EmployeeWage</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A page of <c>EmployeeWage</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workweek_configs")]
    public IReadOnlyList<WorkweekConfig>? WorkweekConfigs { get; init; }
}
