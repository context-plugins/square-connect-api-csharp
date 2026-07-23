using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record TerminalRefund
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

    /// <summary>
    /// The ID of the application that created the refund.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_id")]
    public string? AppId { get; init; }

    /// <summary>
    /// Present if the status is <c>CANCELED</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_reason")]
    public string? CancelReason { get; init; }

    /// <summary>
    /// The time when the <c>TerminalRefund</c> was created, as an RFC 3339 timestamp.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The RFC 3339 duration, after which the refund is automatically canceled.
    /// A <c>TerminalRefund</c> that is <c>PENDING</c> is automatically <c>CANCELED</c> and has a cancellation reason
    /// of <c>TIMED_OUT</c>.
    /// <para>
    /// Default: 5 minutes from creation.
    /// </para>
    /// <para>
    /// Maximum: 5 minutes
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deadline_duration")]
    public string? DeadlineDuration { get; init; }

    /// <summary>
    /// The unique ID of the device intended for this <c>TerminalRefund</c>.
    /// The Id can be retrieved from /v2/devices api.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// A unique ID for this <c>TerminalRefund</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [StringLength(255, MinimumLength = 10)]
    public string? Id { get; init; }

    /// <summary>
    /// The location of the device where the <c>TerminalRefund</c> was directed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The reference to the Square order ID for the payment identified by the <c>payment_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// The unique ID of the payment being refunded.
    /// </summary>
    [JsonPropertyName("payment_id")]
    [MinLength(1)]
    public required string PaymentId { get; init; }

    /// <summary>
    /// A description of the reason for the refund.
    /// Note: maximum 192 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(192)]
    public string? Reason { get; init; }

    /// <summary>
    /// The reference to the payment refund created by completing this <c>TerminalRefund</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_id")]
    public string? RefundId { get; init; }

    /// <summary>
    /// The status of the <c>TerminalRefund</c>.
    /// Options: <c>PENDING</c>, <c>IN_PROGRESS</c>, <c>CANCELED</c>, or <c>COMPLETED</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The time when the <c>TerminalRefund</c> was last updated, as an RFC 3339 timestamp.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
