using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Types of location where service is provided.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsBookingLocationType>))]
public sealed record BusinessAppointmentSettingsBookingLocationType : StringEnum<BusinessAppointmentSettingsBookingLocationType>
{
    private BusinessAppointmentSettingsBookingLocationType(string value) : base(value)
    {
    }

    /// <summary>
    /// The service is provided at a seller location.
    /// </summary>
    public static readonly BusinessAppointmentSettingsBookingLocationType BusinessLocation = new("BUSINESS_LOCATION");

    /// <summary>
    /// The service is provided at a customer location.
    /// </summary>
    public static readonly BusinessAppointmentSettingsBookingLocationType CustomerLocation = new("CUSTOMER_LOCATION");

    /// <summary>
    /// The service is provided over the phone.
    /// </summary>
    public static readonly BusinessAppointmentSettingsBookingLocationType Phone = new("PHONE");

    public static BusinessAppointmentSettingsBookingLocationType FromValue(string value) =>
        FromValueCore(value);
}
