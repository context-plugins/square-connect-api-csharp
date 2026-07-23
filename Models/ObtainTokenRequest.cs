using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record ObtainTokenRequest
{
    /// <summary>
    /// The Square-issued ID of your application, available from the
    /// <see href="https://developer.squareup.com/apps">developer dashboard</see>.
    /// </summary>
    [JsonPropertyName("client_id")]
    [MaxLength(191)]
    public required string ClientId { get; init; }

    /// <summary>
    /// The Square-issued application secret for your application, available
    /// from the <see href="https://developer.squareup.com/apps">developer dashboard</see>.
    /// </summary>
    [JsonPropertyName("client_secret")]
    [StringLength(1024, MinimumLength = 2)]
    public required string ClientSecret { get; init; }

    /// <summary>
    /// The authorization code to exchange.
    /// This is required if <c>grant_type</c> is set to <c>authorization_code</c>, to indicate that
    /// the application wants to exchange an authorization code for an OAuth access token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    [StringLength(191, MinimumLength = 0)]
    public string? Code { get; init; }

    /// <summary>
    /// Specifies the method to request an OAuth access token.
    /// Valid values are: <c>authorization_code</c>, <c>refresh_token</c>, and <c>migration_token</c>
    /// </summary>
    [JsonPropertyName("grant_type")]
    [StringLength(20, MinimumLength = 10)]
    public required string GrantType { get; init; }

    /// <summary>
    /// Legacy OAuth access token obtained using a Connect API version prior
    /// to 2019-03-13. This parameter is required if <c>grant_type</c> is set to
    /// <c>migration_token</c> to indicate that the application wants to get a replacement
    /// OAuth access token. The response also returns a refresh token.
    /// For more information, see <see href="https://developer.squareup.com/docs/oauth-api/migrate-to-refresh-tokens">Migrate to Using Refresh Tokens</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migration_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? MigrationToken { get; init; }

    /// <summary>
    /// The redirect URL assigned in the <see href="https://developer.squareup.com/apps">developer dashboard</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_uri")]
    [StringLength(2048, MinimumLength = 0)]
    public string? RedirectUri { get; init; }

    /// <summary>
    /// A valid refresh token for generating a new OAuth access token.
    /// A valid refresh token is required if <c>grant_type</c> is set to <c>refresh_token</c> , to indicate the application wants a replacement for an expired OAuth access token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refresh_token")]
    [StringLength(1024, MinimumLength = 2)]
    public string? RefreshToken { get; init; }

    /// <summary>
    /// A JSON list of strings representing the permissions the application is requesting.
    /// For example: "<c>["MERCHANT_PROFILE_READ","PAYMENTS_READ","BANK_ACCOUNTS_READ"]</c>"
    /// The access token returned in the response is granted the permissions
    /// that comprise the intersection between the requested list of permissions, and those
    /// that belong to the provided refresh token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scopes")]
    public IReadOnlyList<string>? Scopes { get; init; }

    /// <summary>
    /// A boolean indicating a request for a short-lived access token.
    /// The short-lived access token returned in the response will expire in 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_lived")]
    public bool? ShortLived { get; init; }
}
