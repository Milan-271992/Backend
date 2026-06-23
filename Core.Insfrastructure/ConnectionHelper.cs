//using StackExchange.Redis;

//namespace Core.Insfrastructure
//{
//    public class ConnectionHelper
//    {
//        static ConnectionHelper()
//        {

//            ConfigurationManager configuration = new ConfigurationManager();
//            lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
//            {
//                return ConnectionMultiplexer.Connect(ConfigurationManger.AppSetting["RedisURL"]);
//                //return ConnectionMultiplexer.Connect("192.168.100.45:6379,keepAlive=180", null);
//            });
//        }
//        private static Lazy<ConnectionMultiplexer> lazyConnection;
//        public static ConnectionMultiplexer Connection
//        {
//            get
//            {
//                return lazyConnection.Value;
//            }
//        }
//    }
//}
