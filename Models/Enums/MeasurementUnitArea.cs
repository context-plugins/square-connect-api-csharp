using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Unit of area used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitArea>))]
public sealed record MeasurementUnitArea : StringEnum<MeasurementUnitArea>
{
    private MeasurementUnitArea(string value) : base(value)
    {
    }

    /// <summary>
    /// The area is measured in acres.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialAcre = new("IMPERIAL_ACRE");

    /// <summary>
    /// The area is measured in square inches.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareInch = new("IMPERIAL_SQUARE_INCH");

    /// <summary>
    /// The area is measured in square feet.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareFoot = new("IMPERIAL_SQUARE_FOOT");

    /// <summary>
    /// The area is measured in square yards.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareYard = new("IMPERIAL_SQUARE_YARD");

    /// <summary>
    /// The area is measured in square miles.
    /// </summary>
    public static readonly MeasurementUnitArea ImperialSquareMile = new("IMPERIAL_SQUARE_MILE");

    /// <summary>
    /// The area is measured in square centimeters.
    /// </summary>
    public static readonly MeasurementUnitArea MetricSquareCentimeter = new("METRIC_SQUARE_CENTIMETER");

    /// <summary>
    /// The area is measured in square meters.
    /// </summary>
    public static readonly MeasurementUnitArea MetricSquareMeter = new("METRIC_SQUARE_METER");

    /// <summary>
    /// The area is measured in square kilometers.
    /// </summary>
    public static readonly MeasurementUnitArea MetricSquareKilometer = new("METRIC_SQUARE_KILOMETER");

    public static MeasurementUnitArea FromValue(string value) => FromValueCore(value);
}
