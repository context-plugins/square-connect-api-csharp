using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType>))]
public sealed record ProductType : StringEnum<ProductType>
{
    private ProductType(string value) : base(value)
    {
    }

    public static readonly ProductType TerminalApi = new("TERMINAL_API");

    public static ProductType FromValue(string value) => FromValueCore(value);
}
