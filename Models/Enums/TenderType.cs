using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates a tender's type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderType>))]
public sealed record TenderType : StringEnum<TenderType>
{
    private TenderType(string value) : base(value)
    {
    }

    /// <summary>
    /// A credit card.
    /// </summary>
    public static readonly TenderType Card = new("CARD");

    /// <summary>
    /// Cash.
    /// </summary>
    public static readonly TenderType Cash = new("CASH");

    /// <summary>
    /// A credit card processed with a card processor other than Square.
    /// <para>
    /// This value applies only to merchants in countries where Square does not
    /// yet provide card processing.
    /// </para>
    /// </summary>
    public static readonly TenderType ThirdPartyCard = new("THIRD_PARTY_CARD");

    /// <summary>
    /// A Square gift card.
    /// </summary>
    public static readonly TenderType SquareGiftCard = new("SQUARE_GIFT_CARD");

    /// <summary>
    /// This tender represents the register being opened for a "no sale" event.
    /// </summary>
    public static readonly TenderType NoSale = new("NO_SALE");

    /// <summary>
    /// A payment from a digital wallet, e.g. Cash App.
    /// <para>
    /// Note: Some "digital wallets", including Google Pay and Apple Pay, facilitate
    /// card payments.  Those payments have the <c>CARD</c> type.
    /// </para>
    /// </summary>
    public static readonly TenderType Wallet = new("WALLET");

    /// <summary>
    /// A form of tender that does not match any other value.
    /// </summary>
    public static readonly TenderType Other = new("OTHER");

    public static TenderType FromValue(string value) => FromValueCore(value);
}
