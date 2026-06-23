namespace Core.Insfrastructure.Caching
{
    public class CacheManager
    {
        IEnumerable<ICacheProvider> cacheProviders;
        ILogger<CacheManager> logger;       
        public CacheManager(IEnumerable<ICacheProvider> _cacheProviders, ILogger<CacheManager> _logger)
        {
            this.cacheProviders = _cacheProviders;
            this.logger = _logger;
        }
        public async Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> getFromDbFunction, TimeSpan expiry)
        {
            foreach (var cacheProvider in cacheProviders)
            {
                logger.LogInformation("Try to get value from cache: {key} in {cacheProvider}", key, cacheProvider.GetType().Name);
                var cachedValue = await cacheProvider.GetAsync<T>(key).ConfigureAwait(false);

                if (cachedValue != null)
                {
                    logger.LogInformation("*****> HIT for {key} in {cacheProvider}", key, cacheProvider.GetType().Name);
                    return cachedValue;
                }
                else
                    logger.LogInformation("----->Cache wasn't hit for {key} in {cacheProvider}", key, cacheProvider.GetType().Name);
            }

            logger.LogInformation("====> Not found in any cache: {key}", key);

            var result = await getFromDbFunction().ConfigureAwait(false);

            var providerList = cacheProviders.ToList();
            for (int i = 0; i < providerList.Count; i++)
            {
                var expirySeconds = (i * 2 == 0 ? 1 : i * 2) * expiry.TotalSeconds;

                await providerList[i].SaveAsync(key, result, TimeSpan.FromSeconds(expirySeconds)).ConfigureAwait(false);
            }

            return result;
        }

        public async Task DeleteAsync(string key)
        {
            foreach (var cacheProvider in cacheProviders)
            {
                await cacheProvider.DeleteAsync(key).ConfigureAwait(false);
            }
        }
        public T GetOrAdd<T>(string key, Func<T> getFromDbFunction, TimeSpan? expiry =null)
        {
            ConfigurationManger ConfigurationManger = new ConfigurationManger();
            int cacheTimeHours = ConfigurationManger.AppSetting.GetValue<int>("CacheTime");
            foreach (var cacheProvider in cacheProviders)
            {
                logger.LogInformation("Try to get value from cache: {key} in {cacheProvider}", key, cacheProvider.GetType().Name);
                var cachedValue = cacheProvider.Get<T>(key);

                if (cachedValue != null)
                {
                    logger.LogInformation("*****> HIT for {key} in {cacheProvider}", key, cacheProvider.GetType().Name);
                    return cachedValue;
                }
                else
                    logger.LogInformation("----->Cache wasn't hit for {key} in {cacheProvider}", key, cacheProvider.GetType().Name);
            }

            logger.LogInformation("====> Not found in any cache: {key}", key);

            var result = getFromDbFunction();
            foreach (var cacheProvider in cacheProviders)
            {
                //var expirySeconds = (i * 2 == 0 ? 1 : i * 2) * expiry.TotalSeconds;
                if (!expiry.HasValue || expiry.Value == TimeSpan.Zero)
                {
                    
                    cacheProvider.Save(key, result, TimeSpan.FromSeconds(TimeSpan.FromHours(cacheTimeHours).TotalSeconds));
                }
                else
                {
                    cacheProvider.Save(key, result, TimeSpan.FromSeconds(expiry.Value.TotalSeconds));
                }
               
            }
            return result;
        }
        public void Delete(string key)
        {
            foreach (var cacheProvider in cacheProviders)
            {
                cacheProvider.Delete(key);
            }
        }
    }
}
