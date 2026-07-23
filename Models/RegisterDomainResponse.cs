using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/apple-pay-api/register-domain">RegisterDomain</see> endpoint.
/// <para>
/// Either <c>errors</c> or <c>status</c> are present in a given response (never both).
/// </para>
/// </summary>
public record RegisterDomainResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The status of the domain registration.
    /// <para>
    /// See <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/RegisterDomainResponseStatus">RegisterDomainResponseStatus</see> for possible values.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
