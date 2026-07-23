using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MeasurementUnitGeneric>))]
public sealed record MeasurementUnitGeneric : StringEnum<MeasurementUnitGeneric>
{
    private MeasurementUnitGeneric(string value) : base(value)
    {
    }

    /// <summary>
    /// The generic unit.
    /// </summary>
    public static readonly MeasurementUnitGeneric Unit = new("UNIT");

    public static MeasurementUnitGeneric FromValue(string value) => FromValueCore(value);
}
