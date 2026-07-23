using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the mapping that associates a loyalty account with a buyer.
/// <para>
/// Currently, a loyalty account can only be mapped to a buyer by phone number. For more information, see
/// <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Overview</see>.
/// </para>
/// </summary>
public record LoyaltyAccountMapping
{
    /// <summary>
    /// The timestamp when the mapping was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The Square-assigned ID of the mapping.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(36)]
    public string? Id { get; init; }

    /// <summary>
    /// The phone number of the buyer, in E.164 format. For example, "+14155551111".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }
}
