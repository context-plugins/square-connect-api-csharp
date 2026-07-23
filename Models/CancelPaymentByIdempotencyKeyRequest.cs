using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a request to cancel a payment using
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/cancel-payment-by-idempotency-key">CancelPaymentByIdempotencyKey</see>.
/// </summary>
public record CancelPaymentByIdempotencyKeyRequest
{
    /// <summary>
    /// The <c>idempotency_key</c> identifying the payment to be canceled.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(45, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
