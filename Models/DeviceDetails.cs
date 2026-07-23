using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Details about the device that took the payment.
/// </summary>
public record DeviceDetails
{
    /// <summary>
    /// The Square-issued ID of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_id")]
    [MaxLength(255)]
    public string? DeviceId { get; init; }

    /// <summary>
    /// The Square-issued installation ID for the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_installation_id")]
    [MaxLength(255)]
    public string? DeviceInstallationId { get; init; }

    /// <summary>
    /// The name of the device set by the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_name")]
    [MaxLength(255)]
    public string? DeviceName { get; init; }
}
