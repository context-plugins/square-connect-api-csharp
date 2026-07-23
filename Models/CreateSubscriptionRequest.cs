using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines parameters in a
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/subscriptions-api/create-subscription">CreateSubscription</see> endpoint request.
/// </summary>
public record CreateSubscriptionRequest
{
    /// <summary>
    /// The date when the subscription should be canceled, in
    /// YYYY-MM-DD format (for example, 2025-02-29). This overrides the plan configuration
    /// if it comes before the date the subscription would otherwise end.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_date")]
    public string? CanceledDate { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Customer">customer</see> <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Card">card</see> to charge.
    /// If not specified, Square sends an invoice via email. For an example to
    /// create a customer and add a card on file, see <see href="https://developer.squareup.com/docs/subscriptions-api/walkthrough">Subscriptions Walkthrough</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_id")]
    public string? CardId { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Customer">customer</see> profile.
    /// </summary>
    [JsonPropertyName("customer_id")]
    [MinLength(1)]
    public required string CustomerId { get; init; }

    /// <summary>
    /// A unique string that identifies this <c>CreateSubscription</c> request.
    /// If you do not provide a unique string (or provide an empty string as the value),
    /// the endpoint treats each request as independent.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency keys</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// The ID of the location the subscription is associated with.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// The ID of the subscription plan created using the Catalog API.
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/setup-plan">Set Up and Manage a Subscription Plan</see> and
    /// <see href="https://developer.squareup.com/docs/subscriptions-api/walkthrough">Subscriptions Walkthrough</see>.
    /// </summary>
    [JsonPropertyName("plan_id")]
    [MinLength(1)]
    public required string PlanId { get; init; }

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
    /// The start date of the subscription, in YYYY-MM-DD format. For example,
    /// 2013-01-15. If the start date is left empty, the subscription begins
    /// immediately.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The tax to add when billing the subscription.
    /// The percentage is expressed in decimal form, using a <c>'.'</c> as the decimal
    /// separator and without a <c>'%'</c> sign. For example, a value of 7.5
    /// corresponds to 7.5%.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_percentage")]
    [MaxLength(10)]
    public string? TaxPercentage { get; init; }

    /// <summary>
    /// The timezone that is used in date calculations for the subscription. If unset, defaults to
    /// the location timezone. If a timezone is not configured for the location, defaults to "America/New_York".
    /// Format: the IANA Timezone Database identifier for the location timezone. For
    /// a list of time zones, see <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">List of tz database time zones</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }
}
