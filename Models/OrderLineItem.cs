using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a line item in an order. Each line item describes a different
/// product to purchase, with its own quantity and price details.
/// </summary>
public record OrderLineItem
{
    /// <summary>
    /// The list of references to discounts applied to this line item. Each
    /// <c>OrderLineItemAppliedDiscount</c> has a <c>discount_uid</c> that references the <c>uid</c> of a top-level
    /// <c>OrderLineItemDiscounts</c> applied to the line item. On reads, the amount
    /// applied is populated.
    /// <para>
    /// An <c>OrderLineItemAppliedDiscount</c> is automatically created on every line item for all
    /// <c>ORDER</c> scoped discounts that are added to the order. <c>OrderLineItemAppliedDiscount</c> records
    /// for <c>LINE_ITEM</c> scoped discounts must be added in requests for the discount to apply to any
    /// line items.
    /// </para>
    /// <para>
    /// To change the amount of a discount, modify the referenced top-level discount.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_discounts")]
    public IReadOnlyList<OrderLineItemAppliedDiscount>? AppliedDiscounts { get; init; }

    /// <summary>
    /// The list of references to taxes applied to this line item. Each
    /// <c>OrderLineItemAppliedTax</c> has a <c>tax_uid</c> that references the <c>uid</c> of a
    /// top-level <c>OrderLineItemTax</c> applied to the line item. On reads, the
    /// amount applied is populated.
    /// <para>
    /// An <c>OrderLineItemAppliedTax</c> is automatically created on every line
    /// item for all <c>ORDER</c> scoped taxes added to the order. <c>OrderLineItemAppliedTax</c>
    /// records for <c>LINE_ITEM</c> scoped taxes must be added in requests for the tax
    /// to apply to any line items.
    /// </para>
    /// <para>
    /// To change the amount of a tax, modify the referenced top-level tax.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_taxes")]
    public IReadOnlyList<OrderLineItemAppliedTax>? AppliedTaxes { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_price_money")]
    public Money? BasePriceMoney { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see> ID applied to this line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    [MaxLength(192)]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// The version of the catalog object that this line item references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gross_sales_money")]
    public Money? GrossSalesMoney { get; init; }

    /// <summary>
    /// The type of line item: an itemized sale, a non-itemized sale (custom amount), or the
    /// activation or reloading of a gift card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_type")]
    public string? ItemType { get; init; }

    /// <summary>
    /// Application-defined data attached to this line item. Metadata fields are intended
    /// to store descriptive references or associations with an entity in another system or store brief
    /// information about the object. Square does not process this field; it only stores and returns it
    /// in relevant API calls. Do not use metadata to store any sensitive information (such as personally
    /// identifiable information or card details).
    /// <para>
    /// Keys written by applications must be 60 characters or less and must be in the character set
    /// <c>[a-zA-Z0-9_-]</c>. Entries can also include metadata generated by Square. These keys are prefixed
    /// with a namespace, separated from the key with a ':' character.
    /// </para>
    /// <para>
    /// Values have a maximum length of 255 characters.
    /// </para>
    /// <para>
    /// An application can have up to 10 entries per metadata field.
    /// </para>
    /// <para>
    /// Entries written by applications are private and can only be read or modified by the same
    /// application.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/metadata">Metadata</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogModifier">CatalogModifier</see>s applied to this line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifiers")]
    public IReadOnlyList<OrderLineItemModifier>? Modifiers { get; init; }

    /// <summary>
    /// The name of the line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(512)]
    public string? Name { get; init; }

    /// <summary>
    /// The note of the line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(2000)]
    public string? Note { get; init; }

    /// <summary>
    /// Describes pricing adjustments that are blocked from manual and
    /// automatic application to a line item. For more information, see
    /// <see href="https://developer.squareup.com/docs/orders-api/apply-taxes-and-discounts">Apply Taxes and Discounts</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing_blocklists")]
    public OrderLineItemPricingBlocklists? PricingBlocklists { get; init; }

    /// <summary>
    /// The quantity purchased, formatted as a decimal number.
    /// For example, <c>"3"</c>.
    /// <para>
    /// Line items with a quantity of <c>"0"</c> are automatically removed
    /// when paying for or otherwise completing the order.
    /// </para>
    /// <para>
    /// Line items with a <c>quantity_unit</c> can have non-integer quantities.
    /// For example, <c>"1.70000"</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("quantity")]
    [StringLength(12, MinimumLength = 1)]
    public required string Quantity { get; init; }

    /// <summary>
    /// Contains the measurement unit for a quantity and a precision that
    /// specifies the number of digits after the decimal point for decimal quantities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_unit")]
    public OrderQuantityUnit? QuantityUnit { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_discount_money")]
    public Money? TotalDiscountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_money")]
    public Money? TotalMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_tax_money")]
    public Money? TotalTaxMoney { get; init; }

    /// <summary>
    /// A unique ID that identifies the line item only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }

    /// <summary>
    /// The name of the variation applied to this line item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variation_name")]
    [MaxLength(255)]
    public string? VariationName { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variation_total_price_money")]
    public Money? VariationTotalPriceMoney { get; init; }
}
