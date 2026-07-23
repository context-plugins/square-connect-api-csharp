using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the parameters for a <c>ListDisputeEvidence</c> request.
/// </summary>
public record ListDisputeEvidenceRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }
}
