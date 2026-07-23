using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates how the tax is applied to the associated line item or order.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemTaxType>))]
public sealed record OrderLineItemTaxType : StringEnum<OrderLineItemTaxType>
{
    private OrderLineItemTaxType(string value) : base(value)
    {
    }

    /// <summary>
    /// Used for reporting only.
    /// The original transaction tax type is currently not supported by the API.
    /// </summary>
    public static readonly OrderLineItemTaxType UnknownTax = new("UNKNOWN_TAX");

    /// <summary>
    /// The tax is an additive tax. The tax amount is added on top of the price.
    /// For example, an item with a cost of 1.00 USD and a 10% additive tax has a total
    /// cost to the buyer of 1.10 USD.
    /// </summary>
    public static readonly OrderLineItemTaxType Additive = new("ADDITIVE");

    /// <summary>
    /// The tax is an inclusive tax. Inclusive taxes are already included
    /// in the line item price or order total. For example, an item with a cost of
    /// 1.00 USD and a 10% inclusive tax has a pretax cost of 0.91 USD
    /// (91 cents) and a 0.09 (9 cents) tax for a total cost of 1.00 USD to
    /// the buyer.
    /// </summary>
    public static readonly OrderLineItemTaxType Inclusive = new("INCLUSIVE");

    public static OrderLineItemTaxType FromValue(string value) => FromValueCore(value);
}
