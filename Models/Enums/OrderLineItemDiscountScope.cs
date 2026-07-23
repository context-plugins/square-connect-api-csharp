using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates whether this is a line-item or order-level discount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemDiscountScope>))]
public sealed record OrderLineItemDiscountScope : StringEnum<OrderLineItemDiscountScope>
{
    private OrderLineItemDiscountScope(string value) : base(value)
    {
    }

    /// <summary>
    /// Used for reporting only.
    /// The original transaction discount scope is currently not supported by the API.
    /// </summary>
    public static readonly OrderLineItemDiscountScope OtherDiscountScope = new("OTHER_DISCOUNT_SCOPE");

    /// <summary>
    /// The discount should be applied to only line items specified by
    /// <c>OrderLineItemAppliedDiscount</c> reference records.
    /// </summary>
    public static readonly OrderLineItemDiscountScope LineItem = new("LINE_ITEM");

    /// <summary>
    /// The discount should be applied to the entire order.
    /// </summary>
    public static readonly OrderLineItemDiscountScope Order = new("ORDER");

    public static OrderLineItemDiscountScope FromValue(string value) => FromValueCore(value);
}
