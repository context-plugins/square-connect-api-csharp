using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record TerminalRefundQueryFilter
{
    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public TimeRange? CreatedAt { get; init; }

    /// <summary>
    /// <c>TerminalRefund</c> objects associated with a specific device. If no device is specified, then all
    /// <c>TerminalRefund</c> objects for the signed-in account are displayed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// Filtered results with the desired status of the <c>TerminalRefund</c>.
    /// Options: <c>PENDING</c>, <c>IN_PROGRESS</c>, <c>CANCEL_REQUESTED</c>, <c>CANCELED</c>, or <c>COMPLETED</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
