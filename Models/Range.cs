using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The range of a number value between the specified lower and upper bounds.
/// </summary>
public record Range
{
    /// <summary>
    /// The upper bound of the number range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max")]
    public string? Max { get; init; }

    /// <summary>
    /// The lower bound of the number range.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("min")]
    public string? Min { get; init; }
}
