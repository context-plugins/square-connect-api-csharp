using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a payment request reminder (automatic notification) that Square sends
/// to the customer. You configure a reminder relative to the payment request
/// <c>due_date</c>.
/// </summary>
public record InvoicePaymentReminder
{
    /// <summary>
    /// The reminder message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    [StringLength(1000, MinimumLength = 1)]
    public string? Message { get; init; }

    /// <summary>
    /// The number of days before (a negative number) or after (a positive number)
    /// the payment request <c>due_date</c> when the reminder is sent. For example, -3 indicates that
    /// the reminder should be sent 3 days before the payment request <c>due_date</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("relative_scheduled_days")]
    [Minimum(-32767)]
    [Maximum(32767)]
    public int? RelativeScheduledDays { get; init; }

    /// <summary>
    /// If sent, the timestamp when the reminder was sent, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sent_at")]
    public string? SentAt { get; init; }

    /// <summary>
    /// The status of the reminder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// A Square-assigned ID that uniquely identifies the reminder within the
    /// <c>InvoicePaymentRequest</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    public string? Uid { get; init; }
}
