using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GiftCardActivityDeactivateReason>))]
public sealed record GiftCardActivityDeactivateReason : StringEnum<GiftCardActivityDeactivateReason>
{
    private GiftCardActivityDeactivateReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The seller suspects suspicious activity.
    /// </summary>
    public static readonly GiftCardActivityDeactivateReason SuspiciousActivity = new("SUSPICIOUS_ACTIVITY");

    /// <summary>
    /// The gift card deactivated for an unknown reason.
    /// </summary>
    public static readonly GiftCardActivityDeactivateReason UnknownReason = new("UNKNOWN_REASON");

    /// <summary>
    /// A chargeback on the gift card purchase (or the gift card load) was ruled in favor of the buyer.
    /// </summary>
    public static readonly GiftCardActivityDeactivateReason ChargebackDeactivate = new("CHARGEBACK_DEACTIVATE");

    public static GiftCardActivityDeactivateReason FromValue(string value) => FromValueCore(value);
}
