using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Contains information defining a custom attribute. Custom attributes are
/// intended to store additional information about a catalog object or to associate a
/// catalog object with an entity in another system. Do not use custom attributes
/// to store any sensitive information (personally identifiable information, card details, etc.).
/// <see href="https://developer.squareup.com/docs/catalog-api/add-custom-attributes">Read more about custom attributes</see>
/// </summary>
public record CatalogCustomAttributeDefinition
{
    /// <summary>
    /// The set of Catalog Object Types that this Custom Attribute may be applied to.
    /// Currently, only <c>ITEM</c> and <c>ITEM_VARIATION</c> are allowed. At least one type must be included.
    /// </summary>
    [JsonPropertyName("allowed_object_types")]
    public required IReadOnlyList<string> AllowedObjectTypes { get; init; }

    /// <summary>
    /// The visibility of a custom attribute to applications other than the application
    /// that created the attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_visibility")]
    public string? AppVisibility { get; init; }

    /// <summary>
    /// __Read-only.__ The number of custom attributes that reference this
    /// custom attribute definition. Set by the server in response to a ListCatalog
    /// request with <c>include_counts</c> set to <c>true</c>.  If the actual count is greater
    /// than 100, <c>custom_attribute_usage_count</c> will be set to <c>100</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_usage_count")]
    public int? CustomAttributeUsageCount { get; init; }

    /// <summary>
    /// Seller-oriented description of the meaning of this Custom Attribute,
    /// any constraints that the seller should observe, etc. May be displayed as a tooltip in Square UIs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(255)]
    public string? Description { get; init; }

    /// <summary>
    /// The name of the desired custom attribute key that can be used to access
    /// the custom attribute value on catalog objects. Cannot be modified after the
    /// custom attribute definition has been created.
    /// Must be between 1 and 60 characters, and may only contain the characters <c>[a-zA-Z0-9_-]</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    [StringLength(60, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9_-]*$")]
    public string? Key { get; init; }

    /// <summary>
    /// The name of this definition for API and seller-facing UI purposes.
    /// The name must be unique within the (merchant, application) pair. Required.
    /// May not be empty and may not exceed 255 characters. Can be modified after creation.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(255, MinimumLength = 1)]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_config")]
    public CatalogCustomAttributeDefinitionNumberConfig? NumberConfig { get; init; }

    /// <summary>
    /// Configuration associated with <c>SELECTION</c>-type custom attribute definitions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection_config")]
    public CatalogCustomAttributeDefinitionSelectionConfig? SelectionConfig { get; init; }

    /// <summary>
    /// The visibility of a custom attribute in seller-facing UIs (including Square Point
    /// of Sale applications and Square Dashboard). May be modified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seller_visibility")]
    public string? SellerVisibility { get; init; }

    /// <summary>
    /// Provides information about the application used to generate a change.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_application")]
    public SourceApplication? SourceApplication { get; init; }

    /// <summary>
    /// Configuration associated with Custom Attribute Definitions of type <c>STRING</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("string_config")]
    public CatalogCustomAttributeDefinitionStringConfig? StringConfig { get; init; }

    /// <summary>
    /// The type of this custom attribute. Cannot be modified after creation.
    /// Required.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
