using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the item variations containing the specified item option value IDs.
/// </summary>
public record CatalogQueryItemVariationsForItemOptionValues
{
    /// <summary>
    /// A set of <c>CatalogItemOptionValue</c> IDs to be used to find associated
    /// <c>CatalogItemVariation</c>s. All ItemVariations that contain all of the given
    /// Item Option Values (in any order) will be returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_value_ids")]
    public IReadOnlyList<string>? ItemOptionValueIds { get; init; }
}
