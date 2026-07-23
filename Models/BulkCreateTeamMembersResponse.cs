using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a response from a bulk create request containing the created <c>TeamMember</c> objects or error messages.
/// </summary>
public record BulkCreateTeamMembersResponse
{
    /// <summary>
    /// The errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The successfully created <c>TeamMember</c> objects. Each key is the <c>idempotency_key</c> that maps to the <c>CreateTeamMemberRequest</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_members")]
    public IReadOnlyDictionary<string, CreateTeamMemberResponse>? TeamMembers { get; init; }
}
