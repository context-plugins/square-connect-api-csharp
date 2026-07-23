using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record V1UpdateEmployeeRoleRequest
{
    /// <summary>
    /// V1EmployeeRole
    /// </summary>
    [JsonPropertyName("body")]
    public required V1EmployeeRole Body { get; init; }
}
