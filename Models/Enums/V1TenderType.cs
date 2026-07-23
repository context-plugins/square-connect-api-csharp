using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1TenderType>))]
public sealed record V1TenderType : StringEnum<V1TenderType>
{
    private V1TenderType(string value) : base(value)
    {
    }

    public static readonly V1TenderType CreditCard = new("CREDIT_CARD");

    public static readonly V1TenderType Cash = new("CASH");

    public static readonly V1TenderType ThirdPartyCard = new("THIRD_PARTY_CARD");

    public static readonly V1TenderType NoSale = new("NO_SALE");

    public static readonly V1TenderType SquareWallet = new("SQUARE_WALLET");

    public static readonly V1TenderType SquareGiftCard = new("SQUARE_GIFT_CARD");

    public static readonly V1TenderType Unknown = new("UNKNOWN");

    public static readonly V1TenderType Other = new("OTHER");

    public static V1TenderType FromValue(string value) => FromValueCore(value);
}
