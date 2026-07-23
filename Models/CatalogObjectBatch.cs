using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A batch of catalog objects.
/// </summary>
public record CatalogObjectBatch
{
    /// <summary>
    /// A list of CatalogObjects belonging to this batch.
    /// </summary>
    [JsonPropertyName("objects")]
    public required IReadOnlyList<CatalogObject> Objects { get; init; }
}
