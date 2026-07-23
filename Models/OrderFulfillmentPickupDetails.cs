using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Contains details necessary to fulfill a pickup order.
/// </summary>
public record OrderFulfillmentPickupDetails
{
    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was accepted. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepted_at")]
    public string? AcceptedAt { get; init; }

    /// <summary>
    /// The duration of time after which an open and accepted pickup fulfillment
    /// is automatically moved to the <c>COMPLETED</c> state. The duration must be in RFC 3339
    /// format (for example, "P1W3D").
    /// <para>
    /// If not set, this pickup fulfillment remains accepted until it is canceled or completed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_complete_duration")]
    public string? AutoCompleteDuration { get; init; }

    /// <summary>
    /// A description of why the pickup was canceled. The maximum length: 100 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_reason")]
    [MaxLength(100)]
    public string? CancelReason { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was canceled. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("canceled_at")]
    public string? CanceledAt { get; init; }

    /// <summary>
    /// Specific details for curbside pickup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("curbside_pickup_details")]
    public OrderFulfillmentPickupDetailsCurbsidePickupDetails? CurbsidePickupDetails { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment expired. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expired_at")]
    public string? ExpiredAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when this fulfillment expires if it is not accepted. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z"). The expiration time can only be set up to 7 days in the future.
    /// If <c>expires_at</c> is not set, this pickup fulfillment is automatically accepted when
    /// placed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// If set to <c>true</c>, indicates that this pickup order is for curbside pickup, not in-store pickup.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_curbside_pickup")]
    public bool? IsCurbsidePickup { get; init; }

    /// <summary>
    /// A note meant to provide additional instructions about the pickup
    /// fulfillment displayed in the Square Point of Sale application and set by the API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(500)]
    public string? Note { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was picked up by the recipient. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("picked_up_at")]
    public string? PickedUpAt { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// that represents the start of the pickup window. Must be in RFC 3339 timestamp format, e.g.,
    /// "2016-09-04T23:59:33.123Z".
    /// <para>
    /// For fulfillments with the schedule type <c>ASAP</c>, this is automatically set
    /// to the current time plus the expected duration to prepare the fulfillment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pickup_at")]
    public string? PickupAt { get; init; }

    /// <summary>
    /// The window of time in which the order should be picked up after the <c>pickup_at</c> timestamp.
    /// Must be in RFC 3339 duration format, e.g., "P1W3D". Can be used as an
    /// informational guideline for merchants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pickup_window_duration")]
    public string? PickupWindowDuration { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was placed. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placed_at")]
    public string? PlacedAt { get; init; }

    /// <summary>
    /// The duration of time it takes to prepare this fulfillment.
    /// The duration must be in RFC 3339 format (for example, "P1W3D").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prep_time_duration")]
    public string? PrepTimeDuration { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment is marked as ready for pickup. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ready_at")]
    public string? ReadyAt { get; init; }

    /// <summary>
    /// Contains information about the recipient of a fulfillment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recipient")]
    public OrderFulfillmentRecipient? Recipient { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the fulfillment was rejected. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rejected_at")]
    public string? RejectedAt { get; init; }

    /// <summary>
    /// The schedule type of the pickup fulfillment. Defaults to <c>SCHEDULED</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schedule_type")]
    public string? ScheduleType { get; init; }
}
