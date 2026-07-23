using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A record of the hourly rate, start, and end times for a single work shift
/// for an employee. This might include a record of the start and end times for breaks
/// taken during the shift.
/// </summary>
public record Shift
{
    /// <summary>
    /// A list of all the paid or unpaid breaks that were taken during this shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("breaks")]
    public IReadOnlyList<Break>? Breaks { get; init; }

    /// <summary>
    /// A read-only timestamp in RFC 3339 format; presented in UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The ID of the employee this shift belongs to. DEPRECATED at version 2020-08-26. Use <c>team_member_id</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; init; }

    /// <summary>
    /// RFC 3339; shifted to the timezone + offset. Precision up to the minute is
    /// respected; seconds are truncated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_at")]
    public string? EndAt { get; init; }

    /// <summary>
    /// The UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// The ID of the location this shift occurred at. The location should be based on
    /// where the employee clocked in.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// RFC 3339; shifted to the location timezone + offset. Precision up to the
    /// minute is respected; seconds are truncated.
    /// </summary>
    [JsonPropertyName("start_at")]
    [MinLength(1)]
    public required string StartAt { get; init; }

    /// <summary>
    /// Describes the working state of the current <c>Shift</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The ID of the team member this shift belongs to. Replaced <c>employee_id</c> at version "2020-08-26".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The read-only convenience value that is calculated from the location based
    /// on the <c>location_id</c>. Format: the IANA timezone database identifier for the
    /// location timezone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// A read-only timestamp in RFC 3339 format; presented in UTC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// Used for resolving concurrency issues. The request fails if the version
    /// provided does not match the server version at the time of the request. If not provided,
    /// Square executes a blind write; potentially overwriting data from another
    /// write.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>
    /// The hourly wage rate used to compensate an employee for this shift.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wage")]
    public ShiftWage? Wage { get; init; }
}
