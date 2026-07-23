using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListEmployeesRequestStatus>))]
public sealed record V1ListEmployeesRequestStatus : StringEnum<V1ListEmployeesRequestStatus>
{
    private V1ListEmployeesRequestStatus(string value) : base(value)
    {
    }

    public static readonly V1ListEmployeesRequestStatus Active = new("ACTIVE");

    public static readonly V1ListEmployeesRequestStatus Inactive = new("INACTIVE");

    public static V1ListEmployeesRequestStatus FromValue(string value) => FromValueCore(value);
}
