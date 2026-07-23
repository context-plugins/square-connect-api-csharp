using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <c>UpdateCustomer</c> endpoint.
/// <para>
/// Either <c>errors</c> or <c>customer</c> is present in a given response (never both).
/// </para>
/// </summary>
public record UpdateCustomerResponse
{
    /// <summary>
    /// Represents a Square customer profile in the Customer Directory of a Square seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer")]
    public Customer? Customer { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
