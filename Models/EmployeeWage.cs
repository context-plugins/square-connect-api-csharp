using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The hourly wage rate that an employee earns on a <c>Shift</c> for doing the job
/// specified by the <c>title</c> property of this object. Deprecated at version 2020-08-26. Use <c>TeamMemberWage</c> instead.
/// </summary>
public record EmployeeWage
{
    /// <summary>
    /// The <c>Employee</c> that this wage is assigned to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("employee_id")]
    public string? EmployeeId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hourly_rate")]
    public Money? HourlyRate { get; init; }

    /// <summary>
    /// The UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The job title that this wage relates to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }
}
