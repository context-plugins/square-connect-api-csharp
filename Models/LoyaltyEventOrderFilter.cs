using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Filter events by the order associated with the event.
/// </summary>
public record LoyaltyEventOrderFilter
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> associated with the event.
    /// </summary>
    [JsonPropertyName("order_id")]
    [MinLength(1)]
    public required string OrderId { get; init; }
}
