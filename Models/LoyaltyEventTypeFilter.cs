using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Filter events by event type.
/// </summary>
public record LoyaltyEventTypeFilter
{
    /// <summary>
    /// The loyalty event types used to filter the result.
    /// If multiple values are specified, the endpoint uses a
    /// logical OR to combine them.
    /// </summary>
    [JsonPropertyName("types")]
    public required IReadOnlyList<string> Types { get; init; }
}
