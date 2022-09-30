using Microsoft.Extensions.Configuration;

namespace YukselenWebAPI.DAL
{
    public class Configuration
    {
        static public string ConfigurationString
        {
            get
            {

                ConfigurationManager configurationManager = new();
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("SqlServer");
            }
        }
    }
}
