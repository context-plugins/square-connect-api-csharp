using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The current state of this fulfillment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderFulfillmentState>))]
public sealed record OrderFulfillmentState : StringEnum<OrderFulfillmentState>
{
    private OrderFulfillmentState(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the fulfillment has been proposed.
    /// </summary>
    public static readonly OrderFulfillmentState Proposed = new("PROPOSED");

    /// <summary>
    /// Indicates that the fulfillment has been reserved.
    /// </summary>
    public static readonly OrderFulfillmentState Reserved = new("RESERVED");

    /// <summary>
    /// Indicates that the fulfillment has been prepared.
    /// </summary>
    public static readonly OrderFulfillmentState Prepared = new("PREPARED");

    /// <summary>
    /// Indicates that the fulfillment was successfully completed.
    /// </summary>
    public static readonly OrderFulfillmentState Completed = new("COMPLETED");

    /// <summary>
    /// Indicates that the fulfillment was canceled.
    /// </summary>
    public static readonly OrderFulfillmentState Canceled = new("CANCELED");

    /// <summary>
    /// Indicates that the fulfillment failed to be completed, but was not explicitly
    /// canceled.
    /// </summary>
    public static readonly OrderFulfillmentState Failed = new("FAILED");

    public static OrderFulfillmentState FromValue(string value) => FromValueCore(value);
}
