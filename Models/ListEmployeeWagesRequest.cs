using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// A request for a set of <c>EmployeeWage</c> objects.
/// </summary>
public record ListEmployeeWagesRequest
{
    /// <summary>
    /// A pointer to the next page of <c>EmployeeWage</c> results to fetch.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Filter the returned wages to only those that are associated with the specified employee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; init; }

    /// <summary>
    /// The maximum number of <c>EmployeeWage</c> results to return per page. The number can range between
    /// 1 and 200. The default is 200.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(200)]
    public int? Limit { get; init; }
}
