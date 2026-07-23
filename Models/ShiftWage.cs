using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The hourly wage rate used to compensate an employee for this shift.
/// </summary>
public record ShiftWage
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
    [JsonPropertyName("hourly_rate")]
    public Money? HourlyRate { get; init; }

    /// <summary>
    /// The name of the job performed during this shift. Square
    /// labor-reporting UIs might group shifts together by title.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }
}
