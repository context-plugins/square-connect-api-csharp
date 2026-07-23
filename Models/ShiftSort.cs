using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Sets the sort order of search results.
/// </summary>
public record ShiftSort
{
    /// <summary>
    /// The field to sort on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    /// <summary>
    /// The order in which results are returned. Defaults to DESC.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }
}
