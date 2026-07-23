using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a unit of measurement to use with a quantity, such as ounces
/// or inches. Exactly one of the following fields are required: <c>custom_unit</c>,
/// <c>area_unit</c>, <c>length_unit</c>, <c>volume_unit</c>, and <c>weight_unit</c>.
/// </summary>
public record MeasurementUnit
{
    /// <summary>
    /// Represents a standard area unit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("area_unit")]
    public string? AreaUnit { get; init; }

    /// <summary>
    /// The information needed to define a custom unit, provided by the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_unit")]
    public MeasurementUnitCustom? CustomUnit { get; init; }

    /// <summary>
    /// Reserved for API integrations that lack the ability to specify a real measurement unit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generic_unit")]
    public string? GenericUnit { get; init; }

    /// <summary>
    /// Represents a standard length unit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("length_unit")]
    public string? LengthUnit { get; init; }

    /// <summary>
    /// Represents a standard unit of time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_unit")]
    public string? TimeUnit { get; init; }

    /// <summary>
    /// Represents the type of the measurement unit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// Represents a standard volume unit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume_unit")]
    public string? VolumeUnit { get; init; }

    /// <summary>
    /// Represents a standard unit of weight or mass.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weight_unit")]
    public string? WeightUnit { get; init; }
}
