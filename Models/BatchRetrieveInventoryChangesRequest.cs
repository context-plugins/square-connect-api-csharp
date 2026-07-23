using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchRetrieveInventoryChangesRequest
{
    /// <summary>
    /// The filter to return results by <c>CatalogObject</c> ID.
    /// The filter is only applicable when set. The default value is null.
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
    /// The filter is only applicable when set. The default value is null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public IReadOnlyList<string>? LocationIds { get; init; }

    /// <summary>
    /// The filter to return <c>ADJUSTMENT</c> query results by
    /// <c>InventoryState</c>. This filter is only applied when set.
    /// The default value is null.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("states")]
    public IReadOnlyList<string>? States { get; init; }

    /// <summary>
    /// The filter to return results by <c>InventoryChangeType</c> values other than <c>TRANSFER</c>.
    /// The default value is <c>[PHYSICAL_COUNT, ADJUSTMENT]</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("types")]
    public IReadOnlyList<string>? Types { get; init; }

    /// <summary>
    /// The filter to return results with their <c>calculated_at</c> value
    /// after the given time as specified in an RFC 3339 timestamp.
    /// The default value is the UNIX epoch of (<c>1970-01-01T00:00:00Z</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_after")]
    public string? UpdatedAfter { get; init; }

    /// <summary>
    /// The filter to return results with their <c>created_at</c> or <c>calculated_at</c> value
    /// strictly before the given time as specified in an RFC 3339 timestamp.
    /// The default value is the UNIX epoch of (<c>1970-01-01T00:00:00Z</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_before")]
    public string? UpdatedBefore { get; init; }
}
