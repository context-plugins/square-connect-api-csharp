using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The brand of a credit card.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<V1TenderCardBrand>))]
public sealed record V1TenderCardBrand : StringEnum<V1TenderCardBrand>
{
    private V1TenderCardBrand(string value) : base(value)
    {
    }

    public static readonly V1TenderCardBrand OtherBrand = new("OTHER_BRAND");

    public static readonly V1TenderCardBrand Visa = new("VISA");

    public static readonly V1TenderCardBrand MasterCard = new("MASTER_CARD");

    public static readonly V1TenderCardBrand AmericanExpress = new("AMERICAN_EXPRESS");

    public static readonly V1TenderCardBrand Discover = new("DISCOVER");

    public static readonly V1TenderCardBrand DiscoverDiners = new("DISCOVER_DINERS");

    public static readonly V1TenderCardBrand Jcb = new("JCB");

    public static readonly V1TenderCardBrand ChinaUnionpay = new("CHINA_UNIONPAY");

    public static readonly V1TenderCardBrand SquareGiftCard = new("SQUARE_GIFT_CARD");

    public static V1TenderCardBrand FromValue(string value) => FromValueCore(value);
}
