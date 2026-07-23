using System.Collections.Generic;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// The request does not have any required fields. When given no query criteria,
/// <c>SearchOrders</c> returns all results for all of the seller's locations. When retrieving additional
/// pages using a <c>cursor</c>, the <c>query</c> must be equal to the <c>query</c> used to retrieve the first page of
/// results.
/// </summary>
public record SearchOrdersRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for your original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page. It is
    /// possible to receive fewer results than the specified limit on a given page.
    /// <para>
    /// Default: <c>500</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    public int? Limit { get; init; }

    /// <summary>
    /// The location IDs for the orders to query. All locations must belong to
    /// the same merchant.
    /// <para>
    /// Min: 1 location ID.
    /// </para>
    /// <para>
    /// Max: 10 location IDs.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string>? LocationIds { get; init; }

    /// <summary>
    /// Contains query criteria for the search.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public SearchOrdersQuery? Query { get; init; }

    /// <summary>
    /// A Boolean that controls the format of the search results. If <c>true</c>,
    /// <c>SearchOrders</c> returns <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderEntry">OrderEntry</see> objects. If <c>false</c>, <c>SearchOrders</c>
    /// returns complete order objects.
    /// <para>
    /// Default: <c>false</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_entries")]
    public bool? ReturnEntries { get; init; }
}
