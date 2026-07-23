using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a subscription plan. For more information, see
/// <see href="https://developer.squareup.com/docs/subscriptions-api/setup-plan">Set Up and Manage a Subscription Plan</see>.
/// </summary>
public record CatalogSubscriptionPlan
{
    /// <summary>
    /// The name of the plan.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A list of SubscriptionPhase containing the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/SubscriptionPhase">SubscriptionPhase</see> for this plan.
    /// </summary>
    [JsonPropertyName("phases")]
    public required IReadOnlyList<SubscriptionPhase> Phases { get; init; }
}
