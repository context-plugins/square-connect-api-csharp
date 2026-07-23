using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to update a <c>WorkweekConfig</c> object.
/// </summary>
public record UpdateWorkweekConfigRequest
{
    /// <summary>
    /// Sets the day of the week and hour of the day that a business starts a
    /// workweek. This is used to calculate overtime pay.
    /// </summary>
    [JsonPropertyName("workweek_config")]
    public required WorkweekConfig WorkweekConfig { get; init; }
}
