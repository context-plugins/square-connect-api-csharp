using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response from the
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/subscriptions-api/list-subscription-events">ListSubscriptionEvents</see>
/// endpoint.
/// </summary>
public record ListSubscriptionEventsResponse
{
    /// <summary>
    /// When a response is truncated, it includes a cursor that you can
    /// use in a subsequent request to fetch the next set of events.
    /// If empty, this is the final response.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The <c>SubscriptionEvents</c> retrieved.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_events")]
    public IReadOnlyList<SubscriptionEvent>? SubscriptionEvents { get; init; }
}
