using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines a filter used in a search for <c>Shift</c> records. <c>AND</c> logic is
/// used by Square's servers to apply each filter property specified.
/// </summary>
public record ShiftFilter
{
    /// <summary>
    /// Fetch shifts for the specified employees. DEPRECATED at version 2020-08-26. Use <c>team_member_ids</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_ids")]
    public IReadOnlyList<string>? EmployeeIds { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end")]
    public TimeRange? End { get; init; }

    /// <summary>
    /// Fetch shifts for the specified location.
    /// </summary>
    [JsonPropertyName("location_ids")]
    public required IReadOnlyList<string> LocationIds { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start")]
    public TimeRange? Start { get; init; }

    /// <summary>
    /// Fetch a <c>Shift</c> instance by <c>Shift.status</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// Fetch shifts for the specified team members. Replaced <c>employee_ids</c> at version "2020-08-26".
    /// </summary>
    [JsonPropertyName("team_member_ids")]
    public required IReadOnlyList<string> TeamMemberIds { get; init; }

    /// <summary>
    /// A <c>Shift</c> search query filter parameter that sets a range of days that
    /// a <c>Shift</c> must start or end in before passing the filter condition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workday")]
    public ShiftWorkday? Workday { get; init; }
}
