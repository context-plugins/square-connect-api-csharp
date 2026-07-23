using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the search result(s) by exact match of the specified <c>attribute_name</c> and any of
/// the <c>attribute_values</c>.
/// </summary>
public record CatalogQuerySet
{
    /// <summary>
    /// The name of the attribute to be searched. Matching of the attribute name is exact.
    /// </summary>
    [JsonPropertyName("attribute_name")]
    [MinLength(1)]
    public required string AttributeName { get; init; }

    /// <summary>
    /// The desired values of the search attribute. Matching of the attribute values is exact and case insensitive.
    /// A maximum of 250 values may be searched in a request.
    /// </summary>
    [JsonPropertyName("attribute_values")]
    public required IReadOnlyList<string> AttributeValues { get; init; }
}
