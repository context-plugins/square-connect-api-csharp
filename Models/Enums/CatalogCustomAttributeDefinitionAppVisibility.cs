using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Defines the visibility of a custom attribute to applications other than their
/// creating application.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogCustomAttributeDefinitionAppVisibility>))]
public sealed record CatalogCustomAttributeDefinitionAppVisibility : StringEnum<CatalogCustomAttributeDefinitionAppVisibility>
{
    private CatalogCustomAttributeDefinitionAppVisibility(string value) : base(value)
    {
    }

    /// <summary>
    /// Other applications cannot read this custom attribute.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionAppVisibility AppVisibilityHidden = new("APP_VISIBILITY_HIDDEN");

    /// <summary>
    /// Other applications can read this custom attribute definition and
    /// values.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionAppVisibility AppVisibilityReadOnly = new("APP_VISIBILITY_READ_ONLY");

    /// <summary>
    /// Other applications can read and write custom attribute values on objects.
    /// They can read but cannot edit the custom attribute definition.
    /// </summary>
    public static readonly CatalogCustomAttributeDefinitionAppVisibility AppVisibilityReadWriteValues = new("APP_VISIBILITY_READ_WRITE_VALUES");

    public static CatalogCustomAttributeDefinitionAppVisibility FromValue(string value) => FromValueCore(value);
}
