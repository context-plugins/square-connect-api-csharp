using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Filter based on <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderFulfillment">order fulfillment</see> information.
/// </summary>
public record SearchOrdersFulfillmentFilter
{
    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderFulfillmentState">fulfillment states</see> to filter
    /// for. The list returns orders if any of its fulfillments match any of the
    /// fulfillment states listed in this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_states")]
    public IReadOnlyList<string>? FulfillmentStates { get; init; }

    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/OrderFulfillmentType">fulfillment types</see> to filter
    /// for. The list returns orders if any of its fulfillments match any of the fulfillment types
    /// listed in this field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_types")]
    public IReadOnlyList<string>? FulfillmentTypes { get; init; }
}
