using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// An enumerated value that can link a
/// <c>CatalogItemVariation</c> to an item option as one of
/// its item option values.
/// </summary>
public record CatalogItemOptionValue
{
    /// <summary>
    /// The HTML-supported hex color for the item option (e.g., "#ff8d4e85").
    /// Only displayed if <c>show_colors</c> is enabled on the parent <c>ItemOption</c>. When
    /// left unset, <c>color</c> defaults to white ("#ffffff") when <c>show_colors</c> is
    /// enabled on the parent <c>ItemOption</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public string? Color { get; init; }

    /// <summary>
    /// A human-readable description for the option value. This is a searchable attribute for use in applicable query filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Unique ID of the associated item option.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_id")]
    public string? ItemOptionId { get; init; }

    /// <summary>
    /// Name of this item option value. This is a searchable attribute for use in applicable query filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Determines where this option value appears in a list of option values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }
}
