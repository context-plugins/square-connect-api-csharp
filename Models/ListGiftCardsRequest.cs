using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to list gift cards. You can optionally specify a filter to retrieve a subset of
/// gift cards.
/// </summary>
public record ListGiftCardsRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// If a cursor is not provided, it returns the first page of the results.
    /// For more information, see <see href="https://developer.squareup.com/docs/docs/working-with-apis/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// If a value is provided, returns only the gift cards linked to the specified customer
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(191)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// If a value is provided, it returns only that number of results per page.
    /// The maximum number of results allowed per page is 50. The default value is 30.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(50)]
    public int? Limit { get; init; }

    /// <summary>
    /// If the state is provided, it returns the gift cards in the specified state
    /// (see <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/GiftCardStatus">GiftCardStatus</see>).
    /// Otherwise, it returns the gift cards of all states.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>
    /// If a type is provided, gift cards of this type are returned
    /// (see <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/GiftCardType">GiftCardType</see>).
    /// If no type is provided, it returns gift cards of all types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
