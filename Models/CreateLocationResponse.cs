using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Response object returned by the <see href="https://developer.squareup.com/reference/square_2021-08-18/locations-api/create-location">CreateLocation</see> endpoint.
/// </summary>
public record CreateLocationResponse
{
    /// <summary>
    /// Information on errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public Location? Location { get; init; }
}
