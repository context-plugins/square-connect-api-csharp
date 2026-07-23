using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record UpsertCatalogObjectRequest
{
    /// <summary>
    /// A value you specify that uniquely identifies this
    /// request among all your requests. A common way to create
    /// a valid idempotency key is to use a Universally unique
    /// identifier (UUID).
    /// <para>
    /// If you're unsure whether a particular request was successful,
    /// you can reattempt it with the same idempotency key without
    /// worrying about creating duplicate objects.
    /// </para>
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The wrapper object for the Catalog entries of a given object type.
    /// <para>
    /// The type of a particular <c>CatalogObject</c> is determined by the value of the
    /// <c>type</c> attribute and only the corresponding data attribute can be set on the <c>CatalogObject</c> instance.
    /// For example, the following list shows some instances of <c>CatalogObject</c> of a given <c>type</c> and
    /// their corresponding data attribute that can be set:
    /// - For a <c>CatalogObject</c> of the <c>ITEM</c> type, set the <c>item_data</c> attribute to yield the <c>CatalogItem</c> object.
    /// - For a <c>CatalogObject</c> of the <c>ITEM_VARIATION</c> type, set the <c>item_variation_data</c> attribute to yield the <c>CatalogItemVariation</c> object.
    /// - For a <c>CatalogObject</c> of the <c>MODIFIER</c> type, set the <c>modifier_data</c> attribute to yield the <c>CatalogModifier</c> object.
    /// - For a <c>CatalogObject</c> of the <c>MODIFIER_LIST</c> type, set the <c>modifier_list_data</c> attribute to yield the <c>CatalogModifierList</c> object.
    /// - For a <c>CatalogObject</c> of the <c>CATEGORY</c> type, set the <c>category_data</c> attribute to yield the <c>CatalogCategory</c> object.
    /// - For a <c>CatalogObject</c> of the <c>DISCOUNT</c> type, set the <c>discount_data</c> attribute to yield the <c>CatalogDiscount</c> object.
    /// - For a <c>CatalogObject</c> of the <c>TAX</c> type, set the <c>tax_data</c> attribute to yield the <c>CatalogTax</c> object.
    /// - For a <c>CatalogObject</c> of the <c>IMAGE</c> type, set the <c>image_data</c> attribute to yield the <c>CatalogImageData</c>  object.
    /// - For a <c>CatalogObject</c> of the <c>QUICK_AMOUNTS_SETTINGS</c> type, set the <c>quick_amounts_settings_data</c> attribute to yield the <c>CatalogQuickAmountsSettings</c> object.
    /// - For a <c>CatalogObject</c> of the <c>PRICING_RULE</c> type, set the <c>pricing_rule_data</c> attribute to yield the <c>CatalogPricingRule</c> object.
    /// - For a <c>CatalogObject</c> of the <c>TIME_PERIOD</c> type, set the <c>time_period_data</c> attribute to yield the <c>CatalogTimePeriod</c> object.
    /// - For a <c>CatalogObject</c> of the <c>PRODUCT_SET</c> type, set the <c>product_set_data</c> attribute to yield the <c>CatalogProductSet</c>  object.
    /// - For a <c>CatalogObject</c> of the <c>SUBSCRIPTION_PLAN</c> type, set the <c>subscription_plan_data</c> attribute to yield the <c>CatalogSubscriptionPlan</c> object.
    /// </para>
    /// <para>
    ///
    /// For a more detailed discussion of the Catalog data model, please see the
    /// <see href="https://developer.squareup.com/docs/catalog-api/design-a-catalog">Design a Catalog</see> guide.
    /// </para>
    /// </summary>
    [JsonPropertyName("object")]
    public required CatalogObject Object { get; init; }
}
