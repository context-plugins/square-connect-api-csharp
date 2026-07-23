using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record OrderFulfillmentUpdatedObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_fulfillment_updated")]
    public OrderFulfillmentUpdated? OrderFulfillmentUpdated { get; init; }
}
