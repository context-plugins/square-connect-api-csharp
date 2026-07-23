using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Price and inventory alerting overrides for a <c>CatalogItemVariation</c> at a specific <c>Location</c>.
/// </summary>
public record ItemVariationLocationOverrides
{
    /// <summary>
    /// If the inventory quantity for the variation is less than or equal to this value and <c>inventory_alert_type</c>
    /// is <c>LOW_QUANTITY</c>, the variation displays an alert in the merchant dashboard.
    /// <para>
    /// This value is always an integer.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory_alert_threshold")]
    public long? InventoryAlertThreshold { get; init; }

    /// <summary>
    /// Indicates whether the <c>CatalogItemVariation</c> displays an alert when its inventory
    /// quantity is less than or equal to its <c>inventory_alert_threshold</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory_alert_type")]
    public string? InventoryAlertType { get; init; }

    /// <summary>
    /// The ID of the <c>Location</c>. This can include locations that are deactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_money")]
    public Money? PriceMoney { get; init; }

    /// <summary>
    /// The pricing type (fixed or variable) for the <c>CatalogItemVariation</c> at the given <c>Location</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing_type")]
    public string? PricingType { get; init; }

    /// <summary>
    /// If <c>true</c>, inventory tracking is active for the <c>CatalogItemVariation</c> at this <c>Location</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("track_inventory")]
    public bool? TrackInventory { get; init; }
}
