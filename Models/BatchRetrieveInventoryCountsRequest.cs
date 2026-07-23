using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchRetrieveInventoryCountsRequest
{
    /// <summary>
    /// The filter to return results by <c>CatalogObject</c> ID.
    /// The filter is applicable only when set.  The default is null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_ids")]
    public IReadOnlyList<string>? CatalogObjectIds { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for the original query.
    /// <para>
    /// See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The filter to return results by <c>Location</c> ID.
    /// This filter is applicable only when set. The default is null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string>? LocationIds { get; init; }

    /// <summary>
    /// The filter to return results by <c>InventoryState</c>. The filter is only applicable when set.
    /// Ignored are untracked states of <c>NONE</c>, <c>SOLD</c>, and <c>UNLINKED_RETURN</c>.
    /// The default is null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("states")]
    public IReadOnlyList<string>? States { get; init; }

    /// <summary>
    /// The filter to return results with their <c>calculated_at</c> value
    /// after the given time as specified in an RFC 3339 timestamp.
    /// The default value is the UNIX epoch of (<c>1970-01-01T00:00:00Z</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_after")]
    public string? UpdatedAfter { get; init; }
}
