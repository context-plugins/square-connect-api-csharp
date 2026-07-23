using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Pricing options for an order. The options affect how the order's price is calculated.
/// They can be used, for example, to apply automatic price adjustments that are based on preconfigured
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogPricingRule">pricing rules</see>.
/// </summary>
public record OrderPricingOptions
{
    /// <summary>
    /// The option to determine whether pricing rule-based
    /// discounts are automatically applied to an order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_apply_discounts")]
    public bool? AutoApplyDiscounts { get; init; }

    /// <summary>
    /// The option to determine whether rule-based taxes are automatically
    /// applied to an order when the criteria of the corresponding rules are met.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_apply_taxes")]
    public bool? AutoApplyTaxes { get; init; }
}
