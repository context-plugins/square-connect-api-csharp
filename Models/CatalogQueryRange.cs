using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the search result whose named attribute values fall between the specified range.
/// </summary>
public record CatalogQueryRange
{
    /// <summary>
    /// The desired maximum value for the search attribute (inclusive).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attribute_max_value")]
    public long? AttributeMaxValue { get; init; }

    /// <summary>
    /// The desired minimum value for the search attribute (inclusive).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("attribute_min_value")]
    public long? AttributeMinValue { get; init; }

    /// <summary>
    /// The name of the attribute to be searched.
    /// </summary>
    [JsonPropertyName("attribute_name")]
    [MinLength(1)]
    public required string AttributeName { get; init; }
}
