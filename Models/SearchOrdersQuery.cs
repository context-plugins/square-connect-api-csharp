using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Contains query criteria for the search.
/// </summary>
public record SearchOrdersQuery
{
    /// <summary>
    /// Filtering criteria to use for a <c>SearchOrders</c> request. Multiple filters
    /// are ANDed together.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public SearchOrdersFilter? Filter { get; init; }

    /// <summary>
    /// Sorting criteria for a <c>SearchOrders</c> request. Results can only be sorted
    /// by a timestamp field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public SearchOrdersSort? Sort { get; init; }
}
