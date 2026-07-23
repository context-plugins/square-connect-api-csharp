using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the origination details of an order.
/// </summary>
public record OrderSource
{
    /// <summary>
    /// The name used to identify the place (physical or digital) that an order originates.
    /// If unset, the name defaults to the name of the application that created the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
