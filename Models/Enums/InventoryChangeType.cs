using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates how the inventory change was applied to a tracked product quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InventoryChangeType>))]
public sealed record InventoryChangeType : StringEnum<InventoryChangeType>
{
    private InventoryChangeType(string value) : base(value)
    {
    }

    /// <summary>
    /// The change occurred as part of a physical count update.
    /// </summary>
    public static readonly InventoryChangeType PhysicalCount = new("PHYSICAL_COUNT");

    /// <summary>
    /// The change occurred as part of the normal lifecycle of goods
    /// (e.g., as an inventory adjustment).
    /// </summary>
    public static readonly InventoryChangeType Adjustment = new("ADJUSTMENT");

    /// <summary>
    /// The change occurred as part of an inventory transfer.
    /// </summary>
    public static readonly InventoryChangeType Transfer = new("TRANSFER");

    public static InventoryChangeType FromValue(string value) => FromValueCore(value);
}
