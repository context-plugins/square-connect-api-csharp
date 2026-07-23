using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Enumerates the possible pay types that a job can be assigned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<JobAssignmentPayType>))]
public sealed record JobAssignmentPayType : StringEnum<JobAssignmentPayType>
{
    private JobAssignmentPayType(string value) : base(value)
    {
    }

    /// <summary>
    /// The job does not have a defined pay type.
    /// </summary>
    public static readonly JobAssignmentPayType None = new("NONE");

    /// <summary>
    /// The job pays an hourly rate.
    /// </summary>
    public static readonly JobAssignmentPayType Hourly = new("HOURLY");

    /// <summary>
    /// The job pays an annual salary.
    /// </summary>
    public static readonly JobAssignmentPayType Salary = new("SALARY");

    public static JobAssignmentPayType FromValue(string value) => FromValueCore(value);
}
