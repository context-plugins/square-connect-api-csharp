using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BusinessBookingProfile
{
    /// <summary>
    /// Indicates whether customers can cancel or reschedule their own bookings (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_user_cancel")]
    public bool? AllowUserCancel { get; init; }

    /// <summary>
    /// Indicates whether the seller is open for booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_enabled")]
    public bool? BookingEnabled { get; init; }

    /// <summary>
    /// The policy for the seller to automatically accept booking requests (<c>ACCEPT_ALL</c>) or not (<c>REQUIRES_ACCEPTANCE</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_policy")]
    public string? BookingPolicy { get; init; }

    /// <summary>
    /// The service appointment settings, including where and how the service is provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_appointment_settings")]
    public BusinessAppointmentSettings? BusinessAppointmentSettings { get; init; }

    /// <summary>
    /// The RFC 3339 timestamp specifying the booking's creation time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The choice of customer's time zone information of a booking.
    /// The Square online booking site and all notifications to customers uses either the seller location’s time zone
    /// or the time zone the customer chooses at booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_timezone_choice")]
    public string? CustomerTimezoneChoice { get; init; }

    /// <summary>
    /// The ID of the seller, obtainable using the Merchants API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seller_id")]
    public string? SellerId { get; init; }
}
