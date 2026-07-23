using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a bulk create request for <c>TeamMember</c> objects.
/// </summary>
public record BulkCreateTeamMembersRequest
{
    /// <summary>
    /// The data used to create the <c>TeamMember</c> objects. Each key is the <c>idempotency_key</c> that maps to the <c>CreateTeamMemberRequest</c>.
    /// </summary>
    [JsonPropertyName("team_members")]
    public required IReadOnlyDictionary<string, CreateTeamMemberRequest> TeamMembers { get; init; }
}
