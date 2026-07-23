using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response to a request to get a <c>TeamMemberWage</c>. The response contains
/// the requested <c>TeamMemberWage</c> objects and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record GetTeamMemberWageResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The hourly wage rate that a team member earns on a <c>Shift</c> for doing the job
    /// specified by the <c>title</c> property of this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_wage")]
    public TeamMemberWage? TeamMemberWage { get; init; }
}
