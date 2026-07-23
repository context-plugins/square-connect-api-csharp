using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A tax applicable to an item.
/// </summary>
public record CatalogTax
{
    /// <summary>
    /// If <c>true</c>, the fee applies to custom amounts entered into the Square Point of Sale
    /// app that are not associated with a particular <c>CatalogItem</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applies_to_custom_amounts")]
    public bool? AppliesToCustomAmounts { get; init; }

    /// <summary>
    /// Whether the tax is calculated based on a payment's subtotal or total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("calculation_phase")]
    public string? CalculationPhase { get; init; }

    /// <summary>
    /// A Boolean flag to indicate whether the tax is displayed as enabled (<c>true</c>) in the Square Point of Sale app or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// Whether the tax is <c>ADDITIVE</c> or <c>INCLUSIVE</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inclusion_type")]
    public string? InclusionType { get; init; }

    /// <summary>
    /// The tax's name. This is a searchable attribute for use in applicable query filters, and its value length is of Unicode code points.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The percentage of the tax in decimal form, using a <c>'.'</c> as the decimal separator and without a <c>'%'</c> sign.
    /// A value of <c>7.5</c> corresponds to 7.5%.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    public string? Percentage { get; init; }
}
