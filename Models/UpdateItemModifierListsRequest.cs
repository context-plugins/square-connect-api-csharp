using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record UpdateItemModifierListsRequest
{
    /// <summary>
    /// The IDs of the catalog items associated with the CatalogModifierList objects being updated.
    /// </summary>
    [JsonPropertyName("item_ids")]
    public required IReadOnlyList<string> ItemIds { get; init; }

    /// <summary>
    /// The IDs of the CatalogModifierList objects to disable for the CatalogItem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_lists_to_disable")]
    public IReadOnlyList<string>? ModifierListsToDisable { get; init; }

    /// <summary>
    /// The IDs of the CatalogModifierList objects to enable for the CatalogItem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_lists_to_enable")]
    public IReadOnlyList<string>? ModifierListsToEnable { get; init; }
}
