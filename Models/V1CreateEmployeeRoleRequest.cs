using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record V1CreateEmployeeRoleRequest
{
    /// <summary>
    /// V1EmployeeRole
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_role")]
    public V1EmployeeRole? EmployeeRole { get; init; }
}
