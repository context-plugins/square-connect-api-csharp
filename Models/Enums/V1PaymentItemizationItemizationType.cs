using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1PaymentItemizationItemizationType>))]
public sealed record V1PaymentItemizationItemizationType : StringEnum<V1PaymentItemizationItemizationType>
{
    private V1PaymentItemizationItemizationType(string value) : base(value)
    {
    }

    public static readonly V1PaymentItemizationItemizationType Item = new("ITEM");

    public static readonly V1PaymentItemizationItemizationType CustomAmount = new("CUSTOM_AMOUNT");

    public static readonly V1PaymentItemizationItemizationType GiftCardActivation = new("GIFT_CARD_ACTIVATION");

    public static readonly V1PaymentItemizationItemizationType GiftCardReload = new("GIFT_CARD_RELOAD");

    public static readonly V1PaymentItemizationItemizationType GiftCardUnknown = new("GIFT_CARD_UNKNOWN");

    public static readonly V1PaymentItemizationItemizationType Other = new("OTHER");

    public static V1PaymentItemizationItemizationType FromValue(string value) => FromValueCore(value);
}
