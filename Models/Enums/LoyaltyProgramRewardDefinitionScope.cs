using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the scope of the reward tier. DEPRECATED at version 2020-12-16. Discount details
/// are now defined using a catalog pricing rule and other catalog objects. For more information, see
/// <see href="https://developer.squareup.com/docs/loyalty-api/overview#get-discount-details">Get discount details for the reward</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramRewardDefinitionScope>))]
public sealed record LoyaltyProgramRewardDefinitionScope : StringEnum<LoyaltyProgramRewardDefinitionScope>
{
    private LoyaltyProgramRewardDefinitionScope(string value) : base(value)
    {
    }

    /// <summary>
    /// The discount applies to the entire order.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionScope Order = new("ORDER");

    /// <summary>
    /// The discount applies only to specific item variations.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionScope ItemVariation = new("ITEM_VARIATION");

    /// <summary>
    /// The discount applies only to items in the given categories.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionScope Category = new("CATEGORY");

    public static LoyaltyProgramRewardDefinitionScope FromValue(string value) => FromValueCore(value);
}
