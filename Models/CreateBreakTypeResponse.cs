using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The response to the request to create a <c>BreakType</c>. The response contains
/// the created <c>BreakType</c> object and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record CreateBreakTypeResponse
{
    /// <summary>
    /// A defined break template that sets an expectation for possible <c>Break</c>
    /// instances on a <c>Shift</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("break_type")]
    public BreakType? BreakType { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
