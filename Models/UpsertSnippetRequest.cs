using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an <c>UpsertSnippet</c> request.
/// </summary>
public record UpsertSnippetRequest
{
    /// <summary>
    /// Represents the snippet that is added to a Square Online site. The snippet code is injected into the <c>head</c> element of all pages on the site, except for checkout pages.
    /// </summary>
    [JsonPropertyName("snippet")]
    public required Snippet Snippet { get; init; }
}
