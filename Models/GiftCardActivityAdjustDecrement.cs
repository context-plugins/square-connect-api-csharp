using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a gift card activity of the ADJUST_DECREMENT type.
/// </summary>
public record GiftCardActivityAdjustDecrement
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

    [JsonPropertyName("reason")]
    public required object Reason { get; init; }
}
