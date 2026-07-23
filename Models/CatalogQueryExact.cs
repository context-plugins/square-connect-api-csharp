using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the search result by exact match of the specified attribute name and value.
/// </summary>
public record CatalogQueryExact
{
    /// <summary>
    /// The name of the attribute to be searched. Matching of the attribute name is exact.
    /// </summary>
    [JsonPropertyName("attribute_name")]
    [MinLength(1)]
    public required string AttributeName { get; init; }

    /// <summary>
    /// The desired value of the search attribute. Matching of the attribute value is case insensitive and can be partial.
    /// For example, if a specified value of "sma", objects with the named attribute value of "Small", "small" are both matched.
    /// </summary>
    [JsonPropertyName("attribute_value")]
    public required string AttributeValue { get; init; }
}
