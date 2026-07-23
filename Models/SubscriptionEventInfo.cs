using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides information about the subscription event.
/// </summary>
public record SubscriptionEventInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public object? Code { get; init; }

    /// <summary>
    /// A human-readable explanation for the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detail")]
    public string? Detail { get; init; }
}
