using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record TerminalRefundQuerySort
{
    /// <summary>
    /// The order in which results are listed.
    /// - <c>ASC</c> - Oldest to newest.
    /// - <c>DESC</c> - Newest to oldest (default).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }
}
