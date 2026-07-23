using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record ObtainTokenResponse
{
    /// <summary>
    /// A valid OAuth access token. OAuth access tokens are 64 bytes long.
    /// Provide the access token in a header with every request to Connect API
    /// endpoints. See <see href="https://developer.squareup.com/docs/oauth-api/walkthrough">OAuth API: Walkthrough</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? AccessToken { get; init; }

    /// <summary>
    /// The date when access_token expires, in <see href="http://www.iso.org/iso/home/standards/iso8601.htm">ISO 8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_at")]
    [StringLength(48, MinimumLength = 20)]
    public string? ExpiresAt { get; init; }

    /// <summary>
    /// Then OpenID token belonging to this this person. Only present if the
    /// OPENID scope is included in the authorize request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id_token")]
    public string? IdToken { get; init; }

    /// <summary>
    /// The ID of the authorizing merchant's business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    [StringLength(191, MinimumLength = 8)]
    public string? MerchantId { get; init; }

    /// <summary>
    /// __LEGACY FIELD__. The ID of the subscription plan the merchant signed
    /// up for. Only present if the merchant signed up for a subscription during
    /// authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("plan_id")]
    public string? PlanId { get; init; }

    /// <summary>
    /// A refresh token. OAuth refresh tokens are 64 bytes long.
    /// For more information, see <see href="https://developer.squareup.com/docs/oauth-api/how-it-works#oauth-access-token-management">OAuth access token management</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// A boolean indicating the access token is a short-lived access token.
    /// The short-lived access token returned in the response will expire in 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_lived")]
    public bool? ShortLived { get; init; }

    /// <summary>
    /// __LEGACY FIELD__. The ID of a subscription plan the merchant signed up
    /// for. Only present if the merchant signed up for a subscription during authorization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// This value is always _bearer_.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_type")]
    [StringLength(10, MinimumLength = 2)]
    public string? TokenType { get; init; }
}
