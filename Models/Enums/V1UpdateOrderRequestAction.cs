using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1UpdateOrderRequestAction>))]
public sealed record V1UpdateOrderRequestAction : StringEnum<V1UpdateOrderRequestAction>
{
    private V1UpdateOrderRequestAction(string value) : base(value)
    {
    }

    public static readonly V1UpdateOrderRequestAction Complete = new("COMPLETE");

    public static readonly V1UpdateOrderRequestAction Cancel = new("CANCEL");

    public static readonly V1UpdateOrderRequestAction Refund = new("REFUND");

    public static V1UpdateOrderRequestAction FromValue(string value) => FromValueCore(value);
}
