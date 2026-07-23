using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates a card's brand, such as <c>VISA</c> or <c>MASTERCARD</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardBrand>))]
public sealed record CardBrand : StringEnum<CardBrand>
{
    private CardBrand(string value) : base(value)
    {
    }

    public static readonly CardBrand OtherBrand = new("OTHER_BRAND");

    public static readonly CardBrand Visa = new("VISA");

    public static readonly CardBrand Mastercard = new("MASTERCARD");

    public static readonly CardBrand AmericanExpress = new("AMERICAN_EXPRESS");

    public static readonly CardBrand Discover = new("DISCOVER");

    public static readonly CardBrand DiscoverDiners = new("DISCOVER_DINERS");

    public static readonly CardBrand Jcb = new("JCB");

    public static readonly CardBrand ChinaUnionpay = new("CHINA_UNIONPAY");

    public static readonly CardBrand SquareGiftCard = new("SQUARE_GIFT_CARD");

    public static readonly CardBrand SquareCapitalCard = new("SQUARE_CAPITAL_CARD");

    public static readonly CardBrand Interac = new("INTERAC");

    public static readonly CardBrand Eftpos = new("EFTPOS");

    public static readonly CardBrand Felica = new("FELICA");

    public static readonly CardBrand Ebt = new("EBT");

    public static CardBrand FromValue(string value) => FromValueCore(value);
}
