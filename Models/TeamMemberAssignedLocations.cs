using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// An object that represents a team member's assignment to locations.
/// </summary>
public record TeamMemberAssignedLocations
{
    /// <summary>
    /// The current assignment type of the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignment_type")]
    public string? AssignmentType { get; init; }

    /// <summary>
    /// The locations that the team member is assigned to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string>? LocationIds { get; init; }
}
