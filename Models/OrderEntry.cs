using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A lightweight description of an <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> that is returned when
/// <c>returned_entries</c> is <c>true</c> on a <see href="https://developer.squareup.com/reference/square_2021-08-18/orders-api/search-orders">SearchOrdersRequest</see>.
/// </summary>
public record OrderEntry
{
    /// <summary>
    /// The location ID the order belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// The version number, which is incremented each time an update is committed to the order.
    /// Orders that were not created through the API do not include a version number and
    /// therefore cannot be updated.
    /// <para>
    /// <see href="https://developer.squareup.com/docs/orders-api/manage-orders#update-orders">Read more about working with versions.</see>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
