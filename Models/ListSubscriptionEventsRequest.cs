using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines parameters in a
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/subscriptions-api/list-subscription-events">ListSubscriptionEvents</see>
/// endpoint request.
/// </summary>
public record ListSubscriptionEventsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for the original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The upper limit on the number of subscription events to return
    /// in the response.
    /// <para>
    /// Default: <c>200</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    public int? Limit { get; init; }
}
