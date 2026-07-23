using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Either the <c>order_entries</c> or <c>orders</c> field is set, depending on whether
/// <c>return_entries</c> is set on the <see href="https://developer.squareup.com/reference/square_2021-08-18/orders-api/search-orders">SearchOrdersRequest</see>.
/// </summary>
public record SearchOrdersResponse
{
    /// <summary>
    /// The pagination cursor to be used in a subsequent request. If unset,
    /// this is the final response.
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Error">Errors</see> encountered during the search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderEntry">OrderEntries</see> that fit the query
    /// conditions. The list is populated only if <c>return_entries</c> is set to <c>true</c> in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_entries")]
    public IReadOnlyList<OrderEntry>? OrderEntries { get; init; }

    /// <summary>
    /// A list of
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">Order</see> objects that match the query conditions. The list is populated only if
    /// <c>return_entries</c> is set to <c>false</c> in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orders")]
    public IReadOnlyList<Order>? Orders { get; init; }
}
