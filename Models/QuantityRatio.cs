using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A whole number or unreduced fractional ratio.
/// </summary>
public record QuantityRatio
{
    /// <summary>
    /// The whole or fractional quantity as the numerator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    /// <summary>
    /// The whole or fractional quantity as the denominator.
    /// In the case of fractional quantity this field is the denominator and quantity is the numerator.
    /// When unspecified, the value is <c>1</c>. For example, when <c>quantity=3</c> and <c>quantity_donominator</c> is unspecified,
    /// the quantity ratio is <c>3</c> or <c>3/1</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity_denominator")]
    public int? QuantityDenominator { get; init; }
}
