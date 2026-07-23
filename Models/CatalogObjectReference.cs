using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A reference to a Catalog object at a specific version. In general this is
/// used as an entry point into a graph of catalog objects, where the objects exist
/// at a specific version.
/// </summary>
public record CatalogObjectReference
{
    /// <summary>
    /// The version of the object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// The ID of the referenced object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_id")]
    public string? ObjectId { get; init; }
}
