using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1CreateRefundRequestType>))]
public sealed record V1CreateRefundRequestType : StringEnum<V1CreateRefundRequestType>
{
    private V1CreateRefundRequestType(string value) : base(value)
    {
    }

    public static readonly V1CreateRefundRequestType Full = new("FULL");

    public static readonly V1CreateRefundRequestType Partial = new("PARTIAL");

    public static V1CreateRefundRequestType FromValue(string value) => FromValueCore(value);
}
