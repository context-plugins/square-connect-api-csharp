using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to link a customer to a gift card
/// </summary>
public record LinkCustomerToGiftCardRequest
{
    /// <summary>
    /// The ID of the customer to be linked.
    /// </summary>
    [JsonPropertyName("customer_id")]
    [StringLength(191, MinimumLength = 1)]
    public required string CustomerId { get; init; }
}
