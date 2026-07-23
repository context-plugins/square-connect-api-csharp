using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Choices of customer-facing time zone used for bookings.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessBookingProfileCustomerTimezoneChoice>))]
public sealed record BusinessBookingProfileCustomerTimezoneChoice : StringEnum<BusinessBookingProfileCustomerTimezoneChoice>
{
    private BusinessBookingProfileCustomerTimezoneChoice(string value) : base(value)
    {
    }

    /// <summary>
    /// Use the time zone of the business location for bookings.
    /// </summary>
    public static readonly BusinessBookingProfileCustomerTimezoneChoice BusinessLocationTimezone = new("BUSINESS_LOCATION_TIMEZONE");

    /// <summary>
    /// Use the customer-chosen time zone for bookings.
    /// </summary>
    public static readonly BusinessBookingProfileCustomerTimezoneChoice CustomerChoice = new("CUSTOMER_CHOICE");

    public static BusinessBookingProfileCustomerTimezoneChoice FromValue(string value) => FromValueCore(value);
}
