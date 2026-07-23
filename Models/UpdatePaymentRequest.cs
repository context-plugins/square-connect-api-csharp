using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a request to update a payment using
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/update-payment">UpdatePayment</see>.
/// </summary>
public record UpdatePaymentRequest
{
    /// <summary>
    /// A unique string that identifies this <c>UpdatePayment</c> request. Keys can be any valid string
    /// but must be unique for every <c>UpdatePayment</c> request.
    /// <para>
    /// The maximum is 45 characters.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(45, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Represents a payment processed by the Square API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment")]
    public Payment? Payment { get; init; }
}
