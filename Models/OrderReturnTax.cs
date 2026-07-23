using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a tax being returned that applies to one or more return line items in an order.
/// <para>
/// Fixed-amount, order-scoped taxes are distributed across all non-zero return line item totals.
/// The amount distributed to each return line item is relative to that item’s contribution to the
/// order subtotal.
/// </para>
/// </summary>
public record OrderReturnTax
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
    [JsonPropertyName("applied_money")]
    public Money? AppliedMoney { get; init; }

    /// <summary>
    /// The catalog object ID referencing <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax">CatalogTax</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    [MaxLength(192)]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// The version of the catalog object that this tax references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// The tax's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The percentage of the tax, as a string representation of a decimal number.
    /// For example, a value of <c>"7.25"</c> corresponds to a percentage of 7.25%.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    [MaxLength(10)]
    public string? Percentage { get; init; }

    /// <summary>
    /// Indicates the level at which the <c>OrderReturnTax</c> applies. For <c>ORDER</c> scoped
    /// taxes, Square generates references in <c>applied_taxes</c> on all
    /// <c>OrderReturnLineItem</c>s. For <c>LINE_ITEM</c> scoped taxes, the tax is only applied to
    /// <c>OrderReturnLineItem</c>s with references in their <c>applied_discounts</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    /// <summary>
    /// The tax <c>uid</c> from the order that contains the original tax charge.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_tax_uid")]
    [MaxLength(60)]
    public string? SourceTaxUid { get; init; }

    /// <summary>
    /// Indicates the calculation method used to apply the tax.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// A unique ID that identifies the returned tax only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }
}
