using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The response object returned by the <see href="https://developer.squareup.com/reference/square_2021-08-18/merchants-api/retrieve-merchant">RetrieveMerchant</see> endpoint.
/// </summary>
public record RetrieveMerchantResponse
{
    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a Square seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public Merchant? Merchant { get; init; }
}
