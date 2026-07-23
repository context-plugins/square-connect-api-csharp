using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A discount applicable to items.
/// </summary>
public record CatalogDiscount
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
    /// Indicates whether the discount is a fixed amount or percentage, or entered at the time of sale.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_type")]
    public string? DiscountType { get; init; }

    /// <summary>
    /// The color of the discount display label in the Square Point of Sale app. This must be a valid hex color code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label_color")]
    public string? LabelColor { get; init; }

    /// <summary>
    /// Indicates whether this discount should reduce the price used to calculate tax.
    /// <para>
    /// Most discounts should use <c>MODIFY_TAX_BASIS</c>. However, in some circumstances taxes must
    /// be calculated based on an item's price, ignoring a particular discount. For example,
    /// in many US jurisdictions, a manufacturer coupon or instant rebate reduces the price a
    /// customer pays but does not reduce the sale price used to calculate how much sales tax is
    /// due. In this case, the discount representing that manufacturer coupon should have
    /// <c>DO_NOT_MODIFY_TAX_BASIS</c> for this field.
    /// </para>
    /// <para>
    /// If you are unsure whether you need to use this field, consult your tax professional.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modify_tax_basis")]
    public string? ModifyTaxBasis { get; init; }

    /// <summary>
    /// The discount name. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The percentage of the discount as a string representation of a decimal number, using a <c>.</c> as the decimal
    /// separator and without a <c>%</c> sign. A value of <c>7.5</c> corresponds to <c>7.5%</c>. Specify a percentage of <c>0</c> if <c>discount_type</c>
    /// is <c>VARIABLE_PERCENTAGE</c>.
    /// <para>
    /// Do not use this field for amount-based or variable discounts.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    public string? Percentage { get; init; }

    /// <summary>
    /// Indicates whether a mobile staff member needs to enter their PIN to apply the
    /// discount to a payment in the Square Point of Sale app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pin_required")]
    public bool? PinRequired { get; init; }
}
