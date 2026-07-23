using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Represents the line item type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemItemType>))]
public sealed record OrderLineItemItemType : StringEnum<OrderLineItemItemType>
{
    private OrderLineItemItemType(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the line item is an itemized sale.
    /// </summary>
    public static readonly OrderLineItemItemType Item = new("ITEM");

    /// <summary>
    /// Indicates that the line item is a non-itemized sale.
    /// </summary>
    public static readonly OrderLineItemItemType CustomAmount = new("CUSTOM_AMOUNT");

    /// <summary>
    /// Indicates that the line item is a gift card sale. Gift cards sold through
    /// the Orders API are sold in an unactivated state and can be activated through the
    /// Gift Cards API using the line item <c>uid</c>.
    /// </summary>
    public static readonly OrderLineItemItemType GiftCard = new("GIFT_CARD");

    public static OrderLineItemItemType FromValue(string value) => FromValueCore(value);
}
