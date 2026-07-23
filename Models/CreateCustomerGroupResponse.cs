using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/customer-groups-api/create-customer-group">CreateCustomerGroup</see> endpoint.
/// <para>
/// Either <c>errors</c> or <c>group</c> is present in a given response (never both).
/// </para>
/// </summary>
public record CreateCustomerGroupResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents a group of customer profiles.
    /// <para>
    /// Customer groups can be created, be modified, and have their membership defined using
    /// the Customers API or within the Customer Directory in the Square Seller Dashboard or Point of Sale.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public CustomerGroup? Group { get; init; }
}
