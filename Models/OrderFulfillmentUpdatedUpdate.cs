using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Information about fulfillment updates.
/// </summary>
public record OrderFulfillmentUpdatedUpdate
{
    /// <summary>
    /// A unique ID that identifies the fulfillment only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fulfillment_uid")]
    public string? FulfillmentUid { get; init; }

    /// <summary>
    /// The state of the fulfillment after the change. The state might be equal to <c>old_state</c> if a non-state
    /// field was changed on the fulfillment (such as the tracking number).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_state")]
    public string? NewState { get; init; }

    /// <summary>
    /// The state of the fulfillment before the change.
    /// The state is not populated if the fulfillment is created with this new <c>Order</c> version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("old_state")]
    public string? OldState { get; init; }
}
