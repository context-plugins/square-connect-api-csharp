using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides metadata when the event <c>type</c> is <c>ACCUMULATE_POINTS</c>.
/// </summary>
public record LoyaltyEventAccumulatePoints
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgram">loyalty program</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loyalty_program_id")]
    [MaxLength(36)]
    public string? LoyaltyProgramId { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> for which the buyer accumulated the points.
    /// This field is returned only if the Orders API is used to process orders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// The number of points accumulated by the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("points")]
    [Minimum(1)]
    public int? Points { get; init; }
}
