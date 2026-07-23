using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a response from a retrieve request containing the specified <c>WageSetting</c> object or error messages.
/// </summary>
public record RetrieveWageSettingResponse
{
    /// <summary>
    /// The errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// An object representing a team member's wage information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("wage_setting")]
    public WageSetting? WageSetting { get; init; }
}
