using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/list-transactions">ListTransactions</see> endpoint.
/// <para>
/// One of <c>errors</c> or <c>transactions</c> is present in a given response (never both).
/// </para>
/// </summary>
public record ListTransactionsResponse
{
    /// <summary>
    /// A pagination cursor for retrieving the next set of results,
    /// if any remain. Provide this value as the <c>cursor</c> parameter in a subsequent
    /// request to this endpoint.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// An array of transactions that match your query.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactions")]
    public IReadOnlyList<Transaction>? Transactions { get; init; }
}
