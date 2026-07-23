using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The filtering criteria. If the request specifies multiple filters,
/// the endpoint uses a logical AND to evaluate them.
/// </summary>
public record LoyaltyEventFilter
{
    /// <summary>
    /// Filter events by date time range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date_time_filter")]
    public LoyaltyEventDateTimeFilter? DateTimeFilter { get; init; }

    /// <summary>
    /// Filter events by location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_filter")]
    public LoyaltyEventLocationFilter? LocationFilter { get; init; }

    /// <summary>
    /// Filter events by loyalty account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_account_filter")]
    public LoyaltyEventLoyaltyAccountFilter? LoyaltyAccountFilter { get; init; }

    /// <summary>
    /// Filter events by the order associated with the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_filter")]
    public LoyaltyEventOrderFilter? OrderFilter { get; init; }

    /// <summary>
    /// Filter events by event type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type_filter")]
    public LoyaltyEventTypeFilter? TypeFilter { get; init; }
}
