using System.Reflection;

namespace Core.Insfrastructure
{
    public class ConfigurationManger
    {
        public IConfiguration AppSetting
        {
            get;
        }
      public  ConfigurationManger()
        {
            AppSetting = new ConfigurationBuilder().SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).AddJsonFile($"Config/sharedAppsettings.json", optional: true, reloadOnChange: true).Build();
        }
    }
}
