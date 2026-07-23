using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// An object describing a job that a team member is assigned to.
/// </summary>
public record JobAssignment
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annual_rate")]
    public Money? AnnualRate { get; init; }

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
    /// The title of the job.
    /// </summary>
    [JsonPropertyName("job_title")]
    [MinLength(1)]
    public required string JobTitle { get; init; }

    /// <summary>
    /// The current pay type for the job assignment used to
    /// calculate the pay amount in a pay period.
    /// </summary>
    [JsonPropertyName("pay_type")]
    public required string PayType { get; init; }

    /// <summary>
    /// The planned hours per week for the job. Set if the job <c>PayType</c> is <c>SALARY</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("weekly_hours")]
    public int? WeeklyHours { get; init; }
}
