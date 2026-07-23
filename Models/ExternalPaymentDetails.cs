using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Stores details about an external payment. Contains only non-confidential information.
/// For more information, see
/// <see href="https://developer.squareup.com/docs/payments-api/take-payments/external-payments">Take External Payments</see>.
/// </summary>
public record ExternalPaymentDetails
{
    /// <summary>
    /// A description of the external payment source. For example,
    /// "Food Delivery Service".
    /// </summary>
    [JsonPropertyName("source")]
    [MaxLength(255)]
    public required string Source { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_fee_money")]
    public Money? SourceFeeMoney { get; init; }

    /// <summary>
    /// An ID to associate the payment to its originating source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_id")]
    [MaxLength(255)]
    public string? SourceId { get; init; }

    /// <summary>
    /// The type of external payment the seller received. It can be one of the following:
    /// - CHECK - Paid using a physical check.
    /// - BANK_TRANSFER - Paid using external bank transfer.
    /// - OTHER\_GIFT\_CARD - Paid using a non-Square gift card.
    /// - CRYPTO - Paid using a crypto currency.
    /// - SQUARE_CASH - Paid using Square Cash App.
    /// - SOCIAL - Paid using peer-to-peer payment applications.
    /// - EXTERNAL - A third-party application gathered this payment outside of Square.
    /// - EMONEY - Paid using an E-money provider.
    /// - CARD - A credit or debit card that Square does not support.
    /// - STORED_BALANCE - Use for house accounts, store credit, and so forth.
    /// - FOOD_VOUCHER - Restaurant voucher provided by employers to employees to pay for meals
    /// - OTHER - A type not listed here.
    /// </summary>
    [JsonPropertyName("type")]
    [MaxLength(50)]
    public required string Type { get; init; }
}
