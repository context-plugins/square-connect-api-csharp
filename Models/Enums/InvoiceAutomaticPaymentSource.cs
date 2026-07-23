using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the automatic payment method for an <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InvoicePaymentRequest">invoice payment request</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceAutomaticPaymentSource>))]
public sealed record InvoiceAutomaticPaymentSource : StringEnum<InvoiceAutomaticPaymentSource>
{
    private InvoiceAutomaticPaymentSource(string value) : base(value)
    {
    }

    /// <summary>
    /// An automatic payment is not configured for the payment request.
    /// </summary>
    public static readonly InvoiceAutomaticPaymentSource None = new("NONE");

    /// <summary>
    /// Use a card on file as the automatic payment method. On the due date, Square charges the card
    /// for the amount of the payment request.
    /// <para>
    /// For <c>CARD_ON_FILE</c> payments, the invoice delivery method must be <c>EMAIL</c> and <c>card_id</c> must be
    /// specified for the payment request before the invoice can be published.
    /// </para>
    /// </summary>
    public static readonly InvoiceAutomaticPaymentSource CardOnFile = new("CARD_ON_FILE");

    /// <summary>
    /// Use a bank account on file as the automatic payment method. On the due date, Square charges the bank
    /// account for the amount of the payment request.
    /// <para>
    /// This payment method applies only to recurring invoices that sellers create in the Seller Dashboard or other
    /// Square first-party applications. The bank account is provided by the customer during the payment flow.
    /// </para>
    /// <para>
    /// You cannot set <c>BANK_ON_FILE</c> as a payment method using the Invoices API, but you can change a <c>BANK_ON_FILE</c>
    /// payment method to <c>NONE</c> or <c>CARD_ON_FILE</c>. For <c>BANK_ON_FILE</c> payments, the invoice delivery method must be <c>EMAIL</c>.
    /// </para>
    /// </summary>
    public static readonly InvoiceAutomaticPaymentSource BankOnFile = new("BANK_ON_FILE");

    public static InvoiceAutomaticPaymentSource FromValue(string value) => FromValueCore(value);
}
