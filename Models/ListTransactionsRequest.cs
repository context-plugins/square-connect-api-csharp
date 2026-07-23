using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the query parameters that can be included in
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/list-transactions">ListTransactions</see> endpoint.
/// <para>
/// Deprecated - recommend using <see href="https://developer.squareup.com/reference/square_2021-08-18/orders-api/search-orders">SearchOrders</see>
/// </para>
/// </summary>
public record ListTransactionsRequest
{
    /// <summary>
    /// The beginning of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.
    /// </para>
    /// <para>
    /// Default value: The current time minus one year.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The end of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Date ranges</see> for details on date inclusivity/exclusivity.
    /// </para>
    /// <para>
    /// Default value: The current time.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// The order in which results are listed in the response (<c>ASC</c> for
    /// oldest first, <c>DESC</c> for newest first).
    /// <para>
    /// Default value: <c>DESC</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }
}
