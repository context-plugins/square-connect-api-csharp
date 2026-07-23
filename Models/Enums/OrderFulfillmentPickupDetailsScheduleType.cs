using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The schedule type of the pickup fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderFulfillmentPickupDetailsScheduleType>))]
public sealed record OrderFulfillmentPickupDetailsScheduleType : StringEnum<OrderFulfillmentPickupDetailsScheduleType>
{
    private OrderFulfillmentPickupDetailsScheduleType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the fulfillment will be picked up at a scheduled pickup time.
    /// </summary>
    public static readonly OrderFulfillmentPickupDetailsScheduleType Scheduled = new("SCHEDULED");

    /// <summary>
    /// Indicates that the fulfillment will be picked up as soon as possible and
    /// should be prepared immediately.
    /// </summary>
    public static readonly OrderFulfillmentPickupDetailsScheduleType Asap = new("ASAP");

    public static OrderFulfillmentPickupDetailsScheduleType FromValue(string value) => FromValueCore(value);
}
