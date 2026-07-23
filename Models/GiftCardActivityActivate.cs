using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a gift card activity of the ACTIVATE type.
/// </summary>
public record GiftCardActivityActivate
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
    /// Required if your application does not use the Square Orders API.
    /// This is a list of client-provided payment instrument IDs.
    /// Square uses this information to perform compliance checks.
    /// If you use the Square Orders API, Square has the necessary instrument IDs to perform necessary
    /// compliance checks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_payment_instrument_ids")]
    public IReadOnlyList<string>? BuyerPaymentInstrumentIds { get; init; }

    /// <summary>
    /// The <c>line_item_uid</c> of the gift card line item in an order.
    /// This is required if your application uses the Square Orders API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("line_item_uid")]
    public string? LineItemUid { get; init; }

    /// <summary>
    /// The ID of the order associated with the activity.
    /// This is required if your application uses the Square Orders API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// If your application does not use the Square Orders API, you can optionally use this field
    /// to associate the gift card activity with a client-side entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }
}
