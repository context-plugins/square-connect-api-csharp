using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Contains the details necessary to fulfill a shipment order.
/// </summary>
public record OrderFulfillmentShipmentDetails
{
    /// <summary>
    /// A description of why the shipment was canceled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_reason")]
    [MaxLength(100)]
    public string? CancelReason { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating the shipment was canceled.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_at")]
    public string? CanceledAt { get; init; }

    /// <summary>
    /// The shipping carrier being used to ship this fulfillment (such as UPS, FedEx, or USPS).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carrier")]
    [MaxLength(50)]
    public string? Carrier { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the shipment is expected to be delivered to the shipping carrier.
    /// The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expected_shipped_at")]
    public string? ExpectedShippedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the shipment failed to be completed. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failed_at")]
    public string? FailedAt { get; init; }

    /// <summary>
    /// A description of why the shipment failed to be completed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_reason")]
    [MaxLength(100)]
    public string? FailureReason { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when this fulfillment was moved to the <c>RESERVED</c> state, which  indicates that preparation
    /// of this shipment has begun. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("in_progress_at")]
    public string? InProgressAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when this fulfillment was moved to the <c>PREPARED</c> state, which indicates that the
    /// fulfillment is packaged. The timestamp must be in RFC 3339 format (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("packaged_at")]
    public string? PackagedAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the shipment was requested. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placed_at")]
    public string? PlacedAt { get; init; }

    /// <summary>
    /// Contains information about the recipient of a fulfillment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public OrderFulfillmentRecipient? Recipient { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when this fulfillment was moved to the <c>COMPLETED</c> state, which indicates that
    /// the fulfillment has been given to the shipping carrier. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipped_at")]
    public string? ShippedAt { get; init; }

    /// <summary>
    /// A note with additional information for the shipping carrier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping_note")]
    [MaxLength(500)]
    public string? ShippingNote { get; init; }

    /// <summary>
    /// A description of the type of shipping product purchased from the carrier
    /// (such as First Class, Priority, or Express).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping_type")]
    [MaxLength(50)]
    public string? ShippingType { get; init; }

    /// <summary>
    /// The reference number provided by the carrier to track the shipment's progress.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tracking_number")]
    [MaxLength(100)]
    public string? TrackingNumber { get; init; }

    /// <summary>
    /// A link to the tracking webpage on the carrier's website.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tracking_url")]
    [MaxLength(2000)]
    public string? TrackingUrl { get; init; }
}
