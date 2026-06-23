using System.Text.Json;
using StackExchange.Redis;
using System;

namespace Core.Insfrastructure.Caching
{
    public class RedisCacheProvider : ICacheProvider
    {
        private IDatabase Redis;
        ILogger<RedisCacheProvider> logger;
        public RedisCacheProvider(IDatabase _db, ILogger<RedisCacheProvider> _logger)
        {
            Redis = _db;
            logger = _logger;
            //ConfigureRedis();
        }
        //private void ConfigureRedis()
        //{
        //    _db = ConnectionHelper.Connection.GetDatabase();
        //}
        public async Task SaveAsync<T>(string key, T value, TimeSpan expiry)
        {
            await Redis.StringSetAsync(key, JsonSerializer.Serialize(value), expiry).ConfigureAwait(false);
            logger.LogInformation("Data saved to redis cache, key: {key} expiry:{expiry}", key, expiry.TotalSeconds);
        }

        public async Task<T?> GetAsync<T>(string key)
        {
            var data = await Redis.StringGetAsync(key).ConfigureAwait(false);

            if (data.IsNullOrEmpty)
            {
                return default;
            }

            return JsonSerializer.Deserialize<T>(data!);
        }

        public Task<bool> DeleteAsync(string key)
        {
            return Redis.KeyDeleteAsync(key);
        }

        public void Save<T>(string key, T value, TimeSpan expiry)
        {
            Redis.StringSet(key, JsonSerializer.Serialize(value), expiry);
            logger.LogInformation("Data saved to redis cache, key: {key} expiry:{expiry}", key, expiry.TotalSeconds);
        }

        public T? Get<T>(string key)
        {
            var data = Redis.StringGet(key);

            if (data.IsNullOrEmpty)
            {
                return default;
            }

            return JsonSerializer.Deserialize<T>(data!);
        }

        public bool Delete(string key)
        {
            return Redis.KeyDelete(key);
        }
    }
}
