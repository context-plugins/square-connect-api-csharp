using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record TerminalCheckoutQueryFilter
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
    /// The <c>TerminalCheckout</c> objects associated with a specific device. If no device is specified, then all
    /// <c>TerminalCheckout</c> objects for the merchant are displayed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// Filtered results with the desired status of the <c>TerminalCheckout</c>.
    /// Options: PENDING, IN_PROGRESS, CANCELED, COMPLETED
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
