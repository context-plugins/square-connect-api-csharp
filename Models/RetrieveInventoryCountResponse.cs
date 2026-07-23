using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RetrieveInventoryCountResponse
{
    /// <summary>
    /// The current calculated inventory counts for the requested object and
    /// locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counts")]
    public IReadOnlyList<InventoryCount>? Counts { get; init; }

    /// <summary>
    /// The pagination cursor to be used in a subsequent request. If unset,
    /// this is the final response.
    /// <para>
    /// See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.
    /// </para>
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
