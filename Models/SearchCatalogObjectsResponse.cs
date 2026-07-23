using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record SearchCatalogObjectsResponse
{
    /// <summary>
    /// The pagination cursor to be used in a subsequent request. If unset, this is the final response.
    /// See <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see> for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// When the associated product catalog was last updated. Will
    /// match the value for <c>end_time</c> or <c>cursor</c> if either field is included in the <c>SearchCatalog</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latest_time")]
    public string? LatestTime { get; init; }

    /// <summary>
    /// The CatalogObjects returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("objects")]
    public IReadOnlyList<CatalogObject>? Objects { get; init; }

    /// <summary>
    /// A list of CatalogObjects referenced by the objects in the <c>objects</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("related_objects")]
    public IReadOnlyList<CatalogObject>? RelatedObjects { get; init; }
}
