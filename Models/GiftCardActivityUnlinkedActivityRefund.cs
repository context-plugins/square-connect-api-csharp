using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Present only when <c>GiftCardActivityType</c> is UNLINKED_ACTIVITY_REFUND.
/// </summary>
public record GiftCardActivityUnlinkedActivityRefund
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
    /// When using the Square Payments API, the ID of the payment that was refunded to this gift
    /// card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// A client-specified ID to associate an entity, in another system, with this gift card
    /// activity. This can be used to track the order or payment related information when the Square Payments
    /// API is not being used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }
}
