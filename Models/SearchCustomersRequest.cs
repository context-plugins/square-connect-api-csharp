using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the request body of a request to the
/// <c>SearchCustomers</c> endpoint.
/// </summary>
public record SearchCustomersRequest
{
    /// <summary>
    /// Include the pagination cursor in subsequent calls to this endpoint to retrieve
    /// the next set of results associated with the original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.
    /// The limit is ignored if it is less than the minimum or greater than the maximum value. The default value is 100.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public long? Limit { get; init; }

    /// <summary>
    /// Represents a query (including filtering criteria, sorting criteria, or both) used to search
    /// for customer profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public CustomerQuery? Query { get; init; }
}
