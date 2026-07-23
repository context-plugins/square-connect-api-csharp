using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Determines the type of a specific Quick Amount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogQuickAmountType>))]
public sealed record CatalogQuickAmountType : StringEnum<CatalogQuickAmountType>
{
    private CatalogQuickAmountType(string value) : base(value)
    {
    }

    /// <summary>
    /// Quick Amount is created manually by the seller.
    /// </summary>
    public static readonly CatalogQuickAmountType QuickAmountTypeManual = new("QUICK_AMOUNT_TYPE_MANUAL");

    /// <summary>
    /// Quick Amount is generated automatically by machine learning algorithms.
    /// </summary>
    public static readonly CatalogQuickAmountType QuickAmountTypeAuto = new("QUICK_AMOUNT_TYPE_AUTO");

    public static CatalogQuickAmountType FromValue(string value) => FromValueCore(value);
}
