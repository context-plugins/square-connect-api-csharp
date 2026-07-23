using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes query filters to apply.
/// </summary>
public record InvoiceFilter
{
    /// <summary>
    /// Limits the search to the specified customers, within the specified locations.
    /// Specifying a customer is optional. In the current implementation,
    /// a maximum of one customer can be specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_ids")]
    public IReadOnlyList<string>? CustomerIds { get; init; }

    /// <summary>
    /// Limits the search to the specified locations. A location is required.
    /// In the current implementation, only one location can be specified.
    /// </summary>
    [JsonPropertyName("location_ids")]
    public required IReadOnlyList<string> LocationIds { get; init; }
}
