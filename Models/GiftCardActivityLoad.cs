using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Present only when <c>GiftCardActivityType</c> is LOAD.
/// </summary>
public record GiftCardActivityLoad
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
    /// If you are not using the Orders API, this field is required because it is used to identify a buyer
    /// to perform compliance checks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_payment_instrument_ids")]
    public IReadOnlyList<string>? BuyerPaymentInstrumentIds { get; init; }

    /// <summary>
    /// The <c>line_item_uid</c> of the gift card’s line item in the order associated with the activity.
    /// It is populated along with <c>order_id</c> and is required if using the Square Orders API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_item_uid")]
    public string? LineItemUid { get; init; }

    /// <summary>
    /// The <c>order_id</c> of the order associated with the activity.
    /// It is populated along with <c>line_item_uid</c> and is required if using the Square Orders API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// A client-specified ID to associate an entity, in another system, with this gift card
    /// activity. This can be used to track the order or payment related information when the Square Orders
    /// API is not being used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }
}
