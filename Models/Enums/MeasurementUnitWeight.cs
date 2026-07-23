using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Unit of weight used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitWeight>))]
public sealed record MeasurementUnitWeight : StringEnum<MeasurementUnitWeight>
{
    private MeasurementUnitWeight(string value) : base(value)
    {
    }

    /// <summary>
    /// The weight is measured in ounces.
    /// </summary>
    public static readonly MeasurementUnitWeight ImperialWeightOunce = new("IMPERIAL_WEIGHT_OUNCE");

    /// <summary>
    /// The weight is measured in pounds.
    /// </summary>
    public static readonly MeasurementUnitWeight ImperialPound = new("IMPERIAL_POUND");

    /// <summary>
    /// The weight is measured in stones.
    /// </summary>
    public static readonly MeasurementUnitWeight ImperialStone = new("IMPERIAL_STONE");

    /// <summary>
    /// The weight is measured in milligrams.
    /// </summary>
    public static readonly MeasurementUnitWeight MetricMilligram = new("METRIC_MILLIGRAM");

    /// <summary>
    /// The weight is measured in grams.
    /// </summary>
    public static readonly MeasurementUnitWeight MetricGram = new("METRIC_GRAM");

    /// <summary>
    /// The weight is measured in kilograms.
    /// </summary>
    public static readonly MeasurementUnitWeight MetricKilogram = new("METRIC_KILOGRAM");

    public static MeasurementUnitWeight FromValue(string value) => FromValueCore(value);
}
