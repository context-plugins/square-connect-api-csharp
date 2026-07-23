using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Specifies the <c>status</c> of <c>Shift</c> records to be returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShiftFilterStatus>))]
public sealed record ShiftFilterStatus : StringEnum<ShiftFilterStatus>
{
    private ShiftFilterStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Shifts that have been started and not ended.
    /// </summary>
    public static readonly ShiftFilterStatus Open = new("OPEN");

    /// <summary>
    /// Shifts that have been started and ended.
    /// </summary>
    public static readonly ShiftFilterStatus Closed = new("CLOSED");

    public static ShiftFilterStatus FromValue(string value) => FromValueCore(value);
}
