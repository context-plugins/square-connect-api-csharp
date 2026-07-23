using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the unit used to measure a <c>CatalogItemVariation</c> and
/// specifies the precision for decimal quantities.
/// </summary>
public record CatalogMeasurementUnit
{
    /// <summary>
    /// Represents a unit of measurement to use with a quantity, such as ounces
    /// or inches. Exactly one of the following fields are required: <c>custom_unit</c>,
    /// <c>area_unit</c>, <c>length_unit</c>, <c>volume_unit</c>, and <c>weight_unit</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit")]
    public MeasurementUnit? MeasurementUnit { get; init; }

    /// <summary>
    /// An integer between 0 and 5 that represents the maximum number of
    /// positions allowed after the decimal in quantities measured with this unit.
    /// For example:
    /// <list type="bullet">
    ///   <item><description>if the precision is 0, the quantity can be 1, 2, 3, etc.</description></item>
    ///   <item><description>if the precision is 1, the quantity can be 0.1, 0.2, etc.</description></item>
    ///   <item><description>if the precision is 2, the quantity can be 0.01, 0.12, etc.</description></item>
    /// </list>
    /// <para>
    /// Default: 3
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("precision")]
    public int? Precision { get; init; }
}
