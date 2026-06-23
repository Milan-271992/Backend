namespace Core.Insfrastructure.Caching
{
    public interface ICacheProvider
    {
        Task SaveAsync<T>(string key, T value, TimeSpan expiry);

        Task<T?> GetAsync<T>(string key);

        Task<bool> DeleteAsync(string key);

        void Save<T>(string key, T value, TimeSpan expiry);

        T? Get<T>(string key);

        bool Delete(string key);
    }
}
