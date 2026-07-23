using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RenewTokenRequest
{
    /// <summary>
    /// The token you want to renew.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? AccessToken { get; init; }
}
