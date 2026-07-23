using SquareConnectApi.Core.Authentication.OAuth2;
using SquareConnectApi.Core.Authentication.OAuth2.AuthorizationCode;
using SquareConnectApi.Core.Configuration;
using SquareConnectApi.Servers;

namespace SquareConnectApi;

public class SquareConnectApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public ServerOptions Server { get; set; } = new();
    public OAuth2AuthorizationCodeCredentials? Oauth2 { get; set; }
    public IOAuth2RefreshableTokenStrategy<OAuth2AuthorizationCodeCredentials>? Oauth2TokenStrategy { get; set; }
    public string? Oauth2ClientSecret { get; set; }
}
