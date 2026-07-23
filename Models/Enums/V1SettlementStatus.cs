using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1SettlementStatus>))]
public sealed record V1SettlementStatus : StringEnum<V1SettlementStatus>
{
    private V1SettlementStatus(string value) : base(value)
    {
    }

    public static readonly V1SettlementStatus Failed = new("FAILED");

    public static readonly V1SettlementStatus Sent = new("SENT");

    public static V1SettlementStatus FromValue(string value) => FromValueCore(value);
}
