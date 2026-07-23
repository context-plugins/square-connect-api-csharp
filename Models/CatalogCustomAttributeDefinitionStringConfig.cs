using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Configuration associated with Custom Attribute Definitions of type <c>STRING</c>.
/// </summary>
public record CatalogCustomAttributeDefinitionStringConfig
{
    /// <summary>
    /// If true, each Custom Attribute instance associated with this Custom Attribute
    /// Definition must have a unique value within the seller's catalog. For
    /// example, this may be used for a value like a SKU that should not be
    /// duplicated within a seller's catalog. May not be modified after the
    /// definition has been created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enforce_uniqueness")]
    public bool? EnforceUniqueness { get; init; }
}
