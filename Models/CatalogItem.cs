using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> instance of the <c>ITEM</c> type, also referred to as an item, in the catalog.
/// </summary>
public record CatalogItem
{
    /// <summary>
    /// The text of the item's display label in the Square Point of Sale app. Only up to the first five characters of the string are used.
    /// This attribute is searchable, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("abbreviation")]
    [MaxLength(24)]
    public string? Abbreviation { get; init; }

    /// <summary>
    /// If <c>true</c>, the item can be added to electronically fulfilled orders from the merchant's online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_electronically")]
    public bool? AvailableElectronically { get; init; }

    /// <summary>
    /// If <c>true</c>, the item can be added to pickup orders from the merchant's online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_for_pickup")]
    public bool? AvailableForPickup { get; init; }

    /// <summary>
    /// If <c>true</c>, the item can be added to shipping orders from the merchant's online store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_online")]
    public bool? AvailableOnline { get; init; }

    /// <summary>
    /// The ID of the item's category, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category_id")]
    public string? CategoryId { get; init; }

    /// <summary>
    /// The item's description. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(4096)]
    public string? Description { get; init; }

    /// <summary>
    /// List of item options IDs for this item. Used to manage and group item
    /// variations in a specified order.
    /// <para>
    /// Maximum: 6 item options.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("item_options")]
    public IReadOnlyList<CatalogItemOptionForItem>? ItemOptions { get; init; }

    /// <summary>
    /// The color of the item's display label in the Square Point of Sale app. This must be a valid hex color code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label_color")]
    public string? LabelColor { get; init; }

    /// <summary>
    /// A set of <c>CatalogItemModifierListInfo</c> objects
    /// representing the modifier lists that apply to this item, along with the overrides and min
    /// and max limits that are specific to this item. Modifier lists
    /// may also be added to or deleted from an item using <c>UpdateItemModifierLists</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_list_info")]
    public IReadOnlyList<CatalogItemModifierListInfo>? ModifierListInfo { get; init; }

    /// <summary>
    /// The item's name. This is a searchable attribute for use in applicable query filters, its value must not be empty, and the length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(512)]
    public string? Name { get; init; }

    /// <summary>
    /// The product type of the item. May not be changed once an item has been created.
    /// <para>
    /// Only items of product type <c>REGULAR</c> or <c>APPOINTMENTS_SERVICE</c> may be created by this API; items with other product
    /// types are read-only.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_type")]
    public string? ProductType { get; init; }

    /// <summary>
    /// If <c>false</c>, the Square Point of Sale app will present the <c>CatalogItem</c>'s
    /// details screen immediately, allowing the merchant to choose <c>CatalogModifier</c>s
    /// before adding the item to the cart.  This is the default behavior.
    /// <para>
    /// If <c>true</c>, the Square Point of Sale app will immediately add the item to the cart with the pre-selected
    /// modifiers, and merchants can edit modifiers by drilling down onto the item's details.
    /// </para>
    /// <para>
    /// Third-party clients are encouraged to implement similar behaviors.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_modifier_screen")]
    public bool? SkipModifierScreen { get; init; }

    /// <summary>
    /// A name to sort the item by. If this name is unspecified, namely, the <c>sort_name</c> field is absent, the regular <c>name</c> field is used for sorting.
    /// <para>
    /// It is currently supported for sellers of the Japanese locale only.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_name")]
    public string? SortName { get; init; }

    /// <summary>
    /// A set of IDs indicating the taxes enabled for
    /// this item. When updating an item, any taxes listed here will be added to the item.
    /// Taxes may also be added to or deleted from an item using <c>UpdateItemTaxes</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_ids")]
    public IReadOnlyList<string>? TaxIds { get; init; }

    /// <summary>
    /// A list of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see> objects for this item. An item must have
    /// at least one variation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("variations")]
    public IReadOnlyList<CatalogObject>? Variations { get; init; }
}
