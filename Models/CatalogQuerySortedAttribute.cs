using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query expression to specify the key to sort search results.
/// </summary>
public record CatalogQuerySortedAttribute
{
    /// <summary>
    /// The attribute whose value is used as the sort key.
    /// </summary>
    [JsonPropertyName("attribute_name")]
    [MinLength(1)]
    public required string AttributeName { get; init; }

    /// <summary>
    /// The first attribute value to be returned by the query. Ascending sorts will return only
    /// objects with this value or greater, while descending sorts will return only objects with this value
    /// or less. If unset, start at the beginning (for ascending sorts) or end (for descending sorts).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initial_attribute_value")]
    public string? InitialAttributeValue { get; init; }

    /// <summary>
    /// The desired sort order, <c>"ASC"</c> (ascending) or <c>"DESC"</c> (descending).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }
}
