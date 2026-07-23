using SquareConnectApi.Core;
using SquareConnectApi.Core.Authentication;
using SquareConnectApi.Core.Authentication.ApiKey;
using SquareConnectApi.Core.Authentication.OAuth2;
using SquareConnectApi.Core.Authentication.OAuth2.AuthorizationCode;

namespace SquareConnectApi;

internal sealed class AuthSchemes
{
    public IAuthScheme Oauth2ClientSecret { get; }
    public IAuthScheme Oauth2 { get; }

    public AuthSchemes(SquareConnectApiClientOptions options,
        Server server,
        RawClient rawClient,
        UriFactory urlFactory)
    {
        Oauth2ClientSecret = ApiKeyHeaderScheme.Create("Authorization", options.Oauth2ClientSecret);
        Oauth2 =
            OAuth2RefreshableScheme<OAuth2AuthorizationCodeCredentials>.Create(options.Oauth2,
                options.Oauth2TokenStrategy ??
                    OAuth2AuthorizationCodeStrategy.ForBasicAuthRequest(server.Default("/oauth2/authorize"),
                        server.Default("/oauth2/token"),
                        rawClient,
                        urlFactory));
    }
}
