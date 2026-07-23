using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The type of discount the reward tier offers. DEPRECATED at version 2020-12-16. Discount details
/// are now defined using a catalog pricing rule and other catalog objects. For more information, see
/// <see href="https://developer.squareup.com/docs/loyalty-api/overview#get-discount-details">Get discount details for the reward</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramRewardDefinitionType>))]
public sealed record LoyaltyProgramRewardDefinitionType : StringEnum<LoyaltyProgramRewardDefinitionType>
{
    private LoyaltyProgramRewardDefinitionType(string value) : base(value)
    {
    }

    /// <summary>
    /// The fixed amount discounted.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionType FixedAmount = new("FIXED_AMOUNT");

    /// <summary>
    /// The fixed percentage discounted.
    /// </summary>
    public static readonly LoyaltyProgramRewardDefinitionType FixedPercentage = new("FIXED_PERCENTAGE");

    public static LoyaltyProgramRewardDefinitionType FromValue(string value) => FromValueCore(value);
}
