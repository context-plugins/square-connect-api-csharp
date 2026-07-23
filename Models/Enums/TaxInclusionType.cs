using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Whether to the tax amount should be additional to or included in the CatalogItem price.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TaxInclusionType>))]
public sealed record TaxInclusionType : StringEnum<TaxInclusionType>
{
    private TaxInclusionType(string value) : base(value)
    {
    }

    /// <summary>
    /// The tax is an additive tax. The tax amount is added on top of the
    /// CatalogItemVariation price. For example, a $1.00 item with a 10% additive
    /// tax would have a total cost to the buyer of $1.10.
    /// </summary>
    public static readonly TaxInclusionType Additive = new("ADDITIVE");

    /// <summary>
    /// The tax is an inclusive tax. The tax amount is included in the
    /// CatalogItemVariation price. For example, a $1.00 item with a 10% inclusive
    /// tax would have a total cost to the buyer of $1.00, with $0.91 (91 cents) of
    /// that total being the cost of the item and $0.09 (9 cents) being tax.
    /// </summary>
    public static readonly TaxInclusionType Inclusive = new("INCLUSIVE");

    public static TaxInclusionType FromValue(string value) => FromValueCore(value);
}
