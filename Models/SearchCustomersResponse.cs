using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <c>SearchCustomers</c> endpoint.
/// <para>
/// Either <c>errors</c> or <c>customers</c> is present in a given response (never both).
/// </para>
/// </summary>
public record SearchCustomersResponse
{
    /// <summary>
    /// A pagination cursor that can be used during subsequent calls
    /// to <c>SearchCustomers</c> to retrieve the next set of results associated
    /// with the original query. Pagination cursors are only present when
    /// a request succeeds and additional results are available.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// An array of <c>Customer</c> objects that match a query.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customers")]
    public IReadOnlyList<Customer>? Customers { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
