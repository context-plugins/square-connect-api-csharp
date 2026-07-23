using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Filter by the current order <c>state</c>.
/// </summary>
public record SearchOrdersStateFilter
{
    /// <summary>
    /// States to filter for.
    /// </summary>
    [JsonPropertyName("states")]
    public required IReadOnlyList<string> States { get; init; }
}
