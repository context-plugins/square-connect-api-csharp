using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The category of the seller’s cancellation policy.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsCancellationPolicy>))]
public sealed record BusinessAppointmentSettingsCancellationPolicy : StringEnum<BusinessAppointmentSettingsCancellationPolicy>
{
    private BusinessAppointmentSettingsCancellationPolicy(string value) : base(value)
    {
    }

    /// <summary>
    /// Cancellations are treated as no shows and may incur a fee as specified by <c>cancellation_fee_money</c>.
    /// </summary>
    public static readonly BusinessAppointmentSettingsCancellationPolicy CancellationTreatedAsNoShow = new("CANCELLATION_TREATED_AS_NO_SHOW");

    /// <summary>
    /// Cancellations follow the seller-specified policy that is described in free-form text and not enforced automatically by Square.
    /// </summary>
    public static readonly BusinessAppointmentSettingsCancellationPolicy CustomPolicy = new("CUSTOM_POLICY");

    public static BusinessAppointmentSettingsCancellationPolicy FromValue(string value) => FromValueCore(value);
}
