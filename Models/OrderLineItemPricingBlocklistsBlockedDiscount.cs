using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A discount to block from applying to a line item. The discount must be
/// identified by either <c>discount_uid</c> or <c>discount_catalog_object_id</c>, but not both.
/// </summary>
public record OrderLineItemPricingBlocklistsBlockedDiscount
{
    /// <summary>
    /// The <c>catalog_object_id</c> of the discount that should be blocked.
    /// Use this field to block catalog discounts. For ad hoc discounts, use the
    /// <c>discount_uid</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_catalog_object_id")]
    [MaxLength(192)]
    public string? DiscountCatalogObjectId { get; init; }

    /// <summary>
    /// The <c>uid</c> of the discount that should be blocked. Use this field to block
    /// ad hoc discounts. For catalog discounts, use the <c>discount_catalog_object_id</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_uid")]
    [MaxLength(60)]
    public string? DiscountUid { get; init; }

    /// <summary>
    /// A unique ID of the <c>BlockedDiscount</c> within the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }
}
