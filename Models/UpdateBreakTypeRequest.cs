using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to update a <c>BreakType</c>.
/// </summary>
public record UpdateBreakTypeRequest
{
    /// <summary>
    /// A defined break template that sets an expectation for possible <c>Break</c>
    /// instances on a <c>Shift</c>.
    /// </summary>
    [JsonPropertyName("break_type")]
    public required BreakType BreakType { get; init; }
}
