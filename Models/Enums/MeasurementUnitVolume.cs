using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The unit of volume used to measure a quantity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitVolume>))]
public sealed record MeasurementUnitVolume : StringEnum<MeasurementUnitVolume>
{
    private MeasurementUnitVolume(string value) : base(value)
    {
    }

    /// <summary>
    /// The volume is measured in ounces.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericFluidOunce = new("GENERIC_FLUID_OUNCE");

    /// <summary>
    /// The volume is measured in shots.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericShot = new("GENERIC_SHOT");

    /// <summary>
    /// The volume is measured in cups.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericCup = new("GENERIC_CUP");

    /// <summary>
    /// The volume is measured in pints.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericPint = new("GENERIC_PINT");

    /// <summary>
    /// The volume is measured in quarts.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericQuart = new("GENERIC_QUART");

    /// <summary>
    /// The volume is measured in gallons.
    /// </summary>
    public static readonly MeasurementUnitVolume GenericGallon = new("GENERIC_GALLON");

    /// <summary>
    /// The volume is measured in cubic inches.
    /// </summary>
    public static readonly MeasurementUnitVolume ImperialCubicInch = new("IMPERIAL_CUBIC_INCH");

    /// <summary>
    /// The volume is measured in cubic feet.
    /// </summary>
    public static readonly MeasurementUnitVolume ImperialCubicFoot = new("IMPERIAL_CUBIC_FOOT");

    /// <summary>
    /// The volume is measured in cubic yards.
    /// </summary>
    public static readonly MeasurementUnitVolume ImperialCubicYard = new("IMPERIAL_CUBIC_YARD");

    /// <summary>
    /// The volume is measured in metric milliliters.
    /// </summary>
    public static readonly MeasurementUnitVolume MetricMilliliter = new("METRIC_MILLILITER");

    /// <summary>
    /// The volume is measured in metric liters.
    /// </summary>
    public static readonly MeasurementUnitVolume MetricLiter = new("METRIC_LITER");

    public static MeasurementUnitVolume FromValue(string value) => FromValueCore(value);
}
