using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Defines the possible types for a custom attribute.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCustomAttributeDefinitionType>))]
public sealed record CatalogCustomAttributeDefinitionType : StringEnum<CatalogCustomAttributeDefinitionType>
{
    private CatalogCustomAttributeDefinitionType(string value) : base(value)
    {
    }

    /// <summary>
    /// A free-form string containing up to 255 characters.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType String = new("STRING");

    /// <summary>
    /// A <c>true</c> or <c>false</c> value.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType Boolean = new("BOOLEAN");

    /// <summary>
    /// A decimal string representation of a number. Can support up to 5 digits after the decimal point.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType Number = new("NUMBER");

    /// <summary>
    /// One or more choices from <c>allowed_selections</c>.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionType Selection = new("SELECTION");

    public static CatalogCustomAttributeDefinitionType FromValue(string value) => FromValueCore(value);
}
