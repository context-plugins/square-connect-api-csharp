using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CardSquareProduct>))]
public sealed record CardSquareProduct : StringEnum<CardSquareProduct>
{
    private CardSquareProduct(string value) : base(value)
    {
    }

    public static readonly CardSquareProduct UnknownSquareProduct = new("UNKNOWN_SQUARE_PRODUCT");

    public static readonly CardSquareProduct ConnectApi = new("CONNECT_API");

    public static readonly CardSquareProduct Dashboard = new("DASHBOARD");

    public static readonly CardSquareProduct RegisterClient = new("REGISTER_CLIENT");

    public static readonly CardSquareProduct BuyerDashboard = new("BUYER_DASHBOARD");

    public static readonly CardSquareProduct Web = new("WEB");

    public static readonly CardSquareProduct Invoices = new("INVOICES");

    public static readonly CardSquareProduct GiftCard = new("GIFT_CARD");

    public static readonly CardSquareProduct VirtualTerminal = new("VIRTUAL_TERMINAL");

    public static readonly CardSquareProduct ReaderSdk = new("READER_SDK");

    public static CardSquareProduct FromValue(string value) => FromValueCore(value);
}
