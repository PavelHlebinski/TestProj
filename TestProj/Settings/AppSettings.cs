using Microsoft.Extensions.Configuration;

namespace TestProj.Settings
{
    internal class AppSettings
    {
        private static IConfiguration InitConfiguration() => new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public static string ReadSettings(string settingName) => InitConfiguration()[settingName];
    }
}