using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Contains the measurement unit for a quantity and a precision that
/// specifies the number of digits after the decimal point for decimal quantities.
/// </summary>
public record OrderQuantityUnit
{
    /// <summary>
    /// The version of the catalog object that this measurement unit references.
    /// <para>
    /// This field is set when this is a catalog-backed measurement unit.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// Represents a unit of measurement to use with a quantity, such as ounces
    /// or inches. Exactly one of the following fields are required: <c>custom_unit</c>,
    /// <c>area_unit</c>, <c>length_unit</c>, <c>volume_unit</c>, and <c>weight_unit</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("measurement_unit")]
    public MeasurementUnit? MeasurementUnit { get; init; }

    /// <summary>
    /// For non-integer quantities, represents the number of digits after the decimal point that are
    /// recorded for this quantity.
    /// <para>
    /// For example, a precision of 1 allows quantities such as <c>"1.0"</c> and <c>"1.1"</c>, but not <c>"1.01"</c>.
    /// </para>
    /// <para>
    /// Min: 0. Max: 5.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("precision")]
    public int? Precision { get; init; }
}
