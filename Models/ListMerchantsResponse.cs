using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The response object returned by the <see href="https://developer.squareup.com/reference/square_2021-08-18/merchants-api/list-merchants">ListMerchant</see> endpoint.
/// </summary>
public record ListMerchantsResponse
{
    /// <summary>
    /// If the  response is truncated, the cursor to use in next  request to fetch next set of objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public int? Cursor { get; init; }

    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The requested <c>Merchant</c> entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public IReadOnlyList<Merchant>? Merchant { get; init; }
}
