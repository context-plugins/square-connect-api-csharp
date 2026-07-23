using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The creation source filter.
/// <para>
/// If one or more creation sources are set, customer profiles are included in,
/// or excluded from, the result if they match at least one of the filter criteria.
/// </para>
/// </summary>
public record CustomerCreationSourceFilter
{
    /// <summary>
    /// Indicates whether a customer profile matching the filter criteria
    /// should be included in the result or excluded from the result.
    /// <para>
    /// Default: <c>INCLUDE</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rule")]
    public string? Rule { get; init; }

    /// <summary>
    /// The list of creation sources used as filtering criteria.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<string>? Values { get; init; }
}
