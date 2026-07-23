using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to unlink a customer to a gift card
/// </summary>
public record UnlinkCustomerFromGiftCardRequest
{
    [JsonPropertyName("customer_id")]
    [StringLength(191, MinimumLength = 1)]
    public required string CustomerId { get; init; }
}
