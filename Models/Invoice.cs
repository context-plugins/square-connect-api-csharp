using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Stores information about an invoice. You use the Invoices API to create and manage
/// invoices. For more information, see <see href="https://developer.squareup.com/docs/invoices-api/overview">Manage Invoices Using the Invoices API</see>.
/// </summary>
public record Invoice
{
    /// <summary>
    /// The payment methods that customers can use to pay an invoice on the Square-hosted invoice page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepted_payment_methods")]
    public InvoiceAcceptedPaymentMethods? AcceptedPaymentMethods { get; init; }

    /// <summary>
    /// The timestamp when the invoice was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Additional seller-defined fields to render on the invoice. These fields are visible to sellers and buyers
    /// on the Square-hosted invoice page and in emailed or PDF copies of invoices. For more information, see
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#custom-fields">Custom fields</see>.
    /// <para>
    /// Adding custom fields to an invoice requires an
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
    /// </para>
    /// <para>
    /// Max: 2 custom fields
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_fields")]
    public IReadOnlyList<InvoiceCustomField>? CustomFields { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delivery_method")]
    public object? DeliveryMethod { get; init; }

    /// <summary>
    /// The description of the invoice. This is visible to the customer receiving the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [StringLength(65536, MinimumLength = 1)]
    public string? Description { get; init; }

    /// <summary>
    /// The Square-assigned ID of the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// A user-friendly invoice number. The value is unique within a location.
    /// If not provided when creating an invoice, Square assigns a value.
    /// It increments from 1 and padded with zeros making it 7 characters long
    /// (for example, 0000001 and 0000002).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice_number")]
    [StringLength(191, MinimumLength = 1)]
    public string? InvoiceNumber { get; init; }

    /// <summary>
    /// The ID of the location that this invoice is associated with.
    /// <para>
    /// If specified in a <c>CreateInvoice</c> request, the value must match the <c>location_id</c> of the associated order.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? LocationId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_payment_amount_money")]
    public Money? NextPaymentAmountMoney { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> for which the invoice is created.
    /// This field is required when creating an invoice, and the order must be in the <c>OPEN</c> state.
    /// <para>
    /// To view the line items and other information for the associated order, call the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/orders-api/retrieve-order">RetrieveOrder</see> endpoint using the order ID.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? OrderId { get; init; }

    /// <summary>
    /// The payment schedule for the invoice, represented by one or more payment requests that
    /// define payment settings, such as amount due and due date. An invoice supports the following payment request combinations:
    /// - One balance
    /// - One deposit with one balance
    /// - 2–12 installments
    /// - One deposit with 2–12 installments
    /// <para>
    /// This field is required when creating an invoice. It must contain at least one payment request.
    /// All payment requests for the invoice must equal the total order amount. For more information, see
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#payment-requests">Payment requests</see>.
    /// </para>
    /// <para>
    /// Adding <c>INSTALLMENT</c> payment requests to an invoice requires an
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_requests")]
    public IReadOnlyList<InvoicePaymentRequest>? PaymentRequests { get; init; }

    /// <summary>
    /// Provides customer data that Square uses to deliver an invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primary_recipient")]
    public InvoiceRecipient? PrimaryRecipient { get; init; }

    /// <summary>
    /// The URL of the Square-hosted invoice page.
    /// After you publish the invoice using the <c>PublishInvoice</c> endpoint, Square hosts the invoice
    /// page and returns the page URL in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("public_url")]
    public string? PublicUrl { get; init; }

    /// <summary>
    /// The timestamp when the invoice is scheduled for processing, in RFC 3339 format.
    /// After the invoice is published, Square processes the invoice on the specified date,
    /// according to the delivery method and payment request settings.
    /// <para>
    /// If the field is not set, Square processes the invoice immediately after it is published.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_at")]
    public string? ScheduledAt { get; init; }

    /// <summary>
    /// The status of the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Subscription">subscription</see> associated with the invoice.
    /// This field is present only on subscription billing invoices.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// The time zone used to interpret calendar dates on the invoice, such as <c>due_date</c>.
    /// When an invoice is created, this field is set to the <c>timezone</c> specified for the seller
    /// location. The value cannot be changed.
    /// <para>
    /// For example, a payment <c>due_date</c> of 2021-03-09 with a <c>timezone</c> of America/Los\_Angeles
    /// becomes overdue at midnight on March 9 in America/Los\_Angeles (which equals a UTC timestamp
    /// of 2021-03-10T08:00:00Z).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// The title of the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    [StringLength(255, MinimumLength = 1)]
    public string? Title { get; init; }

    /// <summary>
    /// The timestamp when the invoice was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The Square-assigned version number, which is incremented each time an update is committed to the invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
