using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record CreateDeviceCodeRequest
{
    [JsonPropertyName("device_code")]
    public required DeviceCode DeviceCode { get; init; }

    /// <summary>
    /// A unique string that identifies this CreateDeviceCode request. Keys can
    /// be any valid string but must be unique for every CreateDeviceCode request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
