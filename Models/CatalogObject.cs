using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

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
public record CatalogObject
{
    /// <summary>
    /// A list of locations where the object is not present, even if <c>present_at_all_locations</c> is <c>true</c>.
    /// This can include locations that are deactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("absent_at_location_ids")]
    public IReadOnlyList<string>? AbsentAtLocationIds { get; init; }

    /// <summary>
    /// The Connect v1 IDs for this object at each location where it is present, where they
    /// differ from the object's Connect V2 ID. The field will only be present for objects that
    /// have been created or modified by legacy APIs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_v1_ids")]
    public IReadOnlyList<CatalogV1Id>? CatalogV1Ids { get; init; }

    /// <summary>
    /// A category to which a <c>CatalogItem</c> instance belongs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_data")]
    public CatalogCategory? CategoryData { get; init; }

    /// <summary>
    /// Contains information defining a custom attribute. Custom attributes are
    /// intended to store additional information about a catalog object or to associate a
    /// catalog object with an entity in another system. Do not use custom attributes
    /// to store any sensitive information (personally identifiable information, card details, etc.).
    /// <see href="https://developer.squareup.com/docs/catalog-api/add-custom-attributes">Read more about custom attributes</see>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_definition_data")]
    public CatalogCustomAttributeDefinition? CustomAttributeDefinitionData { get; init; }

    /// <summary>
    /// A map (key-value pairs) of application-defined custom attribute values. The value of a key-value pair
    /// is a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogCustomAttributeValue">CatalogCustomAttributeValue</see> object. The key is the <c>key</c> attribute
    /// value defined in the associated <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogCustomAttributeDefinition">CatalogCustomAttributeDefinition</see>
    /// object defined by the application making the request.
    /// <para>
    /// If the <c>CatalogCustomAttributeDefinition</c> object is
    /// defined by another application, the <c>CatalogCustomAttributeDefinition</c>'s key attribute value is prefixed by
    /// the defining application ID. For example, if the <c>CatalogCustomAttributeDefinition</c> has a <c>key</c> attribute of
    /// <c>"cocoa_brand"</c> and the defining application ID is <c>"abcd1234"</c>, the key in the map is <c>"abcd1234:cocoa_brand"</c>
    /// if the application making the request is different from the application defining the custom attribute definition.
    /// Otherwise, the key used in the map is simply <c>"cocoa_brand"</c>.
    /// </para>
    /// <para>
    /// Application-defined custom attributes that are set at a global (location-independent) level.
    /// Custom attribute values are intended to store additional information about a catalog object
    /// or associations with an entity in another system. Do not use custom attributes
    /// to store any sensitive information (personally identifiable information, card details, etc.).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_values")]
    public IReadOnlyDictionary<string, CatalogCustomAttributeValue>? CustomAttributeValues { get; init; }

    /// <summary>
    /// A discount applicable to items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_data")]
    public CatalogDiscount? DiscountData { get; init; }

    /// <summary>
    /// An identifier to reference this object in the catalog. When a new <c>CatalogObject</c>
    /// is inserted, the client should set the id to a temporary identifier starting with
    /// a "<c>#</c>" character. Other objects being inserted or updated within the same request
    /// may use this identifier to refer to the new object.
    /// <para>
    /// When the server receives the new object, it will supply a unique identifier that
    /// replaces the temporary identifier for all future references.
    /// </para>
    /// </summary>
    [JsonPropertyName("id")]
    [MinLength(1)]
    public required string Id { get; init; }

    /// <summary>
    /// An image file to use in Square catalogs. It can be associated with catalog
    /// items, item variations, and categories.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_data")]
    public CatalogImage? ImageData { get; init; }

    /// <summary>
    /// Identifies the <c>CatalogImage</c> attached to this <c>CatalogObject</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image_id")]
    public string? ImageId { get; init; }

    /// <summary>
    /// If <c>true</c>, the object has been deleted from the database. Must be <c>false</c> for new objects
    /// being inserted. When deleted, the <c>updated_at</c> field will equal the deletion time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_deleted")]
    public bool? IsDeleted { get; init; }

