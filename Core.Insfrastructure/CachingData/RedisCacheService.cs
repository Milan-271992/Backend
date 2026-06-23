using Newtonsoft.Json;
using StackExchange.Redis;

namespace Core.Insfrastructure.CachingData
{
    public class RedisCacheService : ICacheService
    {
        private IDatabase _db;

        private readonly IConnectionMultiplexer _connectionMultiplexer;
        //public RedisCacheService()
        //{
        //    ConfigureRedis();
        //}

        public RedisCacheService(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer ?? throw new ArgumentNullException(nameof(connectionMultiplexer));
            ConfigureRedis();

        }
        private void ConfigureRedis()
        {
            //_db = ConnectionHelper.Connection.GetDatabase();
            _db = _connectionMultiplexer.GetDatabase();
        }
        public T GetData<T>(string key)
        {
            var db = _connectionMultiplexer.GetDatabase();
            var value = _db.StringGet(key);
            if (!string.IsNullOrEmpty(value))
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default;
        }
        public bool SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            var isSet = _db.StringSet(key, JsonConvert.SerializeObject(value), expiryTime);
            return isSet;
        }
        public object RemoveData(string key)
        {
            bool _isKeyExist = _db.KeyExists(key);
            if (_isKeyExist == true)
            {
                return _db.KeyDelete(key);
            }
            return false;
        }
    }
}
