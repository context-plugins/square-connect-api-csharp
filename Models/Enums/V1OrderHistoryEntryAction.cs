using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1OrderHistoryEntryAction>))]
public sealed record V1OrderHistoryEntryAction : StringEnum<V1OrderHistoryEntryAction>
{
    private V1OrderHistoryEntryAction(string value) : base(value)
    {
    }

    public static readonly V1OrderHistoryEntryAction OrderPlaced = new("ORDER_PLACED");

    public static readonly V1OrderHistoryEntryAction Declined = new("DECLINED");

    public static readonly V1OrderHistoryEntryAction PaymentReceived = new("PAYMENT_RECEIVED");

    public static readonly V1OrderHistoryEntryAction Canceled = new("CANCELED");

    public static readonly V1OrderHistoryEntryAction Completed = new("COMPLETED");

    public static readonly V1OrderHistoryEntryAction Refunded = new("REFUNDED");

    public static readonly V1OrderHistoryEntryAction Expired = new("EXPIRED");

    public static V1OrderHistoryEntryAction FromValue(string value) => FromValueCore(value);
}
