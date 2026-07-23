using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record DeviceCode
{
    /// <summary>
    /// The unique code that can be used to login.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// When this DeviceCode was created. Timestamp in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The unique id of the device that used this code. Populated when the device is paired up.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// The unique id for this device code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The location assigned to this code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [MaxLength(50)]
    public string? LocationId { get; init; }

    /// <summary>
    /// An optional user-defined name for the device code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(128)]
    public string? Name { get; init; }

    /// <summary>
    /// When this DeviceCode will expire and no longer login. Timestamp in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pair_by")]
    public string? PairBy { get; init; }

    /// <summary>
    /// When this DeviceCode was paired. Timestamp in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paired_at")]
    public string? PairedAt { get; init; }

    /// <summary>
    /// The targeting product type of the device code.
    /// </summary>
    [JsonPropertyName("product_type")]
    public required string ProductType { get; init; }

    /// <summary>
    /// The pairing status of the device code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// When this DeviceCode's status was last changed. Timestamp in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status_changed_at")]
    public string? StatusChangedAt { get; init; }
}
