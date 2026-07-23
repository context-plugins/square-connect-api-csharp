using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Defines the logic used to apply a workday filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftWorkdayMatcher>))]
public sealed record ShiftWorkdayMatcher : StringEnum<ShiftWorkdayMatcher>
{
    private ShiftWorkdayMatcher(string value) : base(value)
    {
    }

    /// <summary>
    /// All shifts that start on or after the specified workday
    /// </summary>
    public static readonly ShiftWorkdayMatcher StartAt = new("START_AT");

    /// <summary>
    /// All shifts that end on or before the specified workday
    /// </summary>
    public static readonly ShiftWorkdayMatcher EndAt = new("END_AT");

    /// <summary>
    /// All shifts that start between the start and end workdays (inclusive)
    /// </summary>
    public static readonly ShiftWorkdayMatcher Intersection = new("INTERSECTION");

    public static ShiftWorkdayMatcher FromValue(string value) => FromValueCore(value);
}
