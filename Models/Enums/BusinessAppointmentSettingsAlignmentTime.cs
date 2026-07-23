using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Time units of a service duration for bookings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsAlignmentTime>))]
public sealed record BusinessAppointmentSettingsAlignmentTime : StringEnum<BusinessAppointmentSettingsAlignmentTime>
{
    private BusinessAppointmentSettingsAlignmentTime(string value) : base(value)
    {
    }

    /// <summary>
    /// The service duration unit is one visit of a fixed time interval specified by the seller.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime ServiceDuration = new("SERVICE_DURATION");

    /// <summary>
    /// The service duration unit is a 15-minute interval. Bookings can be scheduled every quarter hour.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime QuarterHourly = new("QUARTER_HOURLY");

    /// <summary>
    /// The service duration unit is a 30-minute interval. Bookings can be scheduled every half hour.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime HalfHourly = new("HALF_HOURLY");

    /// <summary>
    /// The service duration unit is a 60-minute interval. Bookings can be scheduled every hour.
    /// </summary>
    public static readonly BusinessAppointmentSettingsAlignmentTime Hourly = new("HOURLY");

    public static BusinessAppointmentSettingsAlignmentTime FromValue(string value) => FromValueCore(value);
}
