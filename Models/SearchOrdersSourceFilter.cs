using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A filter based on order <c>source</c> information.
/// </summary>
public record SearchOrdersSourceFilter
{
    /// <summary>
    /// Filters by the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderSource">Source</see> <c>name</c>. The filter returns any orders
    /// with a <c>source.name</c> that matches any of the listed source names.
    /// <para>
    /// Max: 10 source names.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_names")]
    public IReadOnlyList<string>? SourceNames { get; init; }
}
