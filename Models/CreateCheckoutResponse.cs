using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <c>CreateCheckout</c> endpoint.
/// </summary>
public record CreateCheckoutResponse
{
    /// <summary>
    /// Square Checkout lets merchants accept online payments for supported
    /// payment types using a checkout workflow hosted on squareup.com.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkout")]
    public Checkout? Checkout { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
