using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The types of events on a CashDrawerShift.
/// Each event type represents an employee action on the actual cash drawer
/// represented by a CashDrawerShift.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashDrawerEventType>))]
public sealed record CashDrawerEventType : StringEnum<CashDrawerEventType>
{
    private CashDrawerEventType(string value) : base(value)
    {
    }

    /// <summary>
    /// Triggered when a no sale occurs on a cash drawer.
    /// A CashDrawerEvent of this type must have a zero money amount.
    /// </summary>
    public static readonly CashDrawerEventType NoSale = new("NO_SALE");

    /// <summary>
    /// Triggered when a cash tender payment occurs on a cash drawer.
    /// A CashDrawerEvent of this type can must not have a negative amount.
    /// </summary>
    public static readonly CashDrawerEventType CashTenderPayment = new("CASH_TENDER_PAYMENT");

    /// <summary>
    /// Triggered when a check, gift card, or other non-cash payment occurs
    /// on a cash drawer.
    /// A CashDrawerEvent of this type must have a zero money amount.
    /// </summary>
    public static readonly CashDrawerEventType OtherTenderPayment = new("OTHER_TENDER_PAYMENT");

    /// <summary>
    /// Triggered when a split tender bill is cancelled after cash has been
    /// tendered.
    /// A CASH_TENDER_CANCELLED_PAYMENT should have a corresponding CASH_TENDER_PAYMENT.
    /// A CashDrawerEvent of this type must not have a negative amount.
    /// </summary>
    public static readonly CashDrawerEventType CashTenderCancelledPayment = new("CASH_TENDER_CANCELLED_PAYMENT");

    /// <summary>
    /// Triggered when a split tender bill is cancelled after a non-cash tender
    /// has been tendered. An OTHER_TENDER_CANCELLED_PAYMENT should have a corresponding
    /// OTHER_TENDER_PAYMENT. A CashDrawerEvent of this type must have a zero money
    /// amount.
    /// </summary>
    public static readonly CashDrawerEventType OtherTenderCancelledPayment = new("OTHER_TENDER_CANCELLED_PAYMENT");

    /// <summary>
    /// Triggered when a cash tender refund occurs.
    /// A CashDrawerEvent of this type must not have a negative amount.
    /// </summary>
    public static readonly CashDrawerEventType CashTenderRefund = new("CASH_TENDER_REFUND");

    /// <summary>
    /// Triggered when an other tender refund occurs.
    /// A CashDrawerEvent of this type must have a zero money amount.
    /// </summary>
    public static readonly CashDrawerEventType OtherTenderRefund = new("OTHER_TENDER_REFUND");

    /// <summary>
    /// Triggered when money unrelated to a payment is added to the cash drawer.
    /// For example, an employee adds coins to the drawer.
    /// A CashDrawerEvent of this type must not have a negative amount.
    /// </summary>
    public static readonly CashDrawerEventType PaidIn = new("PAID_IN");

    /// <summary>
    /// Triggered when money is removed from the drawer for other reasons
    /// than making change.
    /// For example, an employee pays a delivery person with cash from the cash drawer.
    /// A CashDrawerEvent of this type must not have a negative amount.
    /// </summary>
    public static readonly CashDrawerEventType PaidOut = new("PAID_OUT");

    public static CashDrawerEventType FromValue(string value) => FromValueCore(value);
}
