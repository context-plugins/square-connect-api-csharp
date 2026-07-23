using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The payment the cardholder disputed.
/// </summary>
public record DisputedPayment
{
    /// <summary>
    /// Square-generated unique ID of the payment being disputed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    [StringLength(192, MinimumLength = 1)]
    public string? PaymentId { get; init; }
}
