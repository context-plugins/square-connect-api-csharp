using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A filter to select resources based on an exact field value. For any given
/// value, the value can only be in one property. Depending on the field, either
/// all properties can be set or only a subset will be available.
/// <para>
/// Refer to the documentation of the field.
/// </para>
/// </summary>
public record FilterValue
{
    /// <summary>
    /// A list of terms that must be present on the field of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("all")]
    public IReadOnlyList<string>? All { get; init; }

    /// <summary>
    /// A list of terms where at least one of them must be present on the
    /// field of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("any")]
    public IReadOnlyList<string>? Any { get; init; }

    /// <summary>
    /// A list of terms that must not be present on the field the resource
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("none")]
    public IReadOnlyList<string>? None { get; init; }
}
