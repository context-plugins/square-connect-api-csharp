using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body for requests to the <c>RetrieveCustomerSegment</c> endpoint.
/// <para>
/// Either <c>errors</c> or <c>segment</c> is present in a given response (never both).
/// </para>
/// </summary>
public record RetrieveCustomerSegmentResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a group of customer profiles that match one or more predefined filter criteria.
    /// <para>
    /// Segments (also known as Smart Groups) are defined and created within the Customer Directory in the
    /// Square Seller Dashboard or Point of Sale.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segment")]
    public CustomerSegment? Segment { get; init; }
}
