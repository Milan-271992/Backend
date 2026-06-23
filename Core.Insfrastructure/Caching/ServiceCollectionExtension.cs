using Core.Insfrastructure;
using StackExchange.Redis;
namespace Core.Insfrastructure.Caching
{
    public static class ServiceCollectionExtension
    {
        public static void AddCacheServices(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigurationManger ConfigurationManger = new ConfigurationManger();
            string allowedCacheProvider = ConfigurationManger.AppSetting["Caching:CacheProvider"];
            if (!string.IsNullOrEmpty(allowedCacheProvider))
            {
                allowedCacheProvider = allowedCacheProvider.ToLower();
                if (allowedCacheProvider == "redis")
                {
                    services.AddScoped<ICacheProvider, RedisCacheProvider>();
                    var redisConnection = ConfigurationManger.AppSetting["Caching:RedisURL"];

                    var redisOptions = ConfigurationOptions.Parse(redisConnection!);

                    services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(redisOptions));

                    services.AddScoped<IDatabase>(provider => provider.GetRequiredService<IConnectionMultiplexer>().GetDatabase());
                }
                else if (allowedCacheProvider == "inmemory")
                {
                    services.AddMemoryCache();
                    services.AddScoped<ICacheProvider, InMemoryCacheProvider>();
                }
                services.AddScoped<CacheManager>();
            }
            else
            {
                services.AddScoped<CacheManager>();
            }
            //string allowedCacheProvider = ConfigurationManger.AppSetting["Caching:CacheProvider"].ToString().ToLower();
        }
    }
}
