using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the response body returned from the <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-items">SearchCatalogItems</see> endpoint.
/// </summary>
public record SearchCatalogItemsResponse
{
    /// <summary>
    /// Pagination token used in the next request to return more of the search result.
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
    /// Returned items matching the specified query expressions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<CatalogObject>? Items { get; init; }

    /// <summary>
    /// Ids of returned item variations matching the specified query expression.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matched_variation_ids")]
    public IReadOnlyList<string>? MatchedVariationIds { get; init; }
}
