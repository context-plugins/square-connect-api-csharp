using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes when the loyalty program expires.
/// </summary>
public record LoyaltyProgramExpirationPolicy
{
    /// <summary>
    /// The number of months before points expire, in <c>P[n]M</c> RFC 3339 duration format. For example, a value of <c>P12M</c> represents a duration of 12 months.
    /// Points are valid through the last day of the month in which they are scheduled to expire. For example, with a  <c>P12M</c> duration, points earned on July 6, 2020 expire on August 1, 2021.
    /// </summary>
    [JsonPropertyName("expiration_duration")]
    [MinLength(1)]
    public required string ExpirationDuration { get; init; }
}
