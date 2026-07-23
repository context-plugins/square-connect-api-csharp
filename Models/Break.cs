using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A record of an employee's break during a shift.
/// </summary>
public record Break
{
    /// <summary>
    /// The <c>BreakType</c> that this <c>Break</c> was templated on.
    /// </summary>
    [JsonPropertyName("break_type_id")]
    [MinLength(1)]
    public required string BreakTypeId { get; init; }

    /// <summary>
    /// RFC 3339; follows the same timezone information as <c>Shift</c>. Precision up to
    /// the minute is respected; seconds are truncated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_at")]
    public string? EndAt { get; init; }

    /// <summary>
    /// Format: RFC-3339 P[n]Y[n]M[n]DT[n]H[n]M[n]S. The expected length of
    /// the break.
    /// </summary>
    [JsonPropertyName("expected_duration")]
    [MinLength(1)]
    public required string ExpectedDuration { get; init; }

    /// <summary>
    /// The UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Whether this break counts towards time worked for compensation
    /// purposes.
    /// </summary>
    [JsonPropertyName("is_paid")]
    public required bool IsPaid { get; init; }

    /// <summary>
    /// A human-readable name.
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// RFC 3339; follows the same timezone information as <c>Shift</c>. Precision up to
    /// the minute is respected; seconds are truncated.
    /// </summary>
    [JsonPropertyName("start_at")]
    [MinLength(1)]
    public required string StartAt { get; init; }
}
