using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the response returned by <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/create-payment">CreatePayment</see>.
/// <para>
/// If there are errors processing the request, the <c>payment</c> field might not be
/// present, or it might be present with a status of <c>FAILED</c>.
/// </para>
/// </summary>
public record CreatePaymentResponse
{
    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a payment processed by the Square API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment")]
    public Payment? Payment { get; init; }
}
