using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the request parameters for the <c>ListDisputes</c> endpoint.
/// </summary>
public record ListDisputesRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The ID of the location for which to return a list of disputes. If not specified, the endpoint returns
    /// all open disputes (the dispute status is not <c>INQUIRY_CLOSED</c>, <c>WON</c>, or <c>LOST</c>) associated with all locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [StringLength(40, MinimumLength = 1)]
    public string? LocationId { get; init; }

    /// <summary>
    /// The dispute states to filter the result.
    /// If not specified, the endpoint returns all open disputes (the dispute status is not <c>INQUIRY_CLOSED</c>, <c>WON</c>,
    /// or <c>LOST</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("states")]
    public IReadOnlyList<string>? States { get; init; }
}
