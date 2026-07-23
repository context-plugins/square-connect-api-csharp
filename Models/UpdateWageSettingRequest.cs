using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an update request for the <c>WageSetting</c> object describing a <c>TeamMember</c>.
/// </summary>
public record UpdateWageSettingRequest
{
    /// <summary>
    /// An object representing a team member's wage information.
    /// </summary>
    [JsonPropertyName("wage_setting")]
    public required WageSetting WageSetting { get; init; }
}
