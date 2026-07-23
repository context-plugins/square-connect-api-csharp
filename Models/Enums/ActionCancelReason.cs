using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ActionCancelReason>))]
public sealed record ActionCancelReason : StringEnum<ActionCancelReason>
{
    private ActionCancelReason(string value) : base(value)
    {
    }

    /// <summary>
    /// A person canceled the <c>TerminalCheckout</c> from a Square device.
    /// </summary>
    public static readonly ActionCancelReason BuyerCanceled = new("BUYER_CANCELED");

    /// <summary>
    /// A client canceled the <c>TerminalCheckout</c> using the API.
    /// </summary>
    public static readonly ActionCancelReason SellerCanceled = new("SELLER_CANCELED");

    /// <summary>
    /// The <c>TerminalCheckout</c> timed out (see <c>deadline_duration</c> on the <c>TerminalCheckout</c>).
    /// </summary>
    public static readonly ActionCancelReason TimedOut = new("TIMED_OUT");

    public static ActionCancelReason FromValue(string value) => FromValueCore(value);
}
