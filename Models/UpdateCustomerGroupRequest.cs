using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the body parameters that can be included in a request to the
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/customer-groups-api/update-customer-group">UpdateCustomerGroup</see> endpoint.
/// </summary>
public record UpdateCustomerGroupRequest
{
    /// <summary>
    /// Represents a group of customer profiles.
    /// <para>
    /// Customer groups can be created, be modified, and have their membership defined using
    /// the Customers API or within the Customer Directory in the Square Seller Dashboard or Point of Sale.
    /// </para>
    /// </summary>
    [JsonPropertyName("group")]
    public required CustomerGroup Group { get; init; }
}
