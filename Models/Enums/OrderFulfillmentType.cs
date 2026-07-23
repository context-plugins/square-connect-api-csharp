using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The type of fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderFulfillmentType>))]
public sealed record OrderFulfillmentType : StringEnum<OrderFulfillmentType>
{
    private OrderFulfillmentType(string value) : base(value)
    {
    }

    /// <summary>
    /// A fulfillment to be picked up from a physical <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">location</see>
    /// by a recipient.
    /// </summary>
    public static readonly OrderFulfillmentType Pickup = new("PICKUP");

    /// <summary>
    /// A fulfillment to be shipped by a shipping carrier.
    /// </summary>
    public static readonly OrderFulfillmentType Shipment = new("SHIPMENT");

    public static OrderFulfillmentType FromValue(string value) => FromValueCore(value);
}
