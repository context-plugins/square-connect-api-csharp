using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record UpdateBookingRequest
{
    /// <summary>
    /// Represents a booking as a time-bound service contract for a seller's staff member to provide a specified service
    /// at a given location to a requesting customer in one or more appointment segments.
    /// </summary>
    [JsonPropertyName("booking")]
    public required Booking Booking { get; init; }

    /// <summary>
    /// A unique key to make this request an idempotent operation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(255)]
    public string? IdempotencyKey { get; init; }
}
