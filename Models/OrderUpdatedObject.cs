using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record OrderUpdatedObject
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_updated")]
    public OrderUpdated? OrderUpdated { get; init; }
}
