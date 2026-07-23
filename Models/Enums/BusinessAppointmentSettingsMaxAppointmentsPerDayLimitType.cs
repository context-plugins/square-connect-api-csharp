using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Types of daily appointment limits.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType>))]
public sealed record BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType : StringEnum<BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType>
{
    private BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType(string value) : base(value)
    {
    }

    /// <summary>
    /// The maximum number of daily appointments is set on a per team member basis.
    /// </summary>
    public static readonly BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType PerTeamMember = new("PER_TEAM_MEMBER");

    /// <summary>
    /// The maximum number of daily appointments is set on a per location basis.
    /// </summary>
    public static readonly BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType PerLocation = new("PER_LOCATION");

    public static BusinessAppointmentSettingsMaxAppointmentsPerDayLimitType FromValue(string value) =>
        FromValueCore(value);
}
