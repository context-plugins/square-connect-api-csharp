using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A payment represents a paid transaction between a Square merchant and a
/// customer. Payment details are usually available from Connect API endpoints
/// within a few minutes after the transaction completes.
/// <para>
/// Each Payment object includes several fields that end in <c>_money</c>. These fields
/// describe the various amounts of money that contribute to the payment total:
/// </para>
/// <para>
/// &lt;ul&gt;
/// &lt;li&gt;
/// Monetary values are &lt;b&gt;positive&lt;/b&gt; if they represent an
/// &lt;em&gt;increase&lt;/em&gt; in the amount of money the merchant receives (e.g.,
/// &lt;code&gt;tax_money&lt;/code&gt;, &lt;code&gt;tip_money&lt;/code&gt;).
/// &lt;/li&gt;
/// &lt;li&gt;
/// Monetary values are &lt;b&gt;negative&lt;/b&gt; if they represent an
/// &lt;em&gt;decrease&lt;/em&gt; in the amount of money the merchant receives (e.g.,
/// &lt;code&gt;discount_money&lt;/code&gt;, &lt;code&gt;refunded_money&lt;/code&gt;).
/// &lt;/li&gt;
/// &lt;/ul&gt;
/// </para>
/// </summary>
public record V1Payment
{
    /// <summary>
    /// All of the additive taxes associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additive_tax")]
    public IReadOnlyList<V1PaymentTax>? AdditiveTax { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additive_tax_money")]
    public V1Money? AdditiveTaxMoney { get; init; }

    /// <summary>
    /// The time when the payment was created, in ISO 8601 format. Reflects the time of the first payment if the object represents an incomplete partial payment, and the time of the last or complete payment otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The unique identifier of the Square account that took the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public Device? Device { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_money")]
    public V1Money? DiscountMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_sales_money")]
    public V1Money? GrossSalesMoney { get; init; }

    /// <summary>
    /// The payment's unique identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// All of the inclusive taxes associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inclusive_tax")]
    public IReadOnlyList<V1PaymentTax>? InclusiveTax { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inclusive_tax_money")]
    public V1Money? InclusiveTaxMoney { get; init; }

    /// <summary>
    /// Indicates whether or not the payment is only partially paid for.
    /// If true, this payment will have the tenders collected so far, but the
    /// itemizations will be empty until the payment is completed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_partial")]
    public bool? IsPartial { get; init; }

    /// <summary>
    /// The items purchased in the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itemizations")]
    public IReadOnlyList<V1PaymentItemization>? Itemizations { get; init; }

    /// <summary>
    /// The unique identifier of the merchant that took the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_sales_money")]
    public V1Money? NetSalesMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_total_money")]
    public V1Money? NetTotalMoney { get; init; }

    /// <summary>
    /// The URL of the payment's detail page in the merchant dashboard. The merchant must be signed in to the merchant dashboard to view this page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_url")]
    public string? PaymentUrl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processing_fee_money")]
    public V1Money? ProcessingFeeMoney { get; init; }

    /// <summary>
    /// The URL of the receipt for the payment. Note that for split tender
    /// payments, this URL corresponds to the receipt for the first tender
    /// listed in the payment's tender field. Each Tender object has its own
    /// receipt_url field you can use to get the other receipts associated with
    /// a split tender payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("receipt_url")]
    public string? ReceiptUrl { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunded_money")]
    public V1Money? RefundedMoney { get; init; }

    /// <summary>
    /// All of the refunds applied to the payment. Note that the value of all refunds on a payment can exceed the value of all tenders if a merchant chooses to refund money to a tender after previously accepting returned goods as part of an exchange.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunds")]
    public IReadOnlyList<V1Refund>? Refunds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge_money")]
    public V1Money? SurchargeMoney { get; init; }

    /// <summary>
    /// A list of all surcharges associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharges")]
    public IReadOnlyList<V1PaymentSurcharge>? Surcharges { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swedish_rounding_money")]
    public V1Money? SwedishRoundingMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_money")]
    public V1Money? TaxMoney { get; init; }

    /// <summary>
    /// All of the tenders associated with the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tender")]
    public IReadOnlyList<V1Tender>? Tender { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip_money")]
    public V1Money? TipMoney { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_collected_money")]
    public V1Money? TotalCollectedMoney { get; init; }
}
