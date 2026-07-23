using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a discount being returned that applies to one or more return line items in an
/// order.
/// <para>
/// Fixed-amount, order-scoped discounts are distributed across all non-zero return line item totals.
/// The amount distributed to each return line item is relative to that item’s contribution to the
/// order subtotal.
/// </para>
/// </summary>
public record OrderReturnDiscount
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
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_money")]
    public Money? AppliedMoney { get; init; }

    /// <summary>
    /// The catalog object ID referencing <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogDiscount">CatalogDiscount</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    [MaxLength(192)]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// The version of the catalog object that this discount references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// The discount's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The percentage of the tax, as a string representation of a decimal number.
    /// A value of <c>"7.25"</c> corresponds to a percentage of 7.25%.
    /// <para>
    /// <c>percentage</c> is not set for amount-based discounts.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    [MaxLength(10)]
    public string? Percentage { get; init; }

    /// <summary>
    /// Indicates the level at which the <c>OrderReturnDiscount</c> applies. For <c>ORDER</c> scoped
    /// discounts, the server generates references in <c>applied_discounts</c> on all
    /// <c>OrderReturnLineItem</c>s. For <c>LINE_ITEM</c> scoped discounts, the discount is only applied to
    /// <c>OrderReturnLineItem</c>s with references in their <c>applied_discounts</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    /// <summary>
    /// The discount <c>uid</c> from the order that contains the original application of this discount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_discount_uid")]
    [MaxLength(60)]
    public string? SourceDiscountUid { get; init; }

    /// <summary>
    /// The type of the discount. If it is created by the API, it is <c>FIXED_PERCENTAGE</c> or <c>FIXED_AMOUNT</c>.
    /// <para>
    /// Discounts that do not reference a catalog object ID must have a type of
    /// <c>FIXED_PERCENTAGE</c> or <c>FIXED_AMOUNT</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// A unique ID that identifies the returned discount only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }
}
