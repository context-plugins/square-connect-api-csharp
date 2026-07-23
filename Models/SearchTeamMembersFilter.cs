using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a filter used in a search for <c>TeamMember</c> objects. <c>AND</c> logic is applied
/// between the individual fields, and <c>OR</c> logic is applied within list-based fields.
/// For example, setting this filter value:
/// <code>
/// filter = (locations_ids = ["A", "B"], status = ACTIVE)
/// </code>
/// returns only active team members assigned to either location "A" or "B".
/// </summary>
public record SearchTeamMembersFilter
{
    /// <summary>
    /// When present, filters by team members assigned to the specified locations.
    /// When empty, includes team members assigned to any location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string>? LocationIds { get; init; }

    /// <summary>
    /// When present, filters by team members who match the given status.
    /// When empty, includes team members of all statuses.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
