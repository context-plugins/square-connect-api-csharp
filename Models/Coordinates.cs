using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Latitude and longitude coordinates.
/// </summary>
public record Coordinates
{
    /// <summary>
    /// The latitude of the coordinate expressed in degrees.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("latitude")]
    public double? Latitude { get; init; }

    /// <summary>
    /// The longitude of the coordinate expressed in degrees.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("longitude")]
    public double? Longitude { get; init; }
}
