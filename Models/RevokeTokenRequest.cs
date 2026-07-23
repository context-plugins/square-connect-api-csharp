using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RevokeTokenRequest
{
    /// <summary>
    /// The access token of the merchant whose token you want to revoke.
    /// Do not provide a value for merchant_id if you provide this parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? AccessToken { get; init; }

    /// <summary>
    /// The Square issued ID for your application, available from the
    /// <see href="https://developer.squareup.com/apps">developer dashboard</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    [MaxLength(191)]
    public string? ClientId { get; init; }

    /// <summary>
    /// The ID of the merchant whose token you want to revoke.
    /// Do not provide a value for access_token if you provide this parameter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// If <c>true</c>, terminate the given single access token, but do not
    /// terminate the entire authorization.
    /// Default: <c>false</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revoke_only_access_token")]
    public bool? RevokeOnlyAccessToken { get; init; }
}
