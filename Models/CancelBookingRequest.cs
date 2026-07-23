using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

public record CancelBookingRequest
{
    /// <summary>
    /// The revision number for the booking used for optimistic concurrency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("booking_version")]
    [Minimum(0)]
    public int? BookingVersion { get; init; }

    /// <summary>
    /// A unique key to make this request an idempotent operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(255)]
    public string? IdempotencyKey { get; init; }
}
