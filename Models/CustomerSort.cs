using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Specifies how searched customers profiles are sorted, including the sort key and sort order.
/// </summary>
public record CustomerSort
{
    /// <summary>
    /// Use one or more customer attributes as the sort key to sort searched customer profiles.
    /// For example, use the creation date (<c>created_at</c>) of customers or default attributes as the sort key.
    /// <para>
    ///
    /// Default: <c>DEFAULT</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    /// <summary>
    /// Indicates the order in which results should be sorted based on the
    /// sort field value. Strings use standard alphabetic comparison
    /// to determine order. Strings representing numbers are sorted as strings.
    /// <para>
    /// Default: <c>ASC</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }
}
