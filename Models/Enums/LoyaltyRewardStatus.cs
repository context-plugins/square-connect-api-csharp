using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The status of the loyalty reward.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyRewardStatus>))]
public sealed record LoyaltyRewardStatus : StringEnum<LoyaltyRewardStatus>
{
    private LoyaltyRewardStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The reward is issued.
    /// </summary>
    public static readonly LoyaltyRewardStatus Issued = new("ISSUED");

    /// <summary>
    /// The reward is redeemed.
    /// </summary>
    public static readonly LoyaltyRewardStatus Redeemed = new("REDEEMED");

    /// <summary>
    /// The reward is deleted.
    /// </summary>
    public static readonly LoyaltyRewardStatus Deleted = new("DELETED");

    public static LoyaltyRewardStatus FromValue(string value) => FromValueCore(value);
}
