using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Possible types of CatalogObjects returned from the Catalog, each
/// containing type-specific properties in the <c>*_data</c> field corresponding to the object type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogObjectType>))]
public sealed record CatalogObjectType : StringEnum<CatalogObjectType>
{
    private CatalogObjectType(string value) : base(value)
    {
    }

    /// <summary>
    /// An item, corresponding to <c>CatalogItem</c>. The item-specific data
    /// will be stored in the <c>item_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Item = new("ITEM");

    /// <summary>
    /// An image, corresponding to <c>CatalogImage</c>. The image-specific data
    /// will be stored in the <c>image_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Image = new("IMAGE");

    /// <summary>
    /// A category, corresponding to <c>CatalogCategory</c>. The category-specific data
    /// will be stored in the <c>category_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Category = new("CATEGORY");

    /// <summary>
    /// An item variation, corresponding to <c>CatalogItemVariation</c>. The
    /// item variation-specific data will be stored in the <c>item_variation_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ItemVariation = new("ITEM_VARIATION");

    /// <summary>
    /// A tax, corresponding to <c>CatalogTax</c>. The tax-specific data
    /// will be stored in the <c>tax_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Tax = new("TAX");

    /// <summary>
    /// A discount, corresponding to <c>CatalogDiscount</c>. The discount-specific data
    /// will be stored in the <c>discount_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Discount = new("DISCOUNT");

    /// <summary>
    /// A modifier list, corresponding to <c>CatalogModifierList</c>.
    /// The modifier list-specific data will be stored in the <c>modifier_list_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ModifierList = new("MODIFIER_LIST");

    /// <summary>
    /// A modifier, corresponding to <c>CatalogModifier</c>. The modifier-specific data
    /// will be stored in the <c>modifier_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType Modifier = new("MODIFIER");

    /// <summary>
    /// A pricing rule, corresponding to <c>CatalogPricingRule</c>. The pricing-rule-specific data
    /// will be stored in the <c>pricing_rule_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType PricingRule = new("PRICING_RULE");

    /// <summary>
    /// A product set, corresponding to <c>CatalogProductSet</c>.
    /// The product-set-specific data will be stored in the <c>product_set_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType ProductSet = new("PRODUCT_SET");

    /// <summary>
    /// A time period, corresponding to <c>CatalogTimePeriod</c>.
    /// The time-period-specific data will be stored in the <c>time_period_data</c> field.
    /// </summary>
    public static readonly CatalogObjectType TimePeriod = new("TIME_PERIOD");

    /// <summary>
    /// A measurement unit, corresponding to <c>CatalogMeasurementUnit</c>. The unit of
    /// measure and precision in which an item variation should be sold.
    /// </summary>
    public static readonly CatalogObjectType MeasurementUnit = new("MEASUREMENT_UNIT");

    /// <summary>
    /// A subscription plan, corresponding to
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogSubscriptionPlan">CatalogSubscriptionPlan</see>.
    /// <para>
    /// The subscription plan data is stored in the <c>subscription_plan_data</c> field of the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>.
    /// </para>
    /// </summary>
    public static readonly CatalogObjectType SubscriptionPlan = new("SUBSCRIPTION_PLAN");

    /// <summary>
    /// Represents a list of item option values that can be assigned to item
    /// variations. For example, a color option or size option for a t-shirt.
    /// </summary>
    public static readonly CatalogObjectType ItemOption = new("ITEM_OPTION");

    /// <summary>
    /// Represents an option value associated with one or more item options.
    /// For example, an item option of "Size" may have item option values such as
    /// "Small" or "Medium".
    /// </summary>
    public static readonly CatalogObjectType ItemOptionVal = new("ITEM_OPTION_VAL");

    /// <summary>
    /// Represents the definition of a custom attribute
    /// </summary>
    public static readonly CatalogObjectType CustomAttributeDefinition = new("CUSTOM_ATTRIBUTE_DEFINITION");

    /// <summary>
    /// Represents a set of Quick Amounts and their settings at each location.
    /// For example, a location may have a list of both AUTO and MANUAL quick amounts that are set to DISABLED.
    /// </summary>
    public static readonly CatalogObjectType QuickAmountsSettings = new("QUICK_AMOUNTS_SETTINGS");

    public static CatalogObjectType FromValue(string value) => FromValueCore(value);
}
