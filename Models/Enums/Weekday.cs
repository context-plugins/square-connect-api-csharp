using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The days of the week.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Weekday>))]
public sealed record Weekday : StringEnum<Weekday>
{
    private Weekday(string value) : base(value)
    {
    }

    /// <summary>
    /// Monday
    /// </summary>
    public static readonly Weekday Mon = new("MON");

    /// <summary>
    /// Tuesday
    /// </summary>
    public static readonly Weekday Tue = new("TUE");

    /// <summary>
    /// Wednesday
    /// </summary>
    public static readonly Weekday Wed = new("WED");

    /// <summary>
    /// Thursday
    /// </summary>
    public static readonly Weekday Thu = new("THU");

    /// <summary>
    /// Friday
    /// </summary>
    public static readonly Weekday Fri = new("FRI");

    /// <summary>
    /// Saturday
    /// </summary>
    public static readonly Weekday Sat = new("SAT");

    /// <summary>
    /// Sunday
    /// </summary>
    public static readonly Weekday Sun = new("SUN");

    public static Weekday FromValue(string value) => FromValueCore(value);
}
