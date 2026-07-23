using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that contains one <c>GiftCard</c> that was unlinked. The response might contain a set of <c>Error</c>
/// objects if the request resulted in errors.
/// </summary>
public record UnlinkCustomerFromGiftCardResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a Square gift card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card")]
    public GiftCard? GiftCard { get; init; }
}
