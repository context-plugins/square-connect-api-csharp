using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the response returned by
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/cancel-payment-by-idempotency-key">CancelPaymentByIdempotencyKey</see>.
/// On success, <c>errors</c> is empty.
/// </summary>
public record CancelPaymentByIdempotencyKeyResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
