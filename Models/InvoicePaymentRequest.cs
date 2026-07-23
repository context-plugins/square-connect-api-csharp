using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a payment request for an <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see>. Invoices can specify a maximum
/// of 13 payment requests, with up to 12 <c>INSTALLMENT</c> request types. For more information,
/// see <see href="https://developer.squareup.com/docs/invoices-api/overview#payment-requests">Payment requests</see>.
/// <para>
/// Adding <c>INSTALLMENT</c> payment requests to an invoice requires an
/// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
/// </para>
/// </summary>
public record InvoicePaymentRequest
{
    /// <summary>
    /// The payment method for an automatic payment.
    /// <para>
    /// The default value is <c>NONE</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("automatic_payment_source")]
    public string? AutomaticPaymentSource { get; init; }

    /// <summary>
    /// The ID of the credit or debit card on file to charge for the payment request. To get the cards on file for a customer,
    /// call <see href="https://developer.squareup.com/reference/square_2021-08-18/cards-api/list-cards">ListCards</see> and include the <c>customer_id</c> of the invoice recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? CardId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("computed_amount_money")]
    public Money? ComputedAmountMoney { get; init; }

    /// <summary>
    /// The due date (in the invoice's time zone) for the payment request, in <c>YYYY-MM-DD</c> format. This field
    /// is required to create a payment request.
    /// <para>
    /// After this date, the invoice becomes overdue. For example, a payment <c>due_date</c> of 2021-03-09 with a <c>timezone</c>
    /// of America/Los\_Angeles becomes overdue at midnight on March 9 in America/Los\_Angeles (which equals a UTC
    /// timestamp of 2021-03-10T08:00:00Z).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("due_date")]
    public string? DueDate { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixed_amount_requested_money")]
    public Money? FixedAmountRequestedMoney { get; init; }

    /// <summary>
    /// Specifies the amount for the payment request in percentage:
    /// <para>
    /// - When the payment <c>request_type</c> is <c>DEPOSIT</c>, it is the percentage of the order's total amount.
    /// - When the payment <c>request_type</c> is <c>INSTALLMENT</c>, it is the percentage of the order's total less
    /// the deposit, if requested. The sum of the <c>percentage_requested</c> in all installment
    /// payment requests must be equal to 100.
    /// </para>
    /// <para>
    /// You cannot specify this when the payment <c>request_type</c> is <c>BALANCE</c> or when the
    /// payment request specifies the <c>fixed_amount_requested_money</c> field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage_requested")]
    public string? PercentageRequested { get; init; }

    /// <summary>
    /// A list of one or more reminders to send for the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reminders")]
    public IReadOnlyList<InvoicePaymentReminder>? Reminders { get; init; }

    /// <summary>
    /// Indicates how Square processes the payment request. DEPRECATED at version 2021-01-21. Replaced by the
    /// <c>Invoice.delivery_method</c> and <c>InvoicePaymentRequest.automatic_payment_source</c> fields.
    /// <para>
    /// One of the following is required when creating an invoice:
    /// - (Recommended) The <c>delivery_method</c> field of the invoice. To configure an automatic payment, the
    /// <c>automatic_payment_source</c> field of the payment request is also required.
    /// - This <c>request_method</c> field. Note that <c>invoice</c> objects returned in responses do not include <c>request_method</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_method")]
    public string? RequestMethod { get; init; }

    /// <summary>
    /// Identifies the payment request type. This type defines how the payment request amount is determined.
    /// This field is required to create a payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_type")]
    public string? RequestType { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rounding_adjustment_included_money")]
    public Money? RoundingAdjustmentIncludedMoney { get; init; }

    /// <summary>
    /// If set to true, the Square-hosted invoice page (the <c>public_url</c> field of the invoice)
    /// provides a place for the customer to pay a tip.
    /// <para>
    /// This field is allowed only on the final payment request
    /// and the payment <c>request_type</c> must be <c>BALANCE</c> or <c>INSTALLMENT</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tipping_enabled")]
    public bool? TippingEnabled { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_completed_amount_money")]
    public Money? TotalCompletedAmountMoney { get; init; }

    /// <summary>
    /// The Square-generated ID of the payment request in an <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [StringLength(255, MinimumLength = 1)]
    public string? Uid { get; init; }
}
