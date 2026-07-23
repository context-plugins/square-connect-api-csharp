using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The set of line items, service charges, taxes, discounts, tips, and other items being returned in an order.
/// </summary>
public record OrderReturn
{
    /// <summary>
    /// A collection of various money amounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_amounts")]
    public OrderMoneyAmounts? ReturnAmounts { get; init; }

    /// <summary>
    /// A collection of references to discounts being returned for an order, including the total
    /// applied discount amount to be returned. The discounts must reference a top-level discount ID
    /// from the source order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_discounts")]
    public IReadOnlyList<OrderReturnDiscount>? ReturnDiscounts { get; init; }

    /// <summary>
    /// A collection of line items that are being returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_line_items")]
    public IReadOnlyList<OrderReturnLineItem>? ReturnLineItems { get; init; }

    /// <summary>
    /// A collection of service charges that are being returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_service_charges")]
    public IReadOnlyList<OrderReturnServiceCharge>? ReturnServiceCharges { get; init; }

    /// <summary>
    /// A collection of references to taxes being returned for an order, including the total
    /// applied tax amount to be returned. The taxes must reference a top-level tax ID from the source
    /// order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_taxes")]
    public IReadOnlyList<OrderReturnTax>? ReturnTaxes { get; init; }

    /// <summary>
    /// A rounding adjustment of the money being returned. Commonly used to apply cash rounding
    /// when the minimum unit of the account is smaller than the lowest physical denomination of the currency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rounding_adjustment")]
    public OrderRoundingAdjustment? RoundingAdjustment { get; init; }

    /// <summary>
    /// An order that contains the original sale of these return line items. This is unset
    /// for unlinked returns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_order_id")]
    public string? SourceOrderId { get; init; }

    /// <summary>
    /// A unique ID that identifies the return only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }
}
