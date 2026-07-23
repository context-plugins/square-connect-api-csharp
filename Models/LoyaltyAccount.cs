using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a loyalty account. For more information, see
/// <see href="https://developer.squareup.com/docs/loyalty-api/overview">Manage Loyalty Accounts Using the Loyalty API</see>.
/// </summary>
public record LoyaltyAccount
{
    /// <summary>
    /// The available point balance in the loyalty account. If points are scheduled to expire, they are listed in the <c>expiring_point_deadlines</c> field.
    /// <para>
    /// Your application should be able to handle loyalty accounts that have a negative point balance (<c>balance</c> is less than 0). This might occur if a seller makes a manual adjustment or as a result of a refund or exchange.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance")]
    public int? Balance { get; init; }

    /// <summary>
    /// The timestamp when the loyalty account was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Customer">customer</see> that is associated with the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The timestamp when enrollment occurred, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enrolled_at")]
    public string? EnrolledAt { get; init; }

    /// <summary>
    /// The schedule for when points expire in the loyalty account balance. This field is present only if the account has points that are scheduled to expire.
    /// <para>
    /// The total number of points in this field equals the number of points in the <c>balance</c> field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiring_point_deadlines")]
    public IReadOnlyList<LoyaltyAccountExpiringPointDeadline>? ExpiringPointDeadlines { get; init; }

    /// <summary>
    /// The Square-assigned ID of the loyalty account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(36)]
    public string? Id { get; init; }

    /// <summary>
    /// The total points accrued during the lifetime of the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lifetime_points")]
    [Minimum(0)]
    public int? LifetimePoints { get; init; }

    /// <summary>
    /// Represents the mapping that associates a loyalty account with a buyer.
    /// <para>
    /// Currently, a loyalty account can only be mapped to a buyer by phone number. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty/overview">Loyalty Overview</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mapping")]
    public LoyaltyAccountMapping? Mapping { get; init; }

    /// <summary>
    /// The Square-assigned ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/LoyaltyProgram">loyalty program</see> to which the account belongs.
    /// </summary>
    [JsonPropertyName("program_id")]
    [StringLength(36, MinimumLength = 1)]
    public required string ProgramId { get; init; }

    /// <summary>
    /// The timestamp when the loyalty account was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
