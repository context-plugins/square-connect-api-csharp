using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that contains one or more <c>GiftCardActivity</c>. The response might contain a set of <c>Error</c> objects
/// if the request resulted in errors.
/// </summary>
public record ListGiftCardActivitiesResponse
{
    /// <summary>
    /// When a response is truncated, it includes a cursor that you can use in a
    /// subsequent request to fetch the next set of activities. If empty, this is
    /// the final response.
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
    /// Gift card activities retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_activities")]
    public IReadOnlyList<GiftCardActivity>? GiftCardActivities { get; init; }
}
