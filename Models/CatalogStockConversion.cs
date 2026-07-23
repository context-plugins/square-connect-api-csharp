using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the rule of conversion between a stockable <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see>
/// and a non-stockable sell-by or receive-by <c>CatalogItemVariation</c> that
/// share the same underlying stock.
/// </summary>
public record CatalogStockConversion
{
    /// <summary>
    /// The converted equivalent quantity of the non-stockable <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see>
    /// in its measurement unit. The <c>stockable_quantity</c> value and this <c>nonstockable_quantity</c> value together
    /// define the conversion ratio between stockable item variation and the non-stockable item variation.
    /// It accepts a decimal number in a string format that can take up to 10 digits before the decimal point
    /// and up to 5 digits after the decimal point.
    /// </summary>
    [JsonPropertyName("nonstockable_quantity")]
    [StringLength(16, MinimumLength = 1)]
    public required string NonstockableQuantity { get; init; }

    /// <summary>
    /// References to the stockable <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see>
    /// for this stock conversion. Selling, receiving or recounting the non-stockable <c>CatalogItemVariation</c>
    /// defined with a stock conversion results in adjustments of this stockable <c>CatalogItemVariation</c>.
    /// This immutable field must reference a stockable <c>CatalogItemVariation</c>
    /// that shares the parent <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see> of the converted <c>CatalogItemVariation.</c>
    /// </summary>
    [JsonPropertyName("stockable_item_variation_id")]
    [MinLength(1)]
    public required string StockableItemVariationId { get; init; }

    /// <summary>
    /// The quantity of the stockable item variation (as identified by <c>stockable_item_variation_id</c>)
    /// equivalent to the non-stockable item variation quantity (as specified in <c>nonstockable_quantity</c>)
    /// as defined by this stock conversion.  It accepts a decimal number in a string format that can take
    /// up to 10 digits before the decimal point and up to 5 digits after the decimal point.
    /// </summary>
    [JsonPropertyName("stockable_quantity")]
    [StringLength(16, MinimumLength = 1)]
    public required string StockableQuantity { get; init; }
}
