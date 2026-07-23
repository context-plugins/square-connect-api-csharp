using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in requests to the
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/orders-api/pay-order">PayOrder</see> endpoint.
/// </summary>
public record PayOrderRequest
{
    /// <summary>
    /// A value you specify that uniquely identifies this request among requests you have sent. If
    /// you are unsure whether a particular payment request was completed successfully, you can reattempt
    /// it with the same idempotency key without worrying about duplicate payments.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(192, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The version of the order being paid. If not supplied, the latest version will be paid.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_version")]
    public int? OrderVersion { get; init; }

    /// <summary>
    /// The IDs of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Payment">payments</see> to collect.
    /// The payment total must match the order total.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_ids")]
    public IReadOnlyList<string>? PaymentIds { get; init; }
}
