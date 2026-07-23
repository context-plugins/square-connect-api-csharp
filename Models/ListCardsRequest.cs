using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Retrieves details for a specific Card. Accessible via
/// HTTP requests at GET https://connect.squareup.com/v2/cards
/// </summary>
public record ListCardsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see> for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    [MaxLength(256)]
    public string? Cursor { get; init; }

    /// <summary>
    /// Limit results to cards associated with the customer supplied.
    /// By default, all cards owned by the merchant are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// Includes disabled cards.
    /// By default, all enabled cards owned by the merchant are returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_disabled")]
    public bool? IncludeDisabled { get; init; }

    /// <summary>
    /// Limit results to cards associated with the reference_id supplied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// Sorts the returned list by when the card was created with the specified order.
    /// This field defaults to ASC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }
}
