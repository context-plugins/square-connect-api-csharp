using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that contains a <c>GiftCard</c>. This response might contain a set of <c>Error</c> objects
/// if the request resulted in errors.
/// </summary>
public record RetrieveGiftCardFromGanresponse
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
