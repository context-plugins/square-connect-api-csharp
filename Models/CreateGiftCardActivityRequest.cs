using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to create a gift card activity.
/// </summary>
public record CreateGiftCardActivityRequest
{
    /// <summary>
    /// Represents an action performed on a gift card that affects its state or balance.
    /// </summary>
    [JsonPropertyName("gift_card_activity")]
    public required GiftCardActivity GiftCardActivity { get; init; }

    /// <summary>
    /// A unique string that identifies the <c>CreateGiftCardActivity</c> request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
