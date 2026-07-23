using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that includes the <c>LoyaltyEvent</c> published for redeeming the reward.
/// </summary>
public record RedeemLoyaltyRewardResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Provides information about a loyalty event.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty-api/overview/#loyalty-events">Loyalty events</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("event")]
    public LoyaltyEvent? Event { get; init; }
}
