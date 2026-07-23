using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the body parameters that can be included in a request to the
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/customer-groups-api/create-customer-group">CreateCustomerGroup</see> endpoint.
/// </summary>
public record CreateCustomerGroupRequest
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

    /// <summary>
    /// The idempotency key for the request. For more information, see <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    public string? IdempotencyKey { get; init; }
}
