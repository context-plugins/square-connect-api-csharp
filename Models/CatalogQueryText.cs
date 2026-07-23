using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the search result whose searchable attribute values contain all of the specified keywords or tokens, independent of the token order or case.
/// </summary>
public record CatalogQueryText
{
    /// <summary>
    /// A list of 1, 2, or 3 search keywords. Keywords with fewer than 3 characters are ignored.
    /// </summary>
    [JsonPropertyName("keywords")]
    public required IReadOnlyList<string> Keywords { get; init; }
}
