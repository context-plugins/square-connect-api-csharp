using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines fields in a <c>ListDisputes</c> response.
/// </summary>
public record ListDisputesResponse
{
    /// <summary>
    /// The pagination cursor to be used in a subsequent request.
    /// If unset, this is the final response. For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The list of disputes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disputes")]
    public IReadOnlyList<Dispute>? Disputes { get; init; }

    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
