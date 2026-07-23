using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record DeleteCatalogObjectResponse
{
    /// <summary>
    /// The database <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// of this deletion in RFC 3339 format, e.g., <c>2016-09-04T23:59:33.123Z</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleted_at")]
    public string? DeletedAt { get; init; }

    /// <summary>
    /// The IDs of all catalog objects deleted by this request.
    /// Multiple IDs may be returned when associated objects are also deleted, for example
    /// a catalog item variation will be deleted (and its ID included in this field)
    /// when its parent catalog item is deleted.
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
