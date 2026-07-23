using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The response to a request for <c>Shift</c> objects. The response contains
/// the requested <c>Shift</c> objects and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record SearchShiftsResponse
{
    /// <summary>
    /// An opaque cursor for fetching the next page.
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
    /// Shifts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shifts")]
    public IReadOnlyList<Shift>? Shifts { get; init; }
}
