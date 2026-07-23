using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates whether Square should alert the merchant when the inventory quantity of a CatalogItemVariation is low.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InventoryAlertType>))]
public sealed record InventoryAlertType : StringEnum<InventoryAlertType>
{
    private InventoryAlertType(string value) : base(value)
    {
    }

    /// <summary>
    /// The variation does not display an alert.
    /// </summary>
    public static readonly InventoryAlertType None = new("NONE");

    /// <summary>
    /// The variation generates an alert when its quantity is low.
    /// </summary>
    public static readonly InventoryAlertType LowQuantity = new("LOW_QUANTITY");

    public static InventoryAlertType FromValue(string value) => FromValueCore(value);
}
