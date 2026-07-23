using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a group of customer profiles.
/// <para>
/// Customer groups can be created, be modified, and have their membership defined using
/// the Customers API or within the Customer Directory in the Square Seller Dashboard or Point of Sale.
/// </para>
/// </summary>
public record CustomerGroup
{
    /// <summary>
    /// The timestamp when the customer group was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// A unique Square-generated ID for the customer group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the customer group.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The timestamp when the customer group was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
