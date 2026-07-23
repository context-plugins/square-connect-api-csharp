using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Request object for fetching all <c>BankAccount</c>
/// objects linked to a account.
/// </summary>
public record ListBankAccountsRequest
{
    /// <summary>
    /// The pagination cursor returned by a previous call to this endpoint.
    /// Use it in the next <c>ListBankAccounts</c> request to retrieve the next set
    /// of results.
    /// <para>
    /// See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Upper limit on the number of bank accounts to return in the response.
    /// Currently, 1000 is the largest supported limit. You can specify a limit
    /// of up to 1000 bank accounts. This is also the default limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// Location ID. You can specify this optional filter
    /// to retrieve only the linked bank accounts belonging to a specific location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }
}
