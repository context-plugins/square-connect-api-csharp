using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the body parameters that can be included in
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/create-refund">CreateRefund</see> endpoint.
/// <para>
/// Deprecated - recommend using <see href="https://developer.squareup.com/reference/square_2021-08-18/refunds-api/refund-payment">RefundPayment</see>
/// </para>
/// </summary>
public record CreateRefundRequest
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

    /// <summary>
    /// A value you specify that uniquely identifies this
    /// refund among refunds you've created for the tender.
    /// <para>
    /// If you're unsure whether a particular refund succeeded,
    /// you can reattempt it with the same idempotency key without
    /// worrying about duplicating the refund.
    /// </para>
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(192, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// A description of the reason for the refund.
    /// <para>
    /// Default value: <c>Refund via API</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    [MaxLength(192)]
    public string? Reason { get; init; }

    /// <summary>
    /// The ID of the tender to refund.
    /// <para>
    /// A <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Transaction"><c>Transaction</c></see> has one or more <c>tenders</c> (i.e., methods
    /// of payment) associated with it, and you refund each tender separately with
    /// the Connect API.
    /// </para>
    /// </summary>
    [JsonPropertyName("tender_id")]
    [StringLength(192, MinimumLength = 1)]
    public required string TenderId { get; init; }
}
