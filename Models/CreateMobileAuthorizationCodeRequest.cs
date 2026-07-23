using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the body parameters that can be provided in a request to the
/// __CreateMobileAuthorizationCode__ endpoint.
/// </summary>
public record CreateMobileAuthorizationCodeRequest
{
    /// <summary>
    /// The Square location ID the authorization code should be tied to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    [StringLength(191, MinimumLength = 1)]
    public string? LocationId { get; init; }
}
