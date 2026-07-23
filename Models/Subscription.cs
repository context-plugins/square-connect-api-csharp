using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a customer subscription to a subscription plan.
/// For an overview of the <c>Subscription</c> type, see
/// <see href="https://developer.squareup.com/docs/subscriptions-api/overview#subscription-object-overview">Subscription object</see>.
/// </summary>
public record Subscription
{
    /// <summary>
    /// The subscription cancellation date, in YYYY-MM-DD format (for
    /// example, 2013-01-15). On this date, the subscription status changes
    /// to <c>CANCELED</c> and the subscription billing stops.
    /// If you don't set this field, the subscription plan dictates if and
    /// when subscription ends.
    /// <para>
    /// You cannot update this field, you can only clear it.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_date")]
    public string? CanceledDate { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Customer">customer</see> <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Card">card</see>
    /// that is charged for the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_id")]
    public string? CardId { get; init; }

    /// <summary>
    /// The date up to which the customer is invoiced for the
    /// subscription, in YYYY-MM-DD format (for example, 2013-01-15).
    /// <para>
    /// After the invoice is sent for a given billing period,
    /// this date will be the last day of the billing period.
    /// For example,
    /// suppose for the month of May a customer gets an invoice
    /// (or charged the card) on May 1. For the monthly billing scenario,
    /// this date is then set to May 31.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("charged_through_date")]
    public string? ChargedThroughDate { get; init; }

    /// <summary>
    /// The timestamp when the subscription was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The ID of the associated <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Customer">customer</see> profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The Square-assigned ID of the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// The IDs of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoices</see> created for the
    /// subscription, listed in order when the invoices were created
    /// (oldest invoices appear first).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice_ids")]
    public IReadOnlyList<string>? InvoiceIds { get; init; }

    /// <summary>
    /// The ID of the location associated with the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The ID of the associated <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogSubscriptionPlan">subscription plan</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan_id")]
    public string? PlanId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_override_money")]
    public Money? PriceOverrideMoney { get; init; }

    /// <summary>
    /// The start date of the subscription, in YYYY-MM-DD format (for example,
    /// 2013-01-15).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The current status of the subscription.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The tax amount applied when billing the subscription. The
    /// percentage is expressed in decimal form, using a <c>'.'</c> as the decimal
    /// separator and without a <c>'%'</c> sign. For example, a value of <c>7.5</c>
    /// corresponds to 7.5%.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_percentage")]
    public string? TaxPercentage { get; init; }

    /// <summary>
    /// Timezone that will be used in date calculations for the subscription.
    /// Defaults to the timezone of the location based on <c>location_id</c>.
    /// Format: the IANA Timezone Database identifier for the location timezone (for example, <c>America/Los_Angeles</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// The version of the object. When updating an object, the version
    /// supplied must match the version in the database, otherwise the write will
    /// be rejected as conflicting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }
}
