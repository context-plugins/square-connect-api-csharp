using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// An object representing a team member's wage information.
/// </summary>
public record WageSetting
{
    /// <summary>
    /// The timestamp, in RFC 3339 format, describing when the wage setting object was created.
    /// For example, "2018-10-04T04:00:00-07:00" or "2019-02-05T12:00:00Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Whether the team member is exempt from the overtime rules of the seller's country.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_overtime_exempt")]
    public bool? IsOvertimeExempt { get; init; }

    /// <summary>
    /// Required. The ordered list of jobs that the team member is assigned to.
    /// The first job assignment is considered the team member's primary job.
    /// <para>
    /// The minimum length is 1 and the maximum length is 12.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("job_assignments")]
    public IReadOnlyList<JobAssignment>? JobAssignments { get; init; }

    /// <summary>
    /// The unique ID of the <c>TeamMember</c> whom this wage setting describes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    public string? TeamMemberId { get; init; }

    /// <summary>
    /// The timestamp, in RFC 3339 format, describing when the wage setting object was last updated.
    /// For example, "2018-10-04T04:00:00-07:00" or "2019-02-05T12:00:00Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// Used for resolving concurrency issues. The request fails if the version
    /// provided does not match the server version at the time of the request. If not provided,
    /// Square executes a blind write, potentially overwriting data from another write. For more information,
    /// see <see href="https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency">optimistic concurrency</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
