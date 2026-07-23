using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Describes the type of this unit and indicates which field contains the unit information. This is an ‘open’ enum.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MeasurementUnitUnitType>))]
public sealed record MeasurementUnitUnitType : StringEnum<MeasurementUnitUnitType>
{
    private MeasurementUnitUnitType(string value) : base(value)
    {
    }

    /// <summary>
    /// The unit details are contained in the custom_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeCustom = new("TYPE_CUSTOM");

    /// <summary>
    /// The unit details are contained in the area_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeArea = new("TYPE_AREA");

    /// <summary>
    /// The unit details are contained in the length_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeLength = new("TYPE_LENGTH");

    /// <summary>
    /// The unit details are contained in the volume_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeVolume = new("TYPE_VOLUME");

    /// <summary>
    /// The unit details are contained in the weight_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeWeight = new("TYPE_WEIGHT");

    /// <summary>
    /// The unit details are contained in the generic_unit field.
    /// </summary>
    public static readonly MeasurementUnitUnitType TypeGeneric = new("TYPE_GENERIC");

    public static MeasurementUnitUnitType FromValue(string value) => FromValueCore(value);
}
