using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes changes to subscription and billing states.
/// </summary>
public record SubscriptionEvent
{
    /// <summary>
    /// The date, in YYYY-MM-DD format (for
    /// example, 2013-01-15), when the subscription event went into effect.
    /// </summary>
    [JsonPropertyName("effective_date")]
    public required string EffectiveDate { get; init; }

    /// <summary>
    /// The ID of the subscription event.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("info")]
    public object? Info { get; init; }

    /// <summary>
    /// The ID of the subscription plan associated with the subscription.
    /// </summary>
    [JsonPropertyName("plan_id")]
    public required string PlanId { get; init; }

    /// <summary>
    /// Type of the subscription event.
    /// </summary>
    [JsonPropertyName("subscription_event_type")]
    public required string SubscriptionEventType { get; init; }
}
