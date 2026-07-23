using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the __CreateMobileAuthorizationCode__ endpoint.
/// </summary>
public record CreateMobileAuthorizationCodeResponse
{
    /// <summary>
    /// Generated authorization code that connects a mobile application instance
    /// to a Square account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorization_code")]
    [StringLength(191, MinimumLength = 0)]
    public string? AuthorizationCode { get; init; }

    /// <summary>
    /// Represents an error encountered during a request to the Connect API.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/build-basics/handling-errors">Handling errors</see> for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error? Error { get; init; }

    /// <summary>
    /// The timestamp when <c>authorization_code</c> expires in
    /// <see href="https://tools.ietf.org/html/rfc3339">RFC 3339</see> format, e.g., "2016-09-04T23:59:33.123Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    [StringLength(48, MinimumLength = 20)]
    public string? ExpiresAt { get; init; }
}
