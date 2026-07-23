using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1RefundType>))]
public sealed record V1RefundType : StringEnum<V1RefundType>
{
    private V1RefundType(string value) : base(value)
    {
    }

    public static readonly V1RefundType Full = new("FULL");

    public static readonly V1RefundType Partial = new("PARTIAL");

    public static V1RefundType FromValue(string value) => FromValueCore(value);
}
