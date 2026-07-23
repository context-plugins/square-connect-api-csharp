using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Filtering criteria to use for a <c>SearchOrders</c> request. Multiple filters
/// are ANDed together.
/// </summary>
public record SearchOrdersFilter
{
    /// <summary>
    /// A filter based on the order <c>customer_id</c> and any tender <c>customer_id</c>
    /// associated with the order. It does not filter based on the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderFulfillmentRecipient">FulfillmentRecipient</see> <c>customer_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_filter")]
    public SearchOrdersCustomerFilter? CustomerFilter { get; init; }

    /// <summary>
    /// Filter for <c>Order</c> objects based on whether their <c>CREATED_AT</c>,
    /// <c>CLOSED_AT</c>, or <c>UPDATED_AT</c> timestamps fall within a specified time range.
    /// You can specify the time range and which timestamp to filter for. You can filter
    /// for only one time range at a time.
    /// <para>
    /// For each time range, the start time and end time are inclusive. If the end time
    /// is absent, it defaults to the time of the first request for the cursor.
    /// </para>
    /// <para>
    /// __Important:__ If you use the <c>DateTimeFilter</c> in a <c>SearchOrders</c> query,
    /// you must set the <c>sort_field</c> in <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/SearchOrdersSort">OrdersSort</see>
    /// to the same field you filter for. For example, if you set the <c>CLOSED_AT</c> field
    /// in <c>DateTimeFilter</c>, you must set the <c>sort_field</c> in <c>SearchOrdersSort</c> to
    /// <c>CLOSED_AT</c>. Otherwise, <c>SearchOrders</c> throws an error.
    /// <see href="https://developer.squareup.com/docs/orders-api/manage-orders#important-note-on-filtering-orders-by-time-range">Learn more about filtering orders by time range.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_time_filter")]
    public SearchOrdersDateTimeFilter? DateTimeFilter { get; init; }

    /// <summary>
    /// Filter based on <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderFulfillment">order fulfillment</see> information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_filter")]
    public SearchOrdersFulfillmentFilter? FulfillmentFilter { get; init; }

    /// <summary>
    /// A filter based on order <c>source</c> information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_filter")]
    public SearchOrdersSourceFilter? SourceFilter { get; init; }

    /// <summary>
    /// Filter by the current order <c>state</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state_filter")]
    public SearchOrdersStateFilter? StateFilter { get; init; }
}
