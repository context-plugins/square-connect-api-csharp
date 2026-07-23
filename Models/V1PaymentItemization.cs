using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Payment include an<c> itemizations</c> field that lists the items purchased,
/// along with associated fees, modifiers, and discounts. Each itemization has an
/// <c>itemization_type</c> field that indicates which of the following the itemization
/// represents:
/// <para>
/// &lt;ul&gt;
/// &lt;li&gt;An item variation from the merchant's item library&lt;/li&gt;
/// &lt;li&gt;A custom monetary amount&lt;/li&gt;
/// &lt;li&gt;
/// An action performed on a Square gift card, such as activating or
/// reloading it.
/// &lt;/li&gt;
/// &lt;/ul&gt;
/// </para>
/// <para>
/// *Note**: itemization information included in a <c>Payment</c> object reflects
/// details collected <b>at the time of the payment</b>. Details such as the name or
/// price of items might have changed since the payment was processed.
/// </para>
/// </summary>
public record V1PaymentItemization
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_money")]
    public V1Money? DiscountMoney { get; init; }

    /// <summary>
    /// All discounts applied to this itemization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discounts")]
    public IReadOnlyList<V1PaymentDiscount>? Discounts { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_sales_money")]
    public V1Money? GrossSalesMoney { get; init; }

    /// <summary>
    /// V1PaymentItemDetail
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_detail")]
    public V1PaymentItemDetail? ItemDetail { get; init; }

    /// <summary>
    /// The name of the item variation purchased, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_variation_name")]
    public string? ItemVariationName { get; init; }

    /// <summary>
    /// The type of purchase that the itemization represents, such as an ITEM or CUSTOM_AMOUNT
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itemization_type")]
    public string? ItemizationType { get; init; }

    /// <summary>
    /// All modifier options applied to this itemization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifiers")]
    public IReadOnlyList<V1PaymentModifier>? Modifiers { get; init; }

    /// <summary>
    /// The item's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_sales_money")]
    public V1Money? NetSalesMoney { get; init; }

    /// <summary>
    /// Notes entered by the merchant about the item at the time of payment, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public string? Notes { get; init; }

    /// <summary>
    /// The quantity of the item purchased. This can be a decimal value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public double? Quantity { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("single_quantity_money")]
    public V1Money? SingleQuantityMoney { get; init; }

    /// <summary>
    /// All taxes applied to this itemization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxes")]
    public IReadOnlyList<V1PaymentTax>? Taxes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_money")]
    public V1Money? TotalMoney { get; init; }
}
