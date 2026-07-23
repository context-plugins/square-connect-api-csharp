using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a collection of catalog objects for the purpose of applying a
/// <c>PricingRule</c>. Including a catalog object will include all of its subtypes.
/// For example, including a category in a product set will include all of its
/// items and associated item variations in the product set. Including an item in
/// a product set will also include its item variations.
/// </summary>
public record CatalogProductSet
{
    /// <summary>
    /// If set to <c>true</c>, the product set will include every item in the catalog.
    /// Only one of <c>product_ids_all</c>, <c>product_ids_any</c>, or <c>all_products</c> can be set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("all_products")]
    public bool? AllProducts { get; init; }

    /// <summary>
    /// User-defined name for the product set. For example, "Clearance Items"
    /// or "Winter Sale Items".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Unique IDs for any <c>CatalogObject</c> included in this product set.
    /// All objects in this set must be included in an order for a pricing rule to apply.
    /// <para>
    /// Only one of <c>product_ids_all</c>, <c>product_ids_any</c>, or <c>all_products</c> can be set.
    /// </para>
    /// <para>
    /// Max: 500 catalog object IDs.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_ids_all")]
    public IReadOnlyList<string>? ProductIdsAll { get; init; }

    /// <summary>
    /// Unique IDs for any <c>CatalogObject</c> included in this product set. Any
    /// number of these catalog objects can be in an order for a pricing rule to apply.
    /// <para>
    /// This can be used with <c>product_ids_all</c> in a parent <c>CatalogProductSet</c> to
    /// match groups of products for a bulk discount, such as a discount for an
    /// entree and side combo.
    /// </para>
    /// <para>
    /// Only one of <c>product_ids_all</c>, <c>product_ids_any</c>, or <c>all_products</c> can be set.
    /// </para>
    /// <para>
    /// Max: 500 catalog object IDs.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_ids_any")]
    public IReadOnlyList<string>? ProductIdsAny { get; init; }

    /// <summary>
    /// If set, there must be exactly this many items from <c>products_any</c> or <c>products_all</c>
    /// in the cart for the discount to apply.
    /// <para>
    /// Cannot be combined with either <c>quantity_min</c> or <c>quantity_max</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_exact")]
    public long? QuantityExact { get; init; }

    /// <summary>
    /// If set, the pricing rule will apply to a maximum of this many items from
    /// <c>products_any</c> or <c>products_all</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_max")]
    public long? QuantityMax { get; init; }

    /// <summary>
    /// If set, there must be at least this many items from <c>products_any</c> or <c>products_all</c>
    /// in a cart for the discount to apply. See <c>quantity_exact</c>. Defaults to 0 if
    /// <c>quantity_exact</c>, <c>quantity_min</c> and <c>quantity_max</c> are all unspecified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_min")]
    public long? QuantityMin { get; init; }
}
