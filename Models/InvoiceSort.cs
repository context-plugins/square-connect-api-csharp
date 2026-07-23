using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Identifies the sort field and sort order.
/// </summary>
public record InvoiceSort
{
    /// <summary>
    /// The field to use for sorting.
    /// </summary>
    [JsonPropertyName("field")]
    public required string Field { get; init; }

    /// <summary>
    /// The order to use for sorting the results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }
}
