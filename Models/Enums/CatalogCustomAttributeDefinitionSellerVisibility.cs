using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Defines the visibility of a custom attribute to sellers in Square
/// client applications, Square APIs or in Square UIs (including Square Point
/// of Sale applications and Square Dashboard).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCustomAttributeDefinitionSellerVisibility>))]
public sealed record CatalogCustomAttributeDefinitionSellerVisibility : StringEnum<CatalogCustomAttributeDefinitionSellerVisibility>
{
    private CatalogCustomAttributeDefinitionSellerVisibility(string value) : base(value)
    {
    }

    /// <summary>
    /// Sellers cannot read this custom attribute in Square client
    /// applications or Square APIs.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionSellerVisibility SellerVisibilityHidden = new("SELLER_VISIBILITY_HIDDEN");

    /// <summary>
    /// Sellers can read and write this custom attribute value in catalog objects,
    /// but cannot edit the custom attribute definition.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionSellerVisibility SellerVisibilityReadWriteValues = new("SELLER_VISIBILITY_READ_WRITE_VALUES");

    public static CatalogCustomAttributeDefinitionSellerVisibility FromValue(string value) =>
        FromValueCore(value);
}
