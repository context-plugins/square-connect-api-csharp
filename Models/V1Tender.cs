using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

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
public record V1Tender
{
    /// <summary>
    /// The brand of credit card provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_brand")]
    public string? CardBrand { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("change_back_money")]
    public V1Money? ChangeBackMoney { get; init; }

    /// <summary>
    /// The ID of the employee that processed the tender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; init; }

    /// <summary>
    /// The tender's unique ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entry_method")]
    public string? EntryMethod { get; init; }

    /// <summary>
    /// The tender's unique ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Indicates whether or not the tender is associated with an exchange. If is_exchange is true, the tender represents the value of goods returned in an exchange not the actual money paid. The exchange value reduces the tender amounts needed to pay for items purchased in the exchange.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_exchange")]
    public bool? IsExchange { get; init; }

    /// <summary>
    /// A human-readable description of the tender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The last four digits of the provided credit card's account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pan_suffix")]
    public string? PanSuffix { get; init; }

    /// <summary>
    /// Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type: OTHER.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_note")]
    public string? PaymentNote { get; init; }

    /// <summary>
    /// The URL of the receipt for the tender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receipt_url")]
    public string? ReceiptUrl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunded_money")]
    public V1Money? RefundedMoney { get; init; }

    /// <summary>
    /// The time when the tender was settled, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settled_at")]
    public string? SettledAt { get; init; }

    /// <summary>
    /// The time when the tender was created, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tendered_at")]
    public string? TenderedAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tendered_money")]
    public V1Money? TenderedMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_money")]
    public V1Money? TotalMoney { get; init; }

    /// <summary>
    /// The type of tender.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
