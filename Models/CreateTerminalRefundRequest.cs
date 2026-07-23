using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record CreateTerminalRefundRequest
{
    /// <summary>
    /// A unique string that identifies this <c>CreateRefund</c> request. Keys can be any valid string but
    /// must be unique for every <c>CreateRefund</c> request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [MinLength(1)]
    public required string IdempotencyKey { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public TerminalRefund? Refund { get; init; }
}
