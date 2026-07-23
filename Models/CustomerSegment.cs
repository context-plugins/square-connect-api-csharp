using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a group of customer profiles that match one or more predefined filter criteria.
/// <para>
/// Segments (also known as Smart Groups) are defined and created within the Customer Directory in the
/// Square Seller Dashboard or Point of Sale.
/// </para>
/// </summary>
public record CustomerSegment
{
    /// <summary>
    /// The timestamp when the segment was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// A unique Square-generated ID for the segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the segment.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The timestamp when the segment was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
