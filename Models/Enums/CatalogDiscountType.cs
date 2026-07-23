using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// How to apply a CatalogDiscount to a CatalogItem.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogDiscountType>))]
public sealed record CatalogDiscountType : StringEnum<CatalogDiscountType>
{
    private CatalogDiscountType(string value) : base(value)
    {
    }

    /// <summary>
    /// Apply the discount as a fixed percentage (e.g., 5%) off the item price.
    /// </summary>
    public static readonly CatalogDiscountType FixedPercentage = new("FIXED_PERCENTAGE");

    /// <summary>
    /// Apply the discount as a fixed amount (e.g., $1.00) off the item price.
    /// </summary>
    public static readonly CatalogDiscountType FixedAmount = new("FIXED_AMOUNT");

    /// <summary>
    /// Apply the discount as a variable percentage off the item price. The percentage will be specified at the time of sale.
    /// </summary>
    public static readonly CatalogDiscountType VariablePercentage = new("VARIABLE_PERCENTAGE");

    /// <summary>
    /// Apply the discount as a variable amount off the item price. The amount will be specified at the time of sale.
    /// </summary>
    public static readonly CatalogDiscountType VariableAmount = new("VARIABLE_AMOUNT");

    public static CatalogDiscountType FromValue(string value) => FromValueCore(value);
}
