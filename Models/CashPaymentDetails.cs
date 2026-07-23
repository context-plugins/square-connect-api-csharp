using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Stores details about a cash payment. Contains only non-confidential information. For more information, see
/// <see href="https://developer.squareup.com/docs/payments-api/take-payments/cash-payments">Take Cash Payments</see>.
/// </summary>
public record CashPaymentDetails
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("buyer_supplied_money")]
    public required Money BuyerSuppliedMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("change_back_money")]
    public Money? ChangeBackMoney { get; init; }
}
