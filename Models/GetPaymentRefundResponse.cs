using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the response returned by <see href="https://developer.squareup.com/reference/square_2021-08-18/refunds-api/get-payment-refund">GetRefund</see>.
/// <para>
/// Note: If there are errors processing the request, the refund field might not be
/// present or it might be present in a FAILED state.
/// </para>
/// </summary>
public record GetPaymentRefundResponse
{
    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a refund of a payment made using Square. Contains information about
    /// the original payment and the amount of money refunded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund")]
    public PaymentRefund? Refund { get; init; }
}
