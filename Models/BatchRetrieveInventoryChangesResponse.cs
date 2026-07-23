using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchRetrieveInventoryChangesResponse
{
    /// <summary>
    /// The current calculated inventory changes for the requested objects
    /// and locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changes")]
    public IReadOnlyList<InventoryChange>? Changes { get; init; }

    /// <summary>
    /// The pagination cursor to be used in a subsequent request. If unset,
    /// this is the final response.
    /// See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.
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
}
