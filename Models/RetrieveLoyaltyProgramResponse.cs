using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that contains the loyalty program.
/// </summary>
public record RetrieveLoyaltyProgramResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a Square loyalty program. Loyalty programs define how buyers can earn points and redeem points for rewards.
    /// Square sellers can have only one loyalty program, which is created and managed from the Seller Dashboard.
    /// For more information, see <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Program Overview</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("program")]
    public LoyaltyProgram? Program { get; init; }
}
