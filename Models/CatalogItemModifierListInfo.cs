using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Options to control the properties of a <c>CatalogModifierList</c> applied to a <c>CatalogItem</c> instance.
/// </summary>
public record CatalogItemModifierListInfo
{
    /// <summary>
    /// If <c>true</c>, enable this <c>CatalogModifierList</c>. The default value is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// If 0 or larger, the largest number of <c>CatalogModifier</c>s that can be selected from this <c>CatalogModifierList</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_selected_modifiers")]
    public int? MaxSelectedModifiers { get; init; }

    /// <summary>
    /// If 0 or larger, the smallest number of <c>CatalogModifier</c>s that must be selected from this <c>CatalogModifierList</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_selected_modifiers")]
    public int? MinSelectedModifiers { get; init; }

    /// <summary>
    /// The ID of the <c>CatalogModifierList</c> controlled by this <c>CatalogModifierListInfo</c>.
    /// </summary>
    [JsonPropertyName("modifier_list_id")]
    [MinLength(1)]
    public required string ModifierListId { get; init; }

    /// <summary>
    /// A set of <c>CatalogModifierOverride</c> objects that override whether a given <c>CatalogModifier</c> is enabled by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_overrides")]
    public IReadOnlyList<CatalogModifierOverride>? ModifierOverrides { get; init; }
}
