using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A group of variations for a <c>CatalogItem</c>.
/// </summary>
public record CatalogItemOption
{
    /// <summary>
    /// The item option's human-readable description. Displayed in the Square
    /// Point of Sale app for the seller and in the Online Store or on receipts for
    /// the buyer. This is a searchable attribute for use in applicable query filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The item option's display name for the customer. This is a searchable attribute for use in applicable query filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    /// <summary>
    /// The item option's display name for the seller. Must be unique across
    /// all item options. This is a searchable attribute for use in applicable query filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// If true, display colors for entries in <c>values</c> when present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("show_colors")]
    public bool? ShowColors { get; init; }

    /// <summary>
    /// A list of CatalogObjects containing the
    /// <c>CatalogItemOptionValue</c>s for this item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<CatalogObject>? Values { get; init; }
}
