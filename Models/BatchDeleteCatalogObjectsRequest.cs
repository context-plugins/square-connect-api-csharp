using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchDeleteCatalogObjectsRequest
{
    /// <summary>
    /// The IDs of the CatalogObjects to be deleted. When an object is deleted, other objects
    /// in the graph that depend on that object will be deleted as well (for example, deleting a
    /// CatalogItem will delete its CatalogItemVariation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_ids")]
    public IReadOnlyList<string>? ObjectIds { get; init; }
}
