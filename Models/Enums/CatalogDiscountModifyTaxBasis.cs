using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CatalogDiscountModifyTaxBasis>))]
public sealed record CatalogDiscountModifyTaxBasis : StringEnum<CatalogDiscountModifyTaxBasis>
{
    private CatalogDiscountModifyTaxBasis(string value) : base(value)
    {
    }

    /// <summary>
    /// Application of the discount will modify the tax basis.
    /// </summary>
    public static readonly CatalogDiscountModifyTaxBasis ModifyTaxBasis = new("MODIFY_TAX_BASIS");

    /// <summary>
    /// Application of the discount will not modify the tax basis.
    /// </summary>
    public static readonly CatalogDiscountModifyTaxBasis DoNotModifyTaxBasis = new("DO_NOT_MODIFY_TAX_BASIS");

    public static CatalogDiscountModifyTaxBasis FromValue(string value) => FromValueCore(value);
}
