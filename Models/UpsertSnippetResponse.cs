using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an <c>UpsertSnippet</c> response. The response can include either <c>snippet</c> or <c>errors</c>.
/// </summary>
public record UpsertSnippetResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Represents the snippet that is added to a Square Online site. The snippet code is injected into the <c>head</c> element of all pages on the site, except for checkout pages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snippet")]
    public Snippet? Snippet { get; init; }
}
