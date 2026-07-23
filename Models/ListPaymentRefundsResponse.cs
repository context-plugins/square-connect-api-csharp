using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the response returned by <see href="https://developer.squareup.com/reference/square_2021-08-18/refunds-api/list-payment-refunds">ListPaymentRefunds</see>.
/// <para>
/// Either <c>errors</c> or <c>refunds</c> is present in a given response (never both).
/// </para>
/// </summary>
public record ListPaymentRefundsResponse
{
    /// <summary>
    /// The pagination cursor to be used in a subsequent request. If empty,
    /// this is the final response.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The list of requested refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refunds")]
    public IReadOnlyList<PaymentRefund>? Refunds { get; init; }
}
