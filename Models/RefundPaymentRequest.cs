using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a request to refund a payment using <see href="https://developer.squareup.com/reference/square_2021-08-18/refunds-api/refund-payment">RefundPayment</see>.
/// </summary>
public record RefundPaymentRequest
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_fee_money")]
    public Money? AppFeeMoney { get; init; }

    /// <summary>
    /// A unique string that identifies this <c>RefundPayment</c> request. The key can be any valid string
    /// but must be unique for every <c>RefundPayment</c> request.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The unique ID of the payment being refunded.
    /// </summary>
    [JsonPropertyName("payment_id")]
    [MinLength(1)]
    public required string PaymentId { get; init; }

    /// <summary>
    /// A description of the reason for the refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(192)]
    public string? Reason { get; init; }
}
