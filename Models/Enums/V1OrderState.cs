using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1OrderState>))]
public sealed record V1OrderState : StringEnum<V1OrderState>
{
    private V1OrderState(string value) : base(value)
    {
    }

    public static readonly V1OrderState Pending = new("PENDING");

    public static readonly V1OrderState Open = new("OPEN");

    public static readonly V1OrderState Completed = new("COMPLETED");

    public static readonly V1OrderState Canceled = new("CANCELED");

    public static readonly V1OrderState Refunded = new("REFUNDED");

    public static readonly V1OrderState Rejected = new("REJECTED");

    public static V1OrderState FromValue(string value) => FromValueCore(value);
}
