using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Contains the name and abbreviation for standard measurement unit.
/// </summary>
public record StandardUnitDescription
{
    /// <summary>
    /// UI display abbreviation for the measurement unit. For example, 'lb'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("abbreviation")]
    public string? Abbreviation { get; init; }

    /// <summary>
    /// UI display name of the measurement unit. For example, 'Pound'.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Represents a unit of measurement to use with a quantity, such as ounces
    /// or inches. Exactly one of the following fields are required: <c>custom_unit</c>,
    /// <c>area_unit</c>, <c>length_unit</c>, <c>volume_unit</c>, and <c>weight_unit</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unit")]
    public MeasurementUnit? Unit { get; init; }
}
