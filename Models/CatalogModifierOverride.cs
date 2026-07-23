using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Options to control how to override the default behavior of the specified modifier.
/// </summary>
public record CatalogModifierOverride
{
    /// <summary>
    /// The ID of the <c>CatalogModifier</c> whose default behavior is being overridden.
    /// </summary>
    [JsonPropertyName("modifier_id")]
    [MinLength(1)]
    public required string ModifierId { get; init; }

    /// <summary>
    /// If <c>true</c>, this <c>CatalogModifier</c> should be selected by default for this <c>CatalogItem</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("on_by_default")]
    public bool? OnByDefault { get; init; }
}
