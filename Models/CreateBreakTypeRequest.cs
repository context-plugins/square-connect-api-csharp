using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to create a new <c>BreakType</c>.
/// </summary>
public record CreateBreakTypeRequest
{
    /// <summary>
    /// A defined break template that sets an expectation for possible <c>Break</c>
    /// instances on a <c>Shift</c>.
    /// </summary>
    [JsonPropertyName("break_type")]
    public required BreakType BreakType { get; init; }

    /// <summary>
    /// A unique string value to ensure the idempotency of the operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }
}
