using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to retrieve gift cards by using nonces.
/// </summary>
public record RetrieveGiftCardFromNonceRequest
{
    /// <summary>
    /// The nonce of the gift card to retrieve.
    /// </summary>
    [JsonPropertyName("nonce")]
    [MinLength(1)]
    public required string Nonce { get; init; }
}