    /// <summary>
    /// A <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> instance of the <c>ITEM</c> type, also referred to as an item, in the catalog.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_data")]
    public CatalogItem? ItemData { get; init; }

    /// <summary>
    /// A group of variations for a <c>CatalogItem</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_data")]
    public CatalogItemOption? ItemOptionData { get; init; }

    /// <summary>
    /// An enumerated value that can link a
    /// <c>CatalogItemVariation</c> to an item option as one of
    /// its item option values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_option_value_data")]
    public CatalogItemOptionValue? ItemOptionValueData { get; init; }

    /// <summary>
    /// An item variation (i.e., product) in the Catalog object model. Each item
    /// may have a maximum of 250 item variations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_variation_data")]
    public CatalogItemVariation? ItemVariationData { get; init; }

    /// <summary>
    /// Represents the unit used to measure a <c>CatalogItemVariation</c> and
    /// specifies the precision for decimal quantities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit_data")]
    public CatalogMeasurementUnit? MeasurementUnitData { get; init; }

    /// <summary>
    /// A modifier applicable to items at the time of sale.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_data")]
    public CatalogModifier? ModifierData { get; init; }

    /// <summary>
    /// A list of modifiers applicable to items at the time of sale.
    /// <para>
    /// For example, a "Condiments" modifier list applicable to a "Hot Dog" item
    /// may contain "Ketchup", "Mustard", and "Relish" modifiers.
    /// Use the <c>selection_type</c> field to specify whether or not multiple selections from
    /// the modifier list are allowed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_list_data")]
    public CatalogModifierList? ModifierListData { get; init; }

    /// <summary>
    /// If <c>true</c>, this object is present at all locations (including future locations), except where specified in
    /// the <c>absent_at_location_ids</c> field. If <c>false</c>, this object is not present at any locations (including future locations),
    /// except where specified in the <c>present_at_location_ids</c> field. If not specified, defaults to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("present_at_all_locations")]
    public bool? PresentAtAllLocations { get; init; }

    /// <summary>
    /// A list of locations where the object is present, even if <c>present_at_all_locations</c> is <c>false</c>.
    /// This can include locations that are deactivated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("present_at_location_ids")]
    public IReadOnlyList<string>? PresentAtLocationIds { get; init; }

    /// <summary>
    /// Defines how discounts are automatically applied to a set of items that match the pricing rule
    /// during the active time period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing_rule_data")]
    public CatalogPricingRule? PricingRuleData { get; init; }

    /// <summary>
    /// Represents a collection of catalog objects for the purpose of applying a
    /// <c>PricingRule</c>. Including a catalog object will include all of its subtypes.
    /// For example, including a category in a product set will include all of its
    /// items and associated item variations in the product set. Including an item in
    /// a product set will also include its item variations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_set_data")]
    public CatalogProductSet? ProductSetData { get; init; }

    /// <summary>
    /// A parent Catalog Object model represents a set of Quick Amounts and the settings control the amounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quick_amounts_settings_data")]
    public CatalogQuickAmountsSettings? QuickAmountsSettingsData { get; init; }

    /// <summary>
    /// Describes a subscription plan. For more information, see
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/setup-plan">Set Up and Manage a Subscription Plan</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_plan_data")]
    public CatalogSubscriptionPlan? SubscriptionPlanData { get; init; }

    /// <summary>
    /// A tax applicable to an item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_data")]
    public CatalogTax? TaxData { get; init; }

    /// <summary>
    /// Represents a time period - either a single period or a repeating period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_period_data")]
    public CatalogTimePeriod? TimePeriodData { get; init; }

    /// <summary>
    /// The type of this object. Each object type has expected
    /// properties expressed in a structured format within its corresponding <c>*_data</c> field below.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Last modification <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see> in RFC 3339 format, e.g., <c>"2016-08-15T23:59:33.123Z"</c>
    /// would indicate the UTC time (denoted by <c>Z</c>) of August 15, 2016 at 23:59:33 and 123 milliseconds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The version of the object. When updating an object, the version supplied
    /// must match the version in the database, otherwise the write will be rejected as conflicting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }
}
