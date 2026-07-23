using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Present only when <c>GiftCardActivityType</c> is REFUND.
/// </summary>
public record GiftCardActivityRefund
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_money")]
    public Money? AmountMoney { get; init; }

    /// <summary>
    /// When the Square Payments API is used, Refund is not called on the Gift Cards API.
    /// However, when Square reads a Refund activity from the Gift Cards API, the developer needs to know the
    /// ID of the payment (made using this gift card) that is being refunded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// The ID for the Redeem activity that needs to be refunded. Hence, the activity it
    /// refers to has to be of the REDEEM type.
    /// </summary>
    [JsonPropertyName("redeem_activity_id")]
    public required string RedeemActivityId { get; init; }

    /// <summary>
    /// A client-specified ID to associate an entity, in another system, with this gift card
    /// activity. This can be used to track the order or payment related information when the Square Orders
    /// API is not being used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }
}
