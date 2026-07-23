using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides details about the reward tier discount. DEPRECATED at version 2020-12-16. Discount details
/// are now defined using a catalog pricing rule and other catalog objects. For more information, see
/// <see href="https://developer.squareup.com/docs/loyalty-api/overview#get-discount-details">Get discount details for the reward</see>.
/// </summary>
public record LoyaltyProgramRewardDefinition
{
    /// <summary>
    /// The list of catalog objects to which this reward can be applied. They are either all item-variation ids or category ids, depending on the <c>type</c> field.
    /// DEPRECATED at version 2020-12-16. You can find this information in the <c>product_set_data.product_ids_any</c> field
    /// of the <c>PRODUCT_SET</c> catalog object referenced by the pricing rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_ids")]
    public IReadOnlyList<string>? CatalogObjectIds { get; init; }

    /// <summary>
    /// The type of discount the reward tier offers. DEPRECATED at version 2020-12-16. You can find this information
    /// in the <c>discount_data.discount_type</c> field of the <c>DISCOUNT</c> catalog object referenced by the pricing rule.
    /// </summary>
    [JsonPropertyName("discount_type")]
    public required string DiscountType { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixed_discount_money")]
    public Money? FixedDiscountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_discount_money")]
    public Money? MaxDiscountMoney { get; init; }

    /// <summary>
    /// The fixed percentage of the discount. Present if <c>discount_type</c> is <c>FIXED_PERCENTAGE</c>.
    /// For example, a 7.25% off discount will be represented as "7.25". DEPRECATED at version 2020-12-16. You can find this
    /// information in the <c>discount_data.percentage</c> field of the <c>DISCOUNT</c> catalog object referenced by the pricing rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage_discount")]
    public string? PercentageDiscount { get; init; }

    /// <summary>
    /// Indicates the scope of the reward tier. DEPRECATED at version 2020-12-16. You can find this information in the
    /// <c>discount_target_scope</c> field of the <c>PRICING_RULE</c> catalog object and the <c>product_set_data</c> field of the <c>PRODUCT_SET</c>
    /// catalog object referenced by the pricing rule. For <c>ORDER</c> scopes, the target scope is <c>WHOLE_PURCHASE</c> and <c>all_products</c>
    /// is true. For <c>ITEM_VARIATION</c> and <c>CATEGORY</c> scopes, the target scope is <c>LINE_ITEM</c> and <c>product_ids_any</c> is a list of
    /// catalog object IDs of the given type.
    /// </summary>
    [JsonPropertyName("scope")]
    public required string Scope { get; init; }
}
