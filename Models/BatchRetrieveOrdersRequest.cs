using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in requests to the
/// <c>BatchRetrieveOrders</c> endpoint.
/// </summary>
public record BatchRetrieveOrdersRequest
{
    /// <summary>
    /// The ID of the location for these orders. This field is optional: omit it to retrieve
    /// orders within the scope of the current authorization's merchant ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The IDs of the orders to retrieve. A maximum of 100 orders can be retrieved per request.
    /// </summary>
    [JsonPropertyName("order_ids")]
    public required IReadOnlyList<string> OrderIds { get; init; }
}
