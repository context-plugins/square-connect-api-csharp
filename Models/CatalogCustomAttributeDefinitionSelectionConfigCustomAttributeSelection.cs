using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A named selection for this <c>SELECTION</c>-type custom attribute definition.
/// </summary>
public record CatalogCustomAttributeDefinitionSelectionConfigCustomAttributeSelection
{
    /// <summary>
    /// Selection name, unique within <c>allowed_selections</c>.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(255, MinimumLength = 1)]
    public required string Name { get; init; }

    /// <summary>
    /// Unique ID set by Square.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    public string? Uid { get; init; }
}
