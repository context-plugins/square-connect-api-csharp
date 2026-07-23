using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the items containing the specified modifier list IDs.
/// </summary>
public record CatalogQueryItemsForModifierList
{
    /// <summary>
    /// A set of <c>CatalogModifierList</c> IDs to be used to find associated <c>CatalogItem</c>s.
    /// </summary>
    [JsonPropertyName("modifier_list_ids")]
    public required IReadOnlyList<string> ModifierListIds { get; init; }
}
