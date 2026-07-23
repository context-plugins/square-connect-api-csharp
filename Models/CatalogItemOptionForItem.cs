using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// An option that can be assigned to an item.
/// For example, a t-shirt item may offer a color option or a size option.
/// </summary>
public record CatalogItemOptionForItem
{
    /// <summary>
    /// The unique id of the item option, used to form the dimensions of the item option matrix in a specified order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_id")]
    public string? ItemOptionId { get; init; }
}
