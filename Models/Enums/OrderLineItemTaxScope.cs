using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates whether this is a line-item or order-level tax.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderLineItemTaxScope>))]
public sealed record OrderLineItemTaxScope : StringEnum<OrderLineItemTaxScope>
{
    private OrderLineItemTaxScope(string value) : base(value)
    {
    }

    /// <summary>
    /// Used for reporting only.
    /// The original transaction tax scope is currently not supported by the API.
    /// </summary>
    public static readonly OrderLineItemTaxScope OtherTaxScope = new("OTHER_TAX_SCOPE");

    /// <summary>
    /// The tax should be applied only to line items specified by
    /// the <c>OrderLineItemAppliedTax</c> reference records.
    /// </summary>
    public static readonly OrderLineItemTaxScope LineItem = new("LINE_ITEM");

    /// <summary>
    /// The tax should be applied to the entire order.
    /// </summary>
    public static readonly OrderLineItemTaxScope Order = new("ORDER");

    public static OrderLineItemTaxScope FromValue(string value) => FromValueCore(value);
}
