using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Supported booking statuses.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BookingStatus>))]
public sealed record BookingStatus : StringEnum<BookingStatus>
{
    private BookingStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// An unaccepted booking. It is visible to both sellers and customers.
    /// </summary>
    public static readonly BookingStatus Pending = new("PENDING");

    /// <summary>
    /// A customer-cancelled booking. It is visible to both the seller and the customer.
    /// </summary>
    public static readonly BookingStatus CancelledByCustomer = new("CANCELLED_BY_CUSTOMER");

    /// <summary>
    /// A seller-cancelled booking. It is visible to both the seller and the customer.
    /// </summary>
    public static readonly BookingStatus CancelledBySeller = new("CANCELLED_BY_SELLER");

    /// <summary>
    /// A declined booking. It had once been pending, but was then declined by the seller.
    /// </summary>
    public static readonly BookingStatus Declined = new("DECLINED");

    /// <summary>
    /// An accepted booking agreed to or accepted by the seller.
    /// </summary>
    public static readonly BookingStatus Accepted = new("ACCEPTED");

    /// <summary>
    /// A no-show booking. The booking was accepted at one time, but have now been marked as a no-show by
    /// the seller because the client either missed the booking or cancelled it without enough notice.
    /// </summary>
    public static readonly BookingStatus NoShow = new("NO_SHOW");

    public static BookingStatus FromValue(string value) => FromValueCore(value);
}
