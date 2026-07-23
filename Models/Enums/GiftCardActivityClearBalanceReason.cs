using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GiftCardActivityClearBalanceReason>))]
public sealed record GiftCardActivityClearBalanceReason : StringEnum<GiftCardActivityClearBalanceReason>
{
    private GiftCardActivityClearBalanceReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The seller suspects suspicious activity.
    /// </summary>
    public static readonly GiftCardActivityClearBalanceReason SuspiciousActivity = new("SUSPICIOUS_ACTIVITY");

    /// <summary>
    /// The seller cleared the balance to reuse the gift card.
    /// </summary>
    public static readonly GiftCardActivityClearBalanceReason ReuseGiftcard = new("REUSE_GIFTCARD");

    /// <summary>
    /// The gift card balance was cleared for an unknown reason.
    /// </summary>
    public static readonly GiftCardActivityClearBalanceReason UnknownReason = new("UNKNOWN_REASON");

    public static GiftCardActivityClearBalanceReason FromValue(string value) => FromValueCore(value);
}
