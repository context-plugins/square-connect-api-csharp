using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1TenderEntryMethod>))]
public sealed record V1TenderEntryMethod : StringEnum<V1TenderEntryMethod>
{
    private V1TenderEntryMethod(string value) : base(value)
    {
    }

    public static readonly V1TenderEntryMethod Manual = new("MANUAL");

    public static readonly V1TenderEntryMethod Scanned = new("SCANNED");

    public static readonly V1TenderEntryMethod SquareCash = new("SQUARE_CASH");

    public static readonly V1TenderEntryMethod SquareWallet = new("SQUARE_WALLET");

    public static readonly V1TenderEntryMethod Swiped = new("SWIPED");

    public static readonly V1TenderEntryMethod WebForm = new("WEB_FORM");

    public static readonly V1TenderEntryMethod Other = new("OTHER");

    public static V1TenderEntryMethod FromValue(string value) => FromValueCore(value);
}
