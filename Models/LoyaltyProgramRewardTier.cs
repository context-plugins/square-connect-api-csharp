using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a reward tier in a loyalty program. A reward tier defines how buyers can redeem points for a reward, such as the number of points required and the value and scope of the discount. A loyalty program can offer multiple reward tiers.
/// </summary>
public record LoyaltyProgramRewardTier
{
    /// <summary>
    /// The timestamp when the reward tier was created, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// Provides details about the reward tier discount. DEPRECATED at version 2020-12-16. Discount details
    /// are now defined using a catalog pricing rule and other catalog objects. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/overview#get-discount-details">Get discount details for the reward</see>.
    /// </summary>
    [JsonPropertyName("definition")]
    public required LoyaltyProgramRewardDefinition Definition { get; init; }

    /// <summary>
    /// The Square-assigned ID of the reward tier.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(36, MinimumLength = 1)]
    public required string Id { get; init; }

    /// <summary>
    /// The name of the reward tier.
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// The points exchanged for the reward tier.
    /// </summary>
    [JsonPropertyName("points")]
    [Minimum(1)]
    public required int Points { get; init; }

    /// <summary>
    /// A reference to a Catalog object at a specific version. In general this is
    /// used as an entry point into a graph of catalog objects, where the objects exist
    /// at a specific version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricing_rule_reference")]
    public CatalogObjectReference? PricingRuleReference { get; init; }
}
