using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A request to calculate the points that a buyer can earn from
/// a specified purchase.
/// </summary>
public record CalculateLoyaltyPointsRequest
{
    /// <summary>
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Order">order</see> ID for which to calculate the points.
    /// Specify this field if your application uses the Orders API to process orders.
    /// Otherwise, specify the <c>transaction_amount_money</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_amount_money")]
    public Money? TransactionAmountMoney { get; init; }
}
