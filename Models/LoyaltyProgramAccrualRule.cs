using System.Collections.Generic;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines an accrual rule, which is how buyers can earn points.
/// </summary>
public record LoyaltyProgramAccrualRule
{
    /// <summary>
    /// The type of the accrual rule that defines how buyers can earn points.
    /// </summary>
    [JsonPropertyName("accrual_type")]
    public required string AccrualType { get; init; }

    /// <summary>
    /// When the accrual rule is item-based or category-based, this field specifies the ID
    /// of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">catalog object</see> that buyers can purchase to earn points.
    /// If <c>accrual_type</c> is <c>ITEM_VARIATION</c>, the object is an item variation.
    /// If <c>accrual_type</c> is <c>CATEGORY</c>, the object is a category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// When the accrual rule is spend-based (<c>accrual_type</c> is <c>SPEND</c>), this field
    /// lists the IDs of any <c>CATEGORY</c> catalog objects that are excluded from points accrual.
    /// <para>
    /// You can use the <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/batch-retrieve-catalog-objects">BatchRetrieveCatalogObjects</see>
    /// endpoint to retrieve information about the excluded categories.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excluded_category_ids")]
    public IReadOnlyList<string>? ExcludedCategoryIds { get; init; }

    /// <summary>
    /// When the accrual rule is spend-based (<c>accrual_type</c> is <c>SPEND</c>), this field
    /// lists the IDs of any <c>ITEM_VARIATION</c> catalog objects that are excluded from points accrual.
    /// <para>
    /// You can use the <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/batch-retrieve-catalog-objects">BatchRetrieveCatalogObjects</see>
    /// endpoint to retrieve information about the excluded item variations.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excluded_item_variation_ids")]
    public IReadOnlyList<string>? ExcludedItemVariationIds { get; init; }

    /// <summary>
    /// The number of points that
    /// buyers earn based on the <c>accrual_type</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points")]
    [Minimum(1)]
    public int? Points { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spend_amount_money")]
    public Money? SpendAmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visit_minimum_amount_money")]
    public Money? VisitMinimumAmountMoney { get; init; }
}
