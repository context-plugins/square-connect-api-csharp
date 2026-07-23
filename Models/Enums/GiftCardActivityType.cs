using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GiftCardActivityType>))]
public sealed record GiftCardActivityType : StringEnum<GiftCardActivityType>
{
    private GiftCardActivityType(string value) : base(value)
    {
    }

    /// <summary>
    /// Activated a gift card with a balance.
    /// </summary>
    public static readonly GiftCardActivityType Activate = new("ACTIVATE");

    /// <summary>
    /// Loaded a gift card with additional funds.
    /// </summary>
    public static readonly GiftCardActivityType Load = new("LOAD");

    /// <summary>
    /// Redeemed a gift card.
    /// </summary>
    public static readonly GiftCardActivityType Redeem = new("REDEEM");

    /// <summary>
    /// Cleared a gift card balance to zero.
    /// </summary>
    public static readonly GiftCardActivityType ClearBalance = new("CLEAR_BALANCE");

    /// <summary>
    /// Permanently blocked a gift card from a balance-changing
    /// activity.
    /// </summary>
    public static readonly GiftCardActivityType Deactivate = new("DEACTIVATE");

    /// <summary>
    /// Manually increased a gift card balance.
    /// </summary>
    public static readonly GiftCardActivityType AdjustIncrement = new("ADJUST_INCREMENT");

    /// <summary>
    /// Manually decreased a gift card balance.
    /// </summary>
    public static readonly GiftCardActivityType AdjustDecrement = new("ADJUST_DECREMENT");

    /// <summary>
    /// Added money to a gift card because a transaction
    /// paid with this gift card was refunded.
    /// </summary>
    public static readonly GiftCardActivityType Refund = new("REFUND");

    /// <summary>
    /// Added money to a gift card because a transaction
    /// not linked to this gift card was refunded
    /// to this gift card.
    /// </summary>
    public static readonly GiftCardActivityType UnlinkedActivityRefund = new("UNLINKED_ACTIVITY_REFUND");

    /// <summary>
    /// Imported a third-party gift card.
    /// </summary>
    public static readonly GiftCardActivityType Import = new("IMPORT");

    /// <summary>
    /// Temporarily blocked a gift card from balance-changing
    /// activities.
    /// </summary>
    public static readonly GiftCardActivityType Block = new("BLOCK");

    /// <summary>
    /// Unblocked a gift card. It can resume balance-changing activities.
    /// </summary>
    public static readonly GiftCardActivityType Unblock = new("UNBLOCK");

    /// <summary>
    /// A third-party gift card was imported with a balance.
    /// The import is reversed.
    /// </summary>
    public static readonly GiftCardActivityType ImportReversal = new("IMPORT_REVERSAL");

    public static GiftCardActivityType FromValue(string value) => FromValueCore(value);
}
