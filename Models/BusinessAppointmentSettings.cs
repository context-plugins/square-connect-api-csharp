using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The service appointment settings, including where and how the service is provided.
/// </summary>
public record BusinessAppointmentSettings
{
    /// <summary>
    /// The time unit of the service duration for bookings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alignment_time")]
    public string? AlignmentTime { get; init; }

    /// <summary>
    /// Indicates whether a customer can choose from all available time slots and have a staff member assigned
    /// automatically (<c>true</c>) or not (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("any_team_member_booking_enabled")]
    public bool? AnyTeamMemberBookingEnabled { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_fee_money")]
    public Money? CancellationFeeMoney { get; init; }

    /// <summary>
    /// The cancellation policy adopted by the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_policy")]
    public string? CancellationPolicy { get; init; }

    /// <summary>
    /// The free-form text of the seller's cancellation policy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_policy_text")]
    public string? CancellationPolicyText { get; init; }

    /// <summary>
    /// The cut-off time in seconds for allowing clients to cancel or reschedule an appointment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancellation_window_seconds")]
    public int? CancellationWindowSeconds { get; init; }

    /// <summary>
    /// Types of the location allowed for bookings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_types")]
    public IReadOnlyList<string>? LocationTypes { get; init; }

    /// <summary>
    /// The maximum number of daily appointments per team member or per location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_appointments_per_day_limit")]
    public int? MaxAppointmentsPerDayLimit { get; init; }

    /// <summary>
    /// Indicates whether the daily appointment limit applies to team members or to
    /// business locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_appointments_per_day_limit_type")]
    public string? MaxAppointmentsPerDayLimitType { get; init; }

    /// <summary>
    /// The maximum lead time in seconds before a service can be booked. Bookings must be created at most this far ahead of the booking's starting time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_booking_lead_time_seconds")]
    public int? MaxBookingLeadTimeSeconds { get; init; }

    /// <summary>
    /// The minimum lead time in seconds before a service can be booked. Bookings must be created at least this far ahead of the booking's starting time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min_booking_lead_time_seconds")]
    public int? MinBookingLeadTimeSeconds { get; init; }

    /// <summary>
    /// Indicates whether a customer can book multiple services in a single online booking.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("multiple_service_booking_enabled")]
    public bool? MultipleServiceBookingEnabled { get; init; }

    /// <summary>
    /// Indicates whether customers has an assigned staff member (<c>true</c>) or can select s staff member of their choice (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_booking_flow_staff_selection")]
    public bool? SkipBookingFlowStaffSelection { get; init; }
}
