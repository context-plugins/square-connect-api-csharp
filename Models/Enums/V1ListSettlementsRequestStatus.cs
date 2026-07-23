using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1ListSettlementsRequestStatus>))]
public sealed record V1ListSettlementsRequestStatus : StringEnum<V1ListSettlementsRequestStatus>
{
    private V1ListSettlementsRequestStatus(string value) : base(value)
    {
    }

    public static readonly V1ListSettlementsRequestStatus Sent = new("SENT");

    public static readonly V1ListSettlementsRequestStatus Failed = new("FAILED");

    public static V1ListSettlementsRequestStatus FromValue(string value) => FromValueCore(value);
}
