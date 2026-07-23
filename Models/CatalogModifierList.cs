using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A list of modifiers applicable to items at the time of sale.
/// <para>
/// For example, a "Condiments" modifier list applicable to a "Hot Dog" item
/// may contain "Ketchup", "Mustard", and "Relish" modifiers.
/// Use the <c>selection_type</c> field to specify whether or not multiple selections from
/// the modifier list are allowed.
/// </para>
/// </summary>
public record CatalogModifierList
{
    /// <summary>
    /// The options included in the <c>CatalogModifierList</c>.
    /// You must include at least one <c>CatalogModifier</c>.
    /// Each CatalogObject must have type <c>MODIFIER</c> and contain
    /// <c>CatalogModifier</c> data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifiers")]
    public IReadOnlyList<CatalogObject>? Modifiers { get; init; }

    /// <summary>
    /// The name for the <c>CatalogModifierList</c> instance. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// Determines where this modifier list appears in a list of <c>CatalogModifierList</c> values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public int? Ordinal { get; init; }

    /// <summary>
    /// Indicates whether multiple options from the modifier list
    /// can be applied to a single <c>CatalogItem</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection_type")]
    public string? SelectionType { get; init; }
}
