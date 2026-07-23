using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The payment methods that customers can use to pay an invoice on the Square-hosted invoice page.
/// </summary>
public record InvoiceAcceptedPaymentMethods
{
    /// <summary>
    /// Indicates whether bank transfer payments are accepted. The default value is <c>false</c>.
    /// <para>
    /// This option is allowed only for invoices that have a single payment request of type <c>BALANCE</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account")]
    public bool? BankAccount { get; init; }

    /// <summary>
    /// Indicates whether credit card or debit card payments are accepted. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public bool? Card { get; init; }

    /// <summary>
    /// Indicates whether Square gift card payments are accepted. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("square_gift_card")]
    public bool? SquareGiftCard { get; init; }
}
