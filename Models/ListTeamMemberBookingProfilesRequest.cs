using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record ListTeamMemberBookingProfilesRequest
{
    /// <summary>
    /// Indicates whether to include only bookable team members in the returned result (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bookable_only")]
    public bool? BookableOnly { get; init; }

    /// <summary>
    /// The cursor for paginating through the results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// Indicates whether to include only team members enabled at the given location in the returned result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }
}
