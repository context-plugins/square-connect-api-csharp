using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the specific day  of the week.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DayOfWeek>))]
public sealed record DayOfWeek : StringEnum<DayOfWeek>
{
    private DayOfWeek(string value) : base(value)
    {
    }

    /// <summary>
    /// Sunday
    /// </summary>
    public static readonly DayOfWeek Sun = new("SUN");

    /// <summary>
    /// Monday
    /// </summary>
    public static readonly DayOfWeek Mon = new("MON");

    /// <summary>
    /// Tuesday
    /// </summary>
    public static readonly DayOfWeek Tue = new("TUE");

    /// <summary>
    /// Wednesday
    /// </summary>
    public static readonly DayOfWeek Wed = new("WED");

    /// <summary>
    /// Thursday
    /// </summary>
    public static readonly DayOfWeek Thu = new("THU");

    /// <summary>
    /// Friday
    /// </summary>
    public static readonly DayOfWeek Fri = new("FRI");

    /// <summary>
    /// Saturday
    /// </summary>
    public static readonly DayOfWeek Sat = new("SAT");

    public static DayOfWeek FromValue(string value) => FromValueCore(value);
}
