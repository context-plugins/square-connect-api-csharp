using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchUpsertCatalogObjectsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The mapping between client and server IDs for this upsert.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_mappings")]
    public IReadOnlyList<CatalogIdMapping>? IdMappings { get; init; }

    /// <summary>
    /// The created successfully created CatalogObjects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("objects")]
    public IReadOnlyList<CatalogObject>? Objects { get; init; }

    /// <summary>
    /// The database <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see> of this update in RFC 3339 format, e.g., "2016-09-04T23:59:33.123Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
