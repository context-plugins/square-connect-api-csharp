using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the status of an invoice.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceStatus>))]
public sealed record InvoiceStatus : StringEnum<InvoiceStatus>
{
    private InvoiceStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The invoice is a draft. You must publish a draft invoice before Square can process it.
    /// A draft invoice has no <c>public_url</c>, so it is not available to customers.
    /// </summary>
    public static readonly InvoiceStatus Draft = new("DRAFT");

    /// <summary>
    /// The invoice is published but not yet paid.
    /// </summary>
    public static readonly InvoiceStatus Unpaid = new("UNPAID");

    /// <summary>
    /// The invoice is scheduled to be processed. On the scheduled date,
    /// Square sends the invoice, initiates an automatic payment, or takes no action, depending on
    /// the delivery method and payment request settings. Square also sets the invoice status to the
    /// appropriate state: <c>UNPAID</c>, <c>PAID</c>, <c>PARTIALLY_PAID</c>, or <c>PAYMENT_PENDING</c>.
    /// </summary>
    public static readonly InvoiceStatus Scheduled = new("SCHEDULED");

    /// <summary>
    /// A partial payment is received for the invoice.
    /// </summary>
    public static readonly InvoiceStatus PartiallyPaid = new("PARTIALLY_PAID");

    /// <summary>
    /// The customer paid the invoice in full.
    /// </summary>
    public static readonly InvoiceStatus Paid = new("PAID");

    /// <summary>
    /// The invoice is paid (or partially paid) and some but not all the amount paid is
    /// refunded.
    /// </summary>
    public static readonly InvoiceStatus PartiallyRefunded = new("PARTIALLY_REFUNDED");

    /// <summary>
    /// The full amount that the customer paid for the invoice is refunded.
    /// </summary>
    public static readonly InvoiceStatus Refunded = new("REFUNDED");

    /// <summary>
    /// The invoice is canceled. Square no longer requests payments from the customer.
    /// The <c>public_url</c> page remains and is accessible, but it displays the invoice
    /// as canceled and does not accept payment.
    /// </summary>
    public static readonly InvoiceStatus Canceled = new("CANCELED");

    /// <summary>
    /// Square canceled the invoice due to suspicious activity.
    /// </summary>
    public static readonly InvoiceStatus Failed = new("FAILED");

    /// <summary>
    /// A payment on the invoice was initiated but has not yet been processed.
    /// <para>
    /// When in this state, invoices cannot be updated and other payments cannot be initiated.
    /// </para>
    /// </summary>
    public static readonly InvoiceStatus PaymentPending = new("PAYMENT_PENDING");

    public static InvoiceStatus FromValue(string value) => FromValueCore(value);
}
