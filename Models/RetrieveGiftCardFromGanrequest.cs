using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to retrieve gift cards by their GANs.
/// </summary>
public record RetrieveGiftCardFromGanrequest
{
    /// <summary>
    /// The gift card account number (GAN) of the gift card to retrieve.
    /// The maximum length of a GAN is 255 digits to account for third-party GANs that have been imported.
    /// Square-issued gift cards have 16-digit GANs.
    /// </summary>
    [JsonPropertyName("gan")]
    [StringLength(255, MinimumLength = 1)]
    public required string Gan { get; init; }
}
