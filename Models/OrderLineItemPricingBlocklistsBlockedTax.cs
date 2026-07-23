using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A tax to block from applying to a line item. The tax must be
/// identified by either <c>tax_uid</c> or <c>tax_catalog_object_id</c>, but not both.
/// </summary>
public record OrderLineItemPricingBlocklistsBlockedTax
{
    /// <summary>
    /// The <c>catalog_object_id</c> of the tax that should be blocked.
    /// Use this field to block catalog taxes. For ad hoc taxes, use the
    /// <c>tax_uid</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_catalog_object_id")]
    [MaxLength(192)]
    public string? TaxCatalogObjectId { get; init; }

    /// <summary>
    /// The <c>uid</c> of the tax that should be blocked. Use this field to block
    /// ad hoc taxes. For catalog, taxes use the <c>tax_catalog_object_id</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_uid")]
    [MaxLength(60)]
    public string? TaxUid { get; init; }

    /// <summary>
    /// A unique ID of the <c>BlockedTax</c> within the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }
}
