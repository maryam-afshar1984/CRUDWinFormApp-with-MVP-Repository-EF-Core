using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NorthwindWinFormsApp.Configuration
{
    public static class ConfigurationManager
    {
        public static AppConfig LoadConfiguration()
        {
            // Get the base directory of the executable
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the relative path to the config file
            string configFilePath = Path.Combine(baseDirectory, "config.json");

            if (!File.Exists(configFilePath))
            {
                throw new FileNotFoundException("Configuration file not found.", configFilePath);
            }

            string json = File.ReadAllText(configFilePath);
            return JsonConvert.DeserializeObject<AppConfig>(json);
        }
    }
}
