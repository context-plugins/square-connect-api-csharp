using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a query (including filtering criteria) used to search for subscriptions.
/// </summary>
public record SearchSubscriptionsQuery
{
    /// <summary>
    /// Represents a set of SearchSubscriptionsQuery filters used to limit the set of Subscriptions returned by SearchSubscriptions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public SearchSubscriptionsFilter? Filter { get; init; }
}
