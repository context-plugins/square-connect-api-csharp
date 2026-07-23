using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A Square API V1 identifier of an item, including the object ID and its associated location ID.
/// </summary>
public record CatalogV1Id
{
    /// <summary>
    /// The ID for an object used in the Square API V1, if the object ID differs from the Square API V2 object ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_v1_id")]
    public string? CatalogV1IdValue { get; init; }

    /// <summary>
    /// The ID of the <c>Location</c> this Connect V1 ID is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }
}
