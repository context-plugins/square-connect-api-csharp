using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes pricing adjustments that are blocked from manual and
/// automatic application to a line item. For more information, see
/// <see href="https://developer.squareup.com/docs/orders-api/apply-taxes-and-discounts">Apply Taxes and Discounts</see>.
/// </summary>
public record OrderLineItemPricingBlocklists
{
    /// <summary>
    /// A list of discounts blocked from applying to the line item.
    /// Discounts can be blocked by the <c>discount_uid</c> (for ad hoc discounts) or
    /// the <c>discount_catalog_object_id</c> (for catalog discounts).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("blocked_discounts")]
    public IReadOnlyList<OrderLineItemPricingBlocklistsBlockedDiscount>? BlockedDiscounts { get; init; }

    /// <summary>
    /// A list of taxes blocked from applying to the line item.
    /// Taxes can be blocked by the <c>tax_uid</c> (for ad hoc taxes) or
    /// the <c>tax_catalog_object_id</c> (for catalog taxes).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("blocked_taxes")]
    public IReadOnlyList<OrderLineItemPricingBlocklistsBlockedTax>? BlockedTaxes { get; init; }
}
