using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a single physical count, inventory, adjustment, or transfer
/// that is part of the history of inventory changes for a particular
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> instance.
/// </summary>
public record InventoryChange
{
    /// <summary>
    /// Represents a change in state or quantity of product inventory at a
    /// particular time and location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjustment")]
    public InventoryAdjustment? Adjustment { get; init; }

    /// <summary>
    /// Represents the unit used to measure a <c>CatalogItemVariation</c> and
    /// specifies the precision for decimal quantities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit")]
    public CatalogMeasurementUnit? MeasurementUnit { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogMeasurementUnit">CatalogMeasurementUnit</see> object representing the catalog measurement unit associated with the inventory change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit_id")]
    public string? MeasurementUnitId { get; init; }

    /// <summary>
    /// Represents the quantity of an item variation that is physically present
    /// at a specific location, verified by a seller or a seller's employee. For example,
    /// a physical count might come from an employee counting the item variations on
    /// hand or from syncing with an external system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("physical_count")]
    public InventoryPhysicalCount? PhysicalCount { get; init; }

    /// <summary>
    /// Represents the transfer of a quantity of product inventory at a
    /// particular time from one location to another.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer")]
    public InventoryTransfer? Transfer { get; init; }

    /// <summary>
    /// Indicates how the inventory change is applied. See
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/InventoryChangeType">InventoryChangeType</see> for all possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
