using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GiftCardActivityAdjustDecrementReason>))]
public sealed record GiftCardActivityAdjustDecrementReason : StringEnum<GiftCardActivityAdjustDecrementReason>
{
    private GiftCardActivityAdjustDecrementReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The seller determined suspicious activity by the buyer.
    /// </summary>
    public static readonly GiftCardActivityAdjustDecrementReason SuspiciousActivity = new("SUSPICIOUS_ACTIVITY");

    /// <summary>
    /// The seller previously increased the gift card balance by accident.
    /// </summary>
    public static readonly GiftCardActivityAdjustDecrementReason BalanceAccidentallyIncreased = new("BALANCE_ACCIDENTALLY_INCREASED");

    /// <summary>
    /// The seller decreased the gift card balance to
    /// accommodate support issues.
    /// </summary>
    public static readonly GiftCardActivityAdjustDecrementReason SupportIssue = new("SUPPORT_ISSUE");

    public static GiftCardActivityAdjustDecrementReason FromValue(string value) => FromValueCore(value);
}
