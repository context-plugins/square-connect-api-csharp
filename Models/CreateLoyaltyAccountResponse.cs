using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A response that includes loyalty account created.
/// </summary>
public record CreateLoyaltyAccountResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Describes a loyalty account. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/overview">Manage Loyalty Accounts Using the Loyalty API</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_account")]
    public LoyaltyAccount? LoyaltyAccount { get; init; }
}
