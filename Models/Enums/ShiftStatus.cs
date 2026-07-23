using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Enumerates the possible status of a <c>Shift</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftStatus>))]
public sealed record ShiftStatus : StringEnum<ShiftStatus>
{
    private ShiftStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Employee started a work shift and the shift is not complete
    /// </summary>
    public static readonly ShiftStatus Open = new("OPEN");

    /// <summary>
    /// Employee started and ended a work shift.
    /// </summary>
    public static readonly ShiftStatus Closed = new("CLOSED");

    public static ShiftStatus FromValue(string value) => FromValueCore(value);
}
