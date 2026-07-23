using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record DeviceCheckoutOptions
{
    /// <summary>
    /// The unique ID of the device intended for this <c>TerminalCheckout</c>.
    /// A list of <c>DeviceCode</c> objects can be retrieved from the /v2/devices/codes endpoint.
    /// Match a <c>DeviceCode.device_id</c> value with <c>device_id</c> to get the associated device code.
    /// </summary>
    [JsonPropertyName("device_id")]
    public required string DeviceId { get; init; }

    /// <summary>
    /// Instructs the device to skip the receipt screen. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skip_receipt_screen")]
    public bool? SkipReceiptScreen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip_settings")]
    public TipSettings? TipSettings { get; init; }
}
