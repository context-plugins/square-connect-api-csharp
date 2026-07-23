using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The type of the loyalty event.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyEventType>))]
public sealed record LoyaltyEventType : StringEnum<LoyaltyEventType>
{
    private LoyaltyEventType(string value) : base(value)
    {
    }

    /// <summary>
    /// Points are added to a loyalty account for a purchase.
    /// </summary>
    public static readonly LoyaltyEventType AccumulatePoints = new("ACCUMULATE_POINTS");

    /// <summary>
    /// A loyalty reward is created. For more information, see
    /// <see href="https://developer.squareup.com/docs/loyalty-api/overview/#loyalty-overview-loyalty-rewards">Loyalty rewards</see>.
    /// </summary>
    public static readonly LoyaltyEventType CreateReward = new("CREATE_REWARD");

    /// <summary>
    /// A loyalty reward is redeemed.
    /// </summary>
    public static readonly LoyaltyEventType RedeemReward = new("REDEEM_REWARD");

    /// <summary>
    /// A loyalty reward is deleted.
    /// </summary>
    public static readonly LoyaltyEventType DeleteReward = new("DELETE_REWARD");

    /// <summary>
    /// Loyalty points are manually adjusted.
    /// </summary>
    public static readonly LoyaltyEventType AdjustPoints = new("ADJUST_POINTS");

    /// <summary>
    /// Loyalty points are expired according to the
    /// expiration policy of the loyalty program.
    /// </summary>
    public static readonly LoyaltyEventType ExpirePoints = new("EXPIRE_POINTS");

    /// <summary>
    /// Some other loyalty event occurred.
    /// </summary>
    public static readonly LoyaltyEventType Other = new("OTHER");

    public static LoyaltyEventType FromValue(string value) => FromValueCore(value);
}
