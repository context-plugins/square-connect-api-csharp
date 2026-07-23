using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

public record CatalogCustomAttributeDefinitionNumberConfig
{
    /// <summary>
    /// An integer between 0 and 5 that represents the maximum number of
    /// positions allowed after the decimal in number custom attribute values
    /// For example:
    /// <list type="bullet">
    ///   <item><description>if the precision is 0, the quantity can be 1, 2, 3, etc.</description></item>
    ///   <item><description>if the precision is 1, the quantity can be 0.1, 0.2, etc.</description></item>
    ///   <item><description>if the precision is 2, the quantity can be 0.01, 0.12, etc.</description></item>
    /// </list>
    /// <para>
    /// Default: 5
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("precision")]
    [Minimum(0)]
    [Maximum(5)]
    public int? Precision { get; init; }
}
