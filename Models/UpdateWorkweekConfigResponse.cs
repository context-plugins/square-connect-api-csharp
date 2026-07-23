using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The response to a request to update a <c>WorkweekConfig</c> object. The response contains
/// the updated <c>WorkweekConfig</c> object and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record UpdateWorkweekConfigResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Sets the day of the week and hour of the day that a business starts a
    /// workweek. This is used to calculate overtime pay.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workweek_config")]
    public WorkweekConfig? WorkweekConfig { get; init; }
}
