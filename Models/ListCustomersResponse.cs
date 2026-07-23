using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <c>ListCustomers</c> endpoint.
/// <para>
/// Either <c>errors</c> or <c>customers</c> is present in a given response (never both).
/// </para>
/// </summary>
public record ListCustomersResponse
{
    /// <summary>
    /// A pagination cursor to retrieve the next set of results for the
    /// original query. A cursor is only present if the request succeeded and additional results
    /// are available.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// An array of <c>Customer</c> objects that match the provided query.
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
