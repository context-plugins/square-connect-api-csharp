using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A <c>CatalogItemOptionValue</c> links an item variation to an item option as
/// an item option value. For example, a t-shirt item may offer a color option and
/// a size option. An item option value would represent each variation of t-shirt:
/// For example, "Color:Red, Size:Small" or "Color:Blue, Size:Medium".
/// </summary>
public record CatalogItemOptionValueForItemVariation
{
    /// <summary>
    /// The unique id of an item option.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_id")]
    public string? ItemOptionId { get; init; }

    /// <summary>
    /// The unique id of the selected value for the item option.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_value_id")]
    public string? ItemOptionValueId { get; init; }
}
