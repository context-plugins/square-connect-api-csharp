using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines parameters in a
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/subscriptions-api/update-subscription">UpdateSubscription</see> endpoint
/// request.
/// </summary>
public record UpdateSubscriptionRequest
{
    /// <summary>
    /// Represents a customer subscription to a subscription plan.
    /// For an overview of the <c>Subscription</c> type, see
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/overview#subscription-object-overview">Subscription object</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription")]
    public Subscription? Subscription { get; init; }
}
