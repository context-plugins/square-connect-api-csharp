using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Enumerates the <c>Shift</c> fields to sort on.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftSortField>))]
public sealed record ShiftSortField : StringEnum<ShiftSortField>
{
    private ShiftSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The start date/time of a <c>Shift</c>
    /// </summary>
    public static readonly ShiftSortField StartAt = new("START_AT");

    /// <summary>
    /// The end date/time of a <c>Shift</c>
    /// </summary>
    public static readonly ShiftSortField EndAt = new("END_AT");

    /// <summary>
    /// The date/time that a <c>Shift</c> is created
    /// </summary>
    public static readonly ShiftSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// The most recent date/time that a <c>Shift</c> is updated
    /// </summary>
    public static readonly ShiftSortField UpdatedAt = new("UPDATED_AT");

    public static ShiftSortField FromValue(string value) => FromValueCore(value);
}
