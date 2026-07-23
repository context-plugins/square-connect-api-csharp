using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents Square-estimated quantity of items in a particular state at a
/// particular seller location based on the known history of physical counts and
/// inventory adjustments.
/// </summary>
public record InventoryCount
{
    /// <summary>
    /// An RFC 3339-formatted timestamp that indicates when the most recent physical count or adjustment affecting
    /// the estimated count is received.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("calculated_at")]
    [MaxLength(34)]
    public string? CalculatedAt { get; init; }

    /// <summary>
    /// The Square-generated ID of the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> being tracked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    [MaxLength(100)]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/CatalogObjectType">type</see> of the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> being tracked. Tracking is only
    /// supported for the <c>ITEM_VARIATION</c> type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_type")]
    [MaxLength(14)]
    public string? CatalogObjectType { get; init; }

    /// <summary>
    /// Whether the inventory count is for composed variation (TRUE) or not (FALSE). If true, the inventory count will not be present in the response of
    /// any of these endpoints: <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-change-inventory">BatchChangeInventory</see>,
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-changes">BatchRetrieveInventoryChanges</see>,
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-counts">BatchRetrieveInventoryCounts</see>, and
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/retrieve-inventory-changes">RetrieveInventoryChanges</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_estimated")]
    public bool? IsEstimated { get; init; }

    /// <summary>
    /// The Square-generated ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see> where the related
    /// quantity of items is being tracked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(100)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The number of items affected by the estimated count as a decimal string.
    /// Can support up to 5 digits after the decimal point.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    [MaxLength(26)]
    public string? Quantity { get; init; }

    /// <summary>
    /// The current <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/InventoryState">inventory state</see> for the related
    /// quantity of items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }
}
