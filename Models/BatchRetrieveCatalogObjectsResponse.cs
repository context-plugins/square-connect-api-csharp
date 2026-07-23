using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchRetrieveCatalogObjectsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("objects")]
    public IReadOnlyList<CatalogObject>? Objects { get; init; }

    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s referenced by the object in the <c>objects</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("related_objects")]
    public IReadOnlyList<CatalogObject>? RelatedObjects { get; init; }
}
