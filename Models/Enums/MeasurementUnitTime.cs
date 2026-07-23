using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Unit of time used to measure a quantity (a duration).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitTime>))]
public sealed record MeasurementUnitTime : StringEnum<MeasurementUnitTime>
{
    private MeasurementUnitTime(string value) : base(value)
    {
    }

    /// <summary>
    /// The time is measured in milliseconds.
    /// </summary>
    public static readonly MeasurementUnitTime GenericMillisecond = new("GENERIC_MILLISECOND");

    /// <summary>
    /// The time is measured in seconds.
    /// </summary>
    public static readonly MeasurementUnitTime GenericSecond = new("GENERIC_SECOND");

    /// <summary>
    /// The time is measured in minutes.
    /// </summary>
    public static readonly MeasurementUnitTime GenericMinute = new("GENERIC_MINUTE");

    /// <summary>
    /// The time is measured in hours.
    /// </summary>
    public static readonly MeasurementUnitTime GenericHour = new("GENERIC_HOUR");

    /// <summary>
    /// The time is measured in days.
    /// </summary>
    public static readonly MeasurementUnitTime GenericDay = new("GENERIC_DAY");

    public static MeasurementUnitTime FromValue(string value) => FromValueCore(value);
}
