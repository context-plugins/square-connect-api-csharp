using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The parameters of a <c>Shift</c> search query, which includes filter and sort options.
/// </summary>
public record ShiftQuery
{
    /// <summary>
    /// Defines a filter used in a search for <c>Shift</c> records. <c>AND</c> logic is
    /// used by Square's servers to apply each filter property specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public ShiftFilter? Filter { get; init; }

    /// <summary>
    /// Sets the sort order of search results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public ShiftSort? Sort { get; init; }
}
