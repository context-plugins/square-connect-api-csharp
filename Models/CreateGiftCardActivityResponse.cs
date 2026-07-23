using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that contains a <c>GiftCardActivity</c> that was created.
/// The response might contain a set of <c>Error</c> objects if the request resulted in errors.
/// </summary>
public record CreateGiftCardActivityResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents an action performed on a gift card that affects its state or balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_activity")]
    public GiftCardActivity? GiftCardActivity { get; init; }
}
