using Microsoft.Extensions.Caching.Memory;
using Core.Insfrastructure.CachingData;

namespace Core.Infrastructure.CachingData
{
    public class InMemoryCacheService : ICacheService
    {
        private readonly IMemoryCache _cache;

        public InMemoryCacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public T GetData<T>(string key)
        {
            if (_cache.TryGetValue(key, out T cachedData))
            {
                return cachedData;
            }
            return default;
        }

        public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(expirationTime);

            _cache.Set(key, value, cacheEntryOptions);
            return true;
        }

        public object RemoveData(string key)
        {
            _cache.Remove(key);
            return null; // Since we don't have an equivalent to KeyDelete in MemoryCache, returning null
        }
    }
}
