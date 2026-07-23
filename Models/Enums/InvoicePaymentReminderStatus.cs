using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The status of a payment request reminder.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoicePaymentReminderStatus>))]
public sealed record InvoicePaymentReminderStatus : StringEnum<InvoicePaymentReminderStatus>
{
    private InvoicePaymentReminderStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The reminder will be sent on the <c>relative_scheduled_date</c> (if the invoice is published).
    /// </summary>
    public static readonly InvoicePaymentReminderStatus Pending = new("PENDING");

    /// <summary>
    /// The reminder is not applicable and is not sent. The following are examples
    /// of when reminders are not applicable and are not sent:
    /// - You schedule a reminder to be sent before the invoice is published.
    /// - The invoice is configured with multiple payment requests and a payment request reminder
    /// is configured to be sent after the next payment request <c>due_date</c>.
    /// - Two reminders (for different payment requests) are configured to be sent on the
    /// same date. Therefore, only one reminder is sent.
    /// - You configure a reminder to be sent on the date that the invoice is scheduled to be sent.
    /// - The payment request is already paid.
    /// - The invoice status is <c>CANCELED</c> or <c>FAILED</c>.
    /// </summary>
    public static readonly InvoicePaymentReminderStatus NotApplicable = new("NOT_APPLICABLE");

    /// <summary>
    /// The reminder is sent.
    /// </summary>
    public static readonly InvoicePaymentReminderStatus Sent = new("SENT");

    public static InvoicePaymentReminderStatus FromValue(string value) => FromValueCore(value);
}
