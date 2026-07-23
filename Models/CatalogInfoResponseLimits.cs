using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record CatalogInfoResponseLimits
{
    /// <summary>
    /// The maximum number of object IDs that may be included in a single
    /// <c>/v2/catalog/batch-delete</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_delete_max_object_ids")]
    public int? BatchDeleteMaxObjectIds { get; init; }

    /// <summary>
    /// The maximum number of object IDs that may appear in a <c>/v2/catalog/batch-retrieve</c>
    /// request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_retrieve_max_object_ids")]
    public int? BatchRetrieveMaxObjectIds { get; init; }

    /// <summary>
    /// The maximum number of objects that may appear within a single batch in a
    /// <c>/v2/catalog/batch-upsert</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_upsert_max_objects_per_batch")]
    public int? BatchUpsertMaxObjectsPerBatch { get; init; }

    /// <summary>
    /// The maximum number of objects that may appear across all batches in a
    /// <c>/v2/catalog/batch-upsert</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_upsert_max_total_objects")]
    public int? BatchUpsertMaxTotalObjects { get; init; }

    /// <summary>
    /// The maximum number of results that may be returned in a page of a
    /// <c>/v2/catalog/search</c> response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("search_max_page_limit")]
    public int? SearchMaxPageLimit { get; init; }

    /// <summary>
    /// The maximum number of item IDs that may be included in a single
    /// <c>/v2/catalog/update-item-modifier-lists</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_item_modifier_lists_max_item_ids")]
    public int? UpdateItemModifierListsMaxItemIds { get; init; }

    /// <summary>
    /// The maximum number of modifier list IDs to be disabled that may be included in
    /// a single <c>/v2/catalog/update-item-modifier-lists</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_item_modifier_lists_max_modifier_lists_to_disable")]
    public int? UpdateItemModifierListsMaxModifierListsToDisable { get; init; }

    /// <summary>
    /// The maximum number of modifier list IDs to be enabled that may be included in
    /// a single <c>/v2/catalog/update-item-modifier-lists</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_item_modifier_lists_max_modifier_lists_to_enable")]
    public int? UpdateItemModifierListsMaxModifierListsToEnable { get; init; }

    /// <summary>
    /// The maximum number of item IDs that may be included in a single
    /// <c>/v2/catalog/update-item-taxes</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_item_taxes_max_item_ids")]
    public int? UpdateItemTaxesMaxItemIds { get; init; }

    /// <summary>
    /// The maximum number of tax IDs to be disabled that may be included in a single
    /// <c>/v2/catalog/update-item-taxes</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_item_taxes_max_taxes_to_disable")]
    public int? UpdateItemTaxesMaxTaxesToDisable { get; init; }

    /// <summary>
    /// The maximum number of tax IDs to be enabled that may be included in a single
    /// <c>/v2/catalog/update-item-taxes</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_item_taxes_max_taxes_to_enable")]
    public int? UpdateItemTaxesMaxTaxesToEnable { get; init; }
}
