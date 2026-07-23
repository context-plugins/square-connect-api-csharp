using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the valid parameters for requests to the <c>ListCustomerSegments</c> endpoint.
/// </summary>
public record ListCustomerSegmentsRequest
{
    /// <summary>
    /// A pagination cursor returned by previous calls to <c>ListCustomerSegments</c>.
    /// This cursor is used to retrieve the next set of query results.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.
    /// The limit is ignored if it is less than 1 or greater than 50. The default value is 50.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(50)]
    public int? Limit { get; init; }
}
