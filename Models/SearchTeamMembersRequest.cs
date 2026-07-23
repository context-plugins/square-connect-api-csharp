using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a search request for a filtered list of <c>TeamMember</c> objects.
/// </summary>
public record SearchTeamMembersRequest
{
    /// <summary>
    /// The opaque cursor for fetching the next page. For more information, see
    /// <see href="https://developer.squareup.com/docs/working-with-apis/pagination">pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of <c>TeamMember</c> objects in a page (100 by default).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Limit { get; init; }

    /// <summary>
    /// Represents the parameters in a search for <c>TeamMember</c> objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchTeamMembersQuery? Query { get; init; }
}
