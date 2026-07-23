using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates a card's type, such as <c>CREDIT</c> or <c>DEBIT</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardType>))]
public sealed record CardType : StringEnum<CardType>
{
    private CardType(string value) : base(value)
    {
    }

    public static readonly CardType UnknownCardType = new("UNKNOWN_CARD_TYPE");

    public static readonly CardType Credit = new("CREDIT");

    public static readonly CardType Debit = new("DEBIT");

    public static CardType FromValue(string value) => FromValueCore(value);
}
