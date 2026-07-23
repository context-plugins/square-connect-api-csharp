using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the parameters in a search for <c>TeamMember</c> objects.
/// </summary>
public record SearchTeamMembersQuery
{
    /// <summary>
    /// Represents a filter used in a search for <c>TeamMember</c> objects. <c>AND</c> logic is applied
    /// between the individual fields, and <c>OR</c> logic is applied within list-based fields.
    /// For example, setting this filter value:
    /// <code>
    /// filter = (locations_ids = ["A", "B"], status = ACTIVE)
    /// </code>
    /// returns only active team members assigned to either location "A" or "B".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public SearchTeamMembersFilter? Filter { get; init; }
}
