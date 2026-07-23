using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the items containing the specified item option IDs.
/// </summary>
public record CatalogQueryItemsForItemOptions
{
    /// <summary>
    /// A set of <c>CatalogItemOption</c> IDs to be used to find associated
    /// <c>CatalogItem</c>s. All Items that contain all of the given Item Options (in any order)
    /// will be returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_ids")]
    public IReadOnlyList<string>? ItemOptionIds { get; init; }
}
