using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The response to a request for a set of <c>TeamMemberWage</c> objects. The response contains
/// a set of <c>TeamMemberWage</c> objects.
/// </summary>
public record ListTeamMemberWagesResponse
{
    /// <summary>
    /// The value supplied in the subsequent request to fetch the next page
    /// of <c>TeamMemberWage</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A page of <c>TeamMemberWage</c> results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_wages")]
    public IReadOnlyList<TeamMemberWage>? TeamMemberWages { get; init; }
}
