using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Supported custom attribute query expressions for calling the
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-items">SearchCatalogItems</see>
/// endpoint to search for items or item variations.
/// </summary>
public record CustomAttributeFilter
{
    /// <summary>
    /// A query expression to filter items or item variations by matching their custom attributes'
    /// <c>boolean_value</c> property values
    /// against the specified Boolean expression.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bool_filter")]
    public bool? BoolFilter { get; init; }

    /// <summary>
    /// A query expression to filter items or item variations by matching their custom attributes'
    /// <c>custom_attribute_definition_id</c>
    /// property value against the the specified id.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_attribute_definition_id")]
    public string? CustomAttributeDefinitionId { get; init; }

    /// <summary>
    /// A query expression to filter items or item variations by matching their custom attributes'
    /// <c>key</c> property value against
    /// the specified key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// The range of a number value between the specified lower and upper bounds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number_filter")]
    public Range? NumberFilter { get; init; }

    /// <summary>
    /// A query expression to filter items or item variations by matching  their custom attributes'
    /// <c>selection_uid_values</c>
    /// values against the specified selection uids.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection_uids_filter")]
    public IReadOnlyList<string>? SelectionUidsFilter { get; init; }

    /// <summary>
    /// A query expression to filter items or item variations by matching their custom attributes'
    /// <c>string_value</c>  property value
    /// against the specified text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("string_filter")]
    public string? StringFilter { get; init; }
}
