using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1PaymentItemDetail
/// </summary>
public record V1PaymentItemDetail
{
    /// <summary>
    /// The name of the item's merchant-defined category, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_name")]
    public string? CategoryName { get; init; }

    /// <summary>
    /// The unique ID of the item purchased, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_id")]
    public string? ItemId { get; init; }

    /// <summary>
    /// The unique ID of the item variation purchased, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_variation_id")]
    public string? ItemVariationId { get; init; }

    /// <summary>
    /// The item's merchant-defined SKU, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }
}
