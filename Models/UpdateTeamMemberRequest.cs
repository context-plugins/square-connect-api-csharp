using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an update request for a <c>TeamMember</c> object.
/// </summary>
public record UpdateTeamMemberRequest
{
    /// <summary>
    /// A record representing an individual team member for a business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member")]
    public TeamMember? TeamMember { get; init; }
}
