using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RenewTokenResponse
{
    /// <summary>
    /// The renewed access token.
    /// This value might be different from the <c>access_token</c> you provided in your request.
    /// You provide this token in a header with every request to Connect API endpoints.
    /// See <see href="https://developer.squareup.com/docs/api/connect/v2/#requestandresponseheaders">Request and response headers</see> for the format of this header.
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
    /// __LEGACY FIELD__. The ID of the merchant subscription associated with
    /// the authorization. Only present if the merchant signed up for a subscription
    /// during authorization..
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
