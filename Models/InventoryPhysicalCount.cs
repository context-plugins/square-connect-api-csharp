using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the quantity of an item variation that is physically present
/// at a specific location, verified by a seller or a seller's employee. For example,
/// a physical count might come from an employee counting the item variations on
/// hand or from syncing with an external system.
/// </summary>
public record InventoryPhysicalCount
{
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
    /// An RFC 3339-formatted timestamp that indicates when the physical count is received.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    [MaxLength(34)]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The Square-generated ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Employee">Employee</see> responsible for the
    /// physical count.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_id")]
    [MaxLength(100)]
    public string? EmployeeId { get; init; }

    /// <summary>
    /// A unique Square-generated ID for the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount">InventoryPhysicalCount</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(100)]
    public string? Id { get; init; }

    /// <summary>
    /// The Square-generated ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see> where the related
    /// quantity of items is being tracked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(100)]
    public string? LocationId { get; init; }

    /// <summary>
    /// A client-generated RFC 3339-formatted timestamp that indicates when
    /// the physical count was examined. For physical count updates, the <c>occurred_at</c>
    /// timestamp cannot be older than 24 hours or in the future relative to the
    /// time of the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("occurred_at")]
    [MaxLength(34)]
    public string? OccurredAt { get; init; }

    /// <summary>
    /// The number of items affected by the physical count as a decimal string.
    /// The number can support up to 5 digits after the decimal point.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    [MaxLength(26)]
    public string? Quantity { get; init; }

    /// <summary>
    /// An optional ID provided by the application to tie the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount">InventoryPhysicalCount</see> to an external
    /// system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    [MaxLength(255)]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// Provides information about the application used to generate a change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public SourceApplication? Source { get; init; }

    /// <summary>
    /// The current <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/InventoryState">inventory state</see> for the related
    /// quantity of items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }
}
