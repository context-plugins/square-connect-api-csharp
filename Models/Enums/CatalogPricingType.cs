using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates whether the price of a CatalogItemVariation should be entered manually at the time of sale.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogPricingType>))]
public sealed record CatalogPricingType : StringEnum<CatalogPricingType>
{
    private CatalogPricingType(string value) : base(value)
    {
    }

    /// <summary>
    /// The catalog item variation's price is fixed.
    /// </summary>
    public static readonly CatalogPricingType FixedPricing = new("FIXED_PRICING");

    /// <summary>
    /// The catalog item variation's price is entered at the time of sale.
    /// </summary>
    public static readonly CatalogPricingType VariablePricing = new("VARIABLE_PRICING");

    public static CatalogPricingType FromValue(string value) => FromValueCore(value);
}
