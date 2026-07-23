using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that contains all loyalty programs.
/// </summary>
public record ListLoyaltyProgramsResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A list of <c>LoyaltyProgram</c> for the merchant.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("programs")]
    public IReadOnlyList<LoyaltyProgram>? Programs { get; init; }
}
