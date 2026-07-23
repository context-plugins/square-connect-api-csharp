using System.Collections.Generic;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the request body for the <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-items">SearchCatalogItems</see> endpoint.
/// </summary>
public record SearchCatalogItemsRequest
{
    /// <summary>
    /// The category id query expression to return items containing the specified category IDs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_ids")]
    public IReadOnlyList<string>? CategoryIds { get; init; }

    /// <summary>
    /// The pagination token, returned in the previous response, used to fetch the next batch of pending results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The customer-attribute filter to return items or item variations matching the specified
    /// custom attribute expressions. A maximum number of 10 custom attribute expressions are supported in
    /// a single call to the <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-items">SearchCatalogItems</see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_filters")]
    public IReadOnlyList<CustomAttributeFilter>? CustomAttributeFilters { get; init; }

    /// <summary>
    /// The enabled-location query expression to return items and item variations having specified enabled locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled_location_ids")]
    public IReadOnlyList<string>? EnabledLocationIds { get; init; }

    /// <summary>
    /// The maximum number of results to return per page. The default value is 100.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Maximum(100)]
    public int? Limit { get; init; }

    /// <summary>
    /// The product types query expression to return items or item variations having the specified product types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_types")]
    public IReadOnlyList<string>? ProductTypes { get; init; }

    /// <summary>
    /// The order to sort the results by item names. The default sort order is ascending (<c>ASC</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }

    /// <summary>
    /// The stock-level query expression to return item variations with the specified stock levels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stock_levels")]
    public IReadOnlyList<string>? StockLevels { get; init; }

    /// <summary>
    /// The text filter expression to return items or item variations containing specified text in
    /// the <c>name</c>, <c>description</c>, or <c>abbreviation</c> attribute value of an item, or in
    /// the <c>name</c>, <c>sku</c>, or <c>upc</c> attribute value of an item variation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text_filter")]
    public string? TextFilter { get; init; }
}
