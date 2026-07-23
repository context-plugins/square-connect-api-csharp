using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates a card's prepaid type, such as <c>NOT_PREPAID</c> or <c>PREPAID</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CardPrepaidType>))]
public sealed record CardPrepaidType : StringEnum<CardPrepaidType>
{
    private CardPrepaidType(string value) : base(value)
    {
    }

    public static readonly CardPrepaidType UnknownPrepaidType = new("UNKNOWN_PREPAID_TYPE");

    public static readonly CardPrepaidType NotPrepaid = new("NOT_PREPAID");

    public static readonly CardPrepaidType Prepaid = new("PREPAID");

    public static CardPrepaidType FromValue(string value) => FromValueCore(value);
}
