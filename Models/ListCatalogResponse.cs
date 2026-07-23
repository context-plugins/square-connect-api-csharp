using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record ListCatalogResponse
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
    /// The CatalogObjects returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("objects")]
    public IReadOnlyList<CatalogObject>? Objects { get; init; }
}
