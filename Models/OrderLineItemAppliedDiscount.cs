using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an applied portion of a discount to a line item in an order.
/// <para>
/// Order scoped discounts have automatically applied discounts present for each line item.
/// Line-item scoped discounts must have applied discounts added manually for any applicable line
/// items. The corresponding applied money is automatically computed based on participating
/// line items.
/// </para>
/// </summary>
public record OrderLineItemAppliedDiscount
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_money")]
    public Money? AppliedMoney { get; init; }

    /// <summary>
    /// The <c>uid</c> of the discount that the applied discount represents. It must
    /// reference a discount present in the <c>order.discounts</c> field.
    /// <para>
    /// This field is immutable. To change which discounts apply to a line item,
    /// you must delete the discount and re-add it as a new <c>OrderLineItemAppliedDiscount</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("discount_uid")]
    [StringLength(60, MinimumLength = 1)]
    public required string DiscountUid { get; init; }

    /// <summary>
    /// A unique ID that identifies the applied discount only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }
}
