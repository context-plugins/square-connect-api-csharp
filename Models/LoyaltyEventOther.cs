using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>OTHER</c>.
/// </summary>
public record LoyaltyEventOther
{
    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonPropertyName("loyalty_program_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string LoyaltyProgramId { get; init; }

    /// <summary>
    /// The number of points added or removed.
    /// </summary>
    [JsonPropertyName("points")]
    public required int Points { get; init; }
}
