using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Filter events by loyalty account.
/// </summary>
public record LoyaltyEventLoyaltyAccountFilter
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyAccount">loyalty account</see> associated with loyalty events.
    /// </summary>
    [JsonPropertyName("loyalty_account_id")]
    [MinLength(1)]
    public required string LoyaltyAccountId { get; init; }
}
