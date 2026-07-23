using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response from the
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/subscriptions-api/retrieve-subscription">RetrieveSubscription</see> endpoint.
/// </summary>
public record RetrieveSubscriptionResponse
{
    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a customer subscription to a subscription plan.
    /// For an overview of the <c>Subscription</c> type, see
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/overview#subscription-object-overview">Subscription object</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription")]
    public Subscription? Subscription { get; init; }
}
