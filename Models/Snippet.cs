using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the snippet that is added to a Square Online site. The snippet code is injected into the <c>head</c> element of all pages on the site, except for checkout pages.
/// </summary>
public record Snippet
{
    /// <summary>
    /// The snippet code, which can contain valid HTML, JavaScript, or both.
    /// </summary>
    [JsonPropertyName("content")]
    [StringLength(65535, MinimumLength = 1)]
    public required string Content { get; init; }

    /// <summary>
    /// The timestamp of when the snippet was initially added to the site, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The Square-assigned ID for the snippet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(48)]
    public string? Id { get; init; }

    /// <summary>
    /// The ID of the site that contains the snippet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("site_id")]
    public string? SiteId { get; init; }

    /// <summary>
    /// The timestamp of when the snippet was last updated on the site, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
