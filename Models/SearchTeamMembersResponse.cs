using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a response from a search request containing a filtered list of <c>TeamMember</c> objects.
/// </summary>
public record SearchTeamMembersResponse
{
    /// <summary>
    /// The opaque cursor for fetching the next page. For more information, see
    /// <see href="https://developer.squareup.com/docs/working-with-apis/pagination">pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The filtered list of <c>TeamMember</c> objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_members")]
    public IReadOnlyList<TeamMember>? TeamMembers { get; init; }
}
