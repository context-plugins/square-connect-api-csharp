using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1OrderHistoryEntry
/// </summary>
public record V1OrderHistoryEntry
{
    /// <summary>
    /// The type of action performed on the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("action")]
    public string? Action { get; init; }

    /// <summary>
    /// The time when the action was performed, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
}
