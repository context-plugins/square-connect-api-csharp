using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RetrieveInventoryPhysicalCountResponse
{
    /// <summary>
    /// Represents the quantity of an item variation that is physically present
    /// at a specific location, verified by a seller or a seller's employee. For example,
    /// a physical count might come from an employee counting the item variations on
    /// hand or from syncing with an external system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public InventoryPhysicalCount? Count { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
