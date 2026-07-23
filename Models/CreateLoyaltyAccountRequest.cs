using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to create a new loyalty account.
/// </summary>
public record CreateLoyaltyAccountRequest
{
    /// <summary>
    /// A unique string that identifies this <c>CreateLoyaltyAccount</c> request.
    /// Keys can be any valid string, but must be unique for every request.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Describes a loyalty account. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/overview">Manage Loyalty Accounts Using the Loyalty API</see>.
    /// </summary>
    [JsonPropertyName("loyalty_account")]
    public required LoyaltyAccount LoyaltyAccount { get; init; }
}
