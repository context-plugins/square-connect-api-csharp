using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/retrieve-transaction">RetrieveTransaction</see> endpoint.
/// <para>
/// One of <c>errors</c> or <c>transaction</c> is present in a given response (never both).
/// </para>
/// </summary>
public record RetrieveTransactionResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a transaction processed with Square, either with the
    /// Connect API or with Square Point of Sale.
    /// <para>
    /// The <c>tenders</c> field of this object lists all methods of payment used to pay in
    /// the transaction.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction")]
    public Transaction? Transaction { get; init; }
}
