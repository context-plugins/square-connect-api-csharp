using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body for requests to the <c>ListCustomerSegments</c> endpoint.
/// <para>
/// Either <c>errors</c> or <c>segments</c> is present in a given response (never both).
/// </para>
/// </summary>
public record ListCustomerSegmentsResponse
{
    /// <summary>
    /// A pagination cursor to be used in subsequent calls to <c>ListCustomerSegments</c>
    /// to retrieve the next set of query results. The cursor is only present if the request succeeded and
    /// additional results are available.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
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
    /// The list of customer segments belonging to the associated Square account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segments")]
    public IReadOnlyList<CustomerSegment>? Segments { get; init; }
}
