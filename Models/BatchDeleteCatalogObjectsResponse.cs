using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchDeleteCatalogObjectsResponse
{
    /// <summary>
    /// The database <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see> of this deletion in RFC 3339 format, e.g., "2016-09-04T23:59:33.123Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleted_at")]
    public string? DeletedAt { get; init; }

    /// <summary>
    /// The IDs of all CatalogObjects deleted by this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleted_object_ids")]
    public IReadOnlyList<string>? DeletedObjectIds { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
