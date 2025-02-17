﻿using JOSHttpClient.Common;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace JOSHttpClient.Version6
{
    public static class Version6Configurator
    {
        public static void AddVersion6(this IServiceCollection services)
        {
            services.AddSingleton<GetAllProjectsQuery>();
            services.AddHttpClient<GitHubClient>("GitHubClient.Version6", HttpClientSetting.SetDefaults)
                .ConfigurePrimaryHttpMessageHandler(HttpClientSetting.ConfigureHandler);
            services.AddSingleton<GitHubClientFactory>();
            services.AddSingleton<JsonSerializer>();
        }
    }
}
