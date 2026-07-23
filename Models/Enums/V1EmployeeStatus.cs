using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1EmployeeStatus>))]
public sealed record V1EmployeeStatus : StringEnum<V1EmployeeStatus>
{
    private V1EmployeeStatus(string value) : base(value)
    {
    }

    public static readonly V1EmployeeStatus Active = new("ACTIVE");

    public static readonly V1EmployeeStatus Inactive = new("INACTIVE");

    public static V1EmployeeStatus FromValue(string value) => FromValueCore(value);
}
