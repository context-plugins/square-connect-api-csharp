using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response to a request to get an <c>EmployeeWage</c>. The response contains
/// the requested <c>EmployeeWage</c> objects and might contain a set of <c>Error</c> objects if
/// the request resulted in errors.
/// </summary>
public record GetEmployeeWageResponse
{
    /// <summary>
    /// The hourly wage rate that an employee earns on a <c>Shift</c> for doing the job
    /// specified by the <c>title</c> property of this object. Deprecated at version 2020-08-26. Use <c>TeamMemberWage</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_wage")]
    public EmployeeWage? EmployeeWage { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
