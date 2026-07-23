using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1CreateRefundRequest
/// </summary>
public record V1CreateRefundRequest
{
    /// <summary>
    /// The ID of the payment to refund. If you are creating a <c>PARTIAL</c>
    /// refund for a split tender payment, instead provide the id of the
    /// particular tender you want to refund.
    /// </summary>
    [JsonPropertyName("payment_id")]
    public required string PaymentId { get; init; }

    /// <summary>
    /// The reason for the refund.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunded_money")]
    public V1Money? RefundedMoney { get; init; }

    /// <summary>
    /// An optional key to ensure idempotence if you issue the same PARTIAL refund request more than once.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_idempotence_key")]
    public string? RequestIdempotenceKey { get; init; }

    /// <summary>
    /// The type of refund (FULL or PARTIAL).
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
