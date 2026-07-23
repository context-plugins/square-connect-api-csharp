using System.Collections.Generic;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Configuration associated with <c>SELECTION</c>-type custom attribute definitions.
/// </summary>
public record CatalogCustomAttributeDefinitionSelectionConfig
{
    /// <summary>
    /// The set of valid <c>CatalogCustomAttributeSelections</c>. Up to a maximum of 100
    /// selections can be defined. Can be modified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_selections")]
    public IReadOnlyList<CatalogCustomAttributeDefinitionSelectionConfigCustomAttributeSelection>? AllowedSelections { get; init; }

    /// <summary>
    /// The maximum number of selections that can be set. The maximum value for this
    /// attribute is 100. The default value is 1. The value can be modified, but changing the value will not
    /// affect existing custom attribute values on objects. Clients need to
    /// handle custom attributes with more selected values than allowed by this limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_allowed_selections")]
    [Maximum(100)]
    public int? MaxAllowedSelections { get; init; }
}
