using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1Order
/// </summary>
public record V1Order
{
    /// <summary>
    /// For Bitcoin transactions, the price of the buyer's order in satoshi (100 million satoshi equals 1 BTC).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("btc_price_satoshi")]
    public double? BtcPriceSatoshi { get; init; }

    /// <summary>
    /// For Bitcoin transactions, the address that the buyer sent Bitcoin to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("btc_receive_address")]
    public string? BtcReceiveAddress { get; init; }

    /// <summary>
    /// The email address of the order's buyer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_email")]
    public string? BuyerEmail { get; init; }

    /// <summary>
    /// A note provided by the buyer when the order was created, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_note")]
    public string? BuyerNote { get; init; }

    /// <summary>
    /// A note provided by the merchant when the order's state was set to CANCELED, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_note")]
    public string? CanceledNote { get; init; }

    /// <summary>
    /// A note provided by the merchant when the order's state was set to COMPLETED, if any
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("completed_note")]
    public string? CompletedNote { get; init; }

    /// <summary>
    /// The time when the order was created, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The time when the order expires if no action is taken, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// The order's unique identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The history of actions associated with the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_history")]
    public IReadOnlyList<V1OrderHistoryEntry>? OrderHistory { get; init; }

    /// <summary>
    /// The unique identifier of the payment associated with the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

    /// <summary>
    /// The promo code provided by the buyer, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promo_code")]
    public string? PromoCode { get; init; }

    /// <summary>
    /// The name of the order's buyer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient_name")]
    public string? RecipientName { get; init; }

    /// <summary>
    /// The phone number to use for the order's delivery.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient_phone_number")]
    public string? RecipientPhoneNumber { get; init; }

    /// <summary>
    /// A note provided by the merchant when the order's state was set to REFUNDED, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunded_note")]
    public string? RefundedNote { get; init; }

    /// <summary>
    /// Represents a postal address in a country. The address format is based
    /// on an <see href="https://github.com/google/libaddressinput">open-source library from Google</see>. For more information,
    /// see <see href="https://github.com/google/libaddressinput/wiki/AddressValidationMetadata">AddressValidationMetadata</see>.
    /// This format has dedicated fields for four address components: postal code,
    /// locality (city), administrative district (state, prefecture, or province), and
    /// sublocality (town or village). These components have dedicated fields in the
    /// <c>Address</c> object because software sometimes behaves differently based on them.
    /// For example, sales tax software may charge different amounts of sales tax
    /// based on the postal code, and some software is only available in
    /// certain states due to compliance reasons.
    /// <para>
    /// For the remaining address components, the <c>Address</c> type provides the
    /// <c>address_line_1</c> and <c>address_line_2</c> fields for free-form data entry.
    /// These fields are free-form because the remaining address components have
    /// too many variations around the world and typical software does not parse
    /// these components. These fields enable users to enter anything they want.
    /// </para>
    /// <para>
    /// Note that, in the current implementation, all other <c>Address</c> type fields are blank.
    /// These include <c>address_line_3</c>, <c>sublocality_2</c>, <c>sublocality_3</c>,
    /// <c>administrative_district_level_2</c>, <c>administrative_district_level_3</c>,
    /// <c>first_name</c>, <c>last_name</c>, and <c>organization</c>.
    /// </para>
    /// <para>
    /// When it comes to localization, the seller's language preferences
    /// (see <see href="https://developer.squareup.com/docs/locations-api#location-specific-and-seller-level-language-preferences">Language preferences</see>)
    /// are ignored for addresses. Even though Square products (such as Square Point of Sale
    /// and the Seller Dashboard) mostly use a seller's language preference in
    /// communication, when it comes to addresses, they will use English for a US address,
    /// Japanese for an address in Japan, and so on.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping_address")]
    public Address? ShippingAddress { get; init; }

    /// <summary>
    /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subtotal_money")]
    public V1Money? SubtotalMoney { get; init; }

    /// <summary>
    /// A tender represents a discrete monetary exchange. Square represents this
    /// exchange as a money object with a specific currency and amount, where the
    /// amount is given in the smallest denomination of the given currency.
    /// <para>
    /// Square POS can accept more than one form of tender for a single payment (such
    /// as by splitting a bill between a credit card and a gift card). The <c>tender</c>
    /// field of the Payment object lists all forms of tender used for the payment.
    /// </para>
    /// <para>
    /// Split tender payments behave slightly differently from single tender payments:
    /// </para>
    /// <para>
    /// The receipt_url for a split tender corresponds only to the first tender listed
    /// in the tender field. To get the receipt URLs for the remaining tenders, use
    /// the receipt_url fields of the corresponding Tender objects.
    /// </para>
    /// <para>
    /// *A note on gift cards**: when a customer purchases a Square gift card from a
    /// merchant, the merchant receives the full amount of the gift card in the
    /// associated payment.
    /// </para>
    /// <para>
    /// When that gift card is used as a tender, the balance of the gift card is
    /// reduced and the merchant receives no funds. A <c>Tender</c> object with a type of
    /// <c>SQUARE_GIFT_CARD</c> indicates a gift card was used for some or all of the
    /// associated payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tender")]
    public V1Tender? Tender { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_discount_money")]
    public V1Money? TotalDiscountMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_price_money")]
    public V1Money? TotalPriceMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_shipping_money")]
    public V1Money? TotalShippingMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_tax_money")]
    public V1Money? TotalTaxMoney { get; init; }

    /// <summary>
    /// The time when the order was last modified, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
