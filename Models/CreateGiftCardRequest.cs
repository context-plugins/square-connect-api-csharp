using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to create a gift card.
/// </summary>
public record CreateGiftCardRequest
{
    /// <summary>
    /// Represents a Square gift card.
    /// </summary>
    [JsonPropertyName("gift_card")]
    public required GiftCard GiftCard { get; init; }

    /// <summary>
    /// A unique string that identifies the <c>CreateGiftCard</c> request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The location ID where the gift card that will be created should be registered.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }
}
