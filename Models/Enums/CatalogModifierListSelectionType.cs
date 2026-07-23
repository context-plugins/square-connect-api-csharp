using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates whether a CatalogModifierList supports multiple selections.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogModifierListSelectionType>))]
public sealed record CatalogModifierListSelectionType : StringEnum<CatalogModifierListSelectionType>
{
    private CatalogModifierListSelectionType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that a CatalogModifierList allows only a
    /// single CatalogModifier to be selected.
    /// </summary>
    public static readonly CatalogModifierListSelectionType Single = new("SINGLE");

    /// <summary>
    /// Indicates that a CatalogModifierList allows multiple
    /// CatalogModifier to be selected.
    /// </summary>
    public static readonly CatalogModifierListSelectionType Multiple = new("MULTIPLE");

    public static CatalogModifierListSelectionType FromValue(string value) => FromValueCore(value);
}
