using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GiftCardActivityAdjustIncrementReason>))]
public sealed record GiftCardActivityAdjustIncrementReason : StringEnum<GiftCardActivityAdjustIncrementReason>
{
    private GiftCardActivityAdjustIncrementReason(string value) : base(value)
    {
    }

    /// <summary>
    /// Seller gifted a complimentary gift card balance increase.
    /// </summary>
    public static readonly GiftCardActivityAdjustIncrementReason Complimentary = new("COMPLIMENTARY");

    /// <summary>
    /// The seller increased the gift card balance
    /// to accommodate support issues.
    /// </summary>
    public static readonly GiftCardActivityAdjustIncrementReason SupportIssue = new("SUPPORT_ISSUE");

    /// <summary>
    /// The transaction is voided.
    /// </summary>
    public static readonly GiftCardActivityAdjustIncrementReason TransactionVoided = new("TRANSACTION_VOIDED");

    public static GiftCardActivityAdjustIncrementReason FromValue(string value) => FromValueCore(value);
}
