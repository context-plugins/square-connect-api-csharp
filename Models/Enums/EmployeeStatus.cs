using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The status of the Employee being retrieved.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EmployeeStatus>))]
public sealed record EmployeeStatus : StringEnum<EmployeeStatus>
{
    private EmployeeStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Specifies that the employee is in the Active state.
    /// </summary>
    public static readonly EmployeeStatus Active = new("ACTIVE");

    /// <summary>
    /// Specifies that the employee is in the Inactive state.
    /// </summary>
    public static readonly EmployeeStatus Inactive = new("INACTIVE");

    public static EmployeeStatus FromValue(string value) => FromValueCore(value);
}
