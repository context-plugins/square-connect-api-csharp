using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;

namespace SquareConnectApi;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddSquareConnectApiClient(Action<SquareConnectApiClientOptions>? configure = null)
        {
            var options = new SquareConnectApiClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddSingleton(sp =>
                {
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new SquareConnectApiClient(httpClient, options);
                });
            return services;
        }
    }
}
