using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

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
public record SearchOrdersDateTimeFilter
{
    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("closed_at")]
    public TimeRange? ClosedAt { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public TimeRange? CreatedAt { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public TimeRange? UpdatedAt { get; init; }
}
