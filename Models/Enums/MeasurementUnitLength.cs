using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The unit of length used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitLength>))]
public sealed record MeasurementUnitLength : StringEnum<MeasurementUnitLength>
{
    private MeasurementUnitLength(string value) : base(value)
    {
    }

    /// <summary>
    /// The length is measured in inches.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialInch = new("IMPERIAL_INCH");

    /// <summary>
    /// The length is measured in feet.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialFoot = new("IMPERIAL_FOOT");

    /// <summary>
    /// The length is measured in yards.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialYard = new("IMPERIAL_YARD");

    /// <summary>
    /// The length is measured in miles.
    /// </summary>
    public static readonly MeasurementUnitLength ImperialMile = new("IMPERIAL_MILE");

    /// <summary>
    /// The length is measured in millimeters.
    /// </summary>
    public static readonly MeasurementUnitLength MetricMillimeter = new("METRIC_MILLIMETER");

    /// <summary>
    /// The length is measured in centimeters.
    /// </summary>
    public static readonly MeasurementUnitLength MetricCentimeter = new("METRIC_CENTIMETER");

    /// <summary>
    /// The length is measured in meters.
    /// </summary>
    public static readonly MeasurementUnitLength MetricMeter = new("METRIC_METER");

    /// <summary>
    /// The length is measured in kilometers.
    /// </summary>
    public static readonly MeasurementUnitLength MetricKilometer = new("METRIC_KILOMETER");

    public static MeasurementUnitLength FromValue(string value) => FromValueCore(value);
}
