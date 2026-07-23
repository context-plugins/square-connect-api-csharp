using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The timeline for card payments.
/// </summary>
public record CardPaymentTimeline
{
    /// <summary>
    /// The timestamp when the payment was authorized, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorized_at")]
    public string? AuthorizedAt { get; init; }

    /// <summary>
    /// The timestamp when the payment was captured, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captured_at")]
    public string? CapturedAt { get; init; }

    /// <summary>
    /// The timestamp when the payment was voided, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("voided_at")]
    public string? VoidedAt { get; init; }
}
