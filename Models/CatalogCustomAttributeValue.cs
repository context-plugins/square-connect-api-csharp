using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// An instance of a custom attribute. Custom attributes can be defined and
/// added to <c>ITEM</c> and <c>ITEM_VARIATION</c> type catalog objects.
/// <see href="https://developer.squareup.com/docs/catalog-api/add-custom-attributes">Read more about custom attributes</see>.
/// </summary>
public record CatalogCustomAttributeValue
{
    /// <summary>
    /// A <c>true</c> or <c>false</c> value. Populated if <c>type</c> = <c>BOOLEAN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("boolean_value")]
    public bool? BooleanValue { get; init; }

    /// <summary>
    /// __Read-only.__ The id of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogCustomAttributeDefinition">CatalogCustomAttributeDefinition</see> this value belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_definition_id")]
    public string? CustomAttributeDefinitionId { get; init; }

    /// <summary>
    /// __Read-only.__ A copy of key from the associated <c>CatalogCustomAttributeDefinition</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// The name of the custom attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Populated if <c>type</c> = <c>NUMBER</c>. Contains a string
    /// representation of a decimal number, using a <c>.</c> as the decimal separator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_value")]
    public string? NumberValue { get; init; }

    /// <summary>
    /// One or more choices from <c>allowed_selections</c>. Populated if <c>type</c> = <c>SELECTION</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection_uid_values")]
    public IReadOnlyList<string>? SelectionUidValues { get; init; }

    /// <summary>
    /// The string value of the custom attribute.  Populated if <c>type</c> = <c>STRING</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("string_value")]
    public string? StringValue { get; init; }

    /// <summary>
    /// __Read-only.__ A copy of type from the associated <c>CatalogCustomAttributeDefinition</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
