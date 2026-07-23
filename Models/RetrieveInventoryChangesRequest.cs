using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RetrieveInventoryChangesRequest
{
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
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see> IDs to look up as a comma-separated
    /// list. An empty list queries all locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_ids")]
    public string? LocationIds { get; init; }
}
