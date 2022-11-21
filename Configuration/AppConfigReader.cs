using Mihai_M_P1.Interfaces;
using Mihai_M_P1.Settings;
using System.Configuration;


namespace Mihai_M_P1.Configuration
{
    public class AppConfigReader : IConfig
    {
        BrowserType IConfig.GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        string IConfig.GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Pass);
        }

        string IConfig.GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.User);
        }
    }
}
