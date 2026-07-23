using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RevokeTokenResponse
{
    /// <summary>
    /// If the request is successful, this is true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("success")]
    public bool? Success { get; init; }
}
