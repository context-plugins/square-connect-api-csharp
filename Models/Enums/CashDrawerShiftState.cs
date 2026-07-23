using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The current state of a cash drawer shift.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashDrawerShiftState>))]
public sealed record CashDrawerShiftState : StringEnum<CashDrawerShiftState>
{
    private CashDrawerShiftState(string value) : base(value)
    {
    }

    /// <summary>
    /// An open cash drawer shift.
    /// </summary>
    public static readonly CashDrawerShiftState Open = new("OPEN");

    /// <summary>
    /// A cash drawer shift that is ended but has not yet had an employee content audit.
    /// </summary>
    public static readonly CashDrawerShiftState Ended = new("ENDED");

    /// <summary>
    /// An ended cash drawer shift that is closed with a completed employee
    /// content audit and recorded result.
    /// </summary>
    public static readonly CashDrawerShiftState Closed = new("CLOSED");

    public static CashDrawerShiftState FromValue(string value) => FromValueCore(value);
}
