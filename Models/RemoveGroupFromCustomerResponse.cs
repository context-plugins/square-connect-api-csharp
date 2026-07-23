using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/customers-api/remove-group-from-customer">RemoveGroupFromCustomer</see>
/// endpoint.
/// </summary>
public record RemoveGroupFromCustomerResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
