using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace BaseBusiness.util
{
    public interface IConfigManager
    {
        string DBConnection { get; }
        string GetConnectionString(string connectionName);
        IConfigurationSection GetConfigurationSection(string key);
    }

    public class ConfigManager : IConfigManager
    {
        private readonly IConfiguration _configuration;

        public ConfigManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string DBConnection => _configuration.GetConnectionString("DefaultConnection");

        public IConfigurationSection GetConfigurationSection(string key)
        {
            return _configuration.GetSection(key);
        }

        public string GetConnectionString(string connectionName)
        {
            return _configuration.GetConnectionString(connectionName);
        }
    }

    public class AppConfiguration
    {
        private readonly IConfigurationRoot _configuration;

        public AppConfiguration()
        {
            var builder = new ConfigurationBuilder();

            builder.Sources.Add(new JsonConfigurationSource
            {
                Path = "appsettings.json",
                Optional = false,
                ReloadOnChange = true
            });

            _configuration = builder.Build();
        }

        public string ConnectionString => _configuration["ConnectionStrings:DefaultConnection"] ?? string.Empty;
        public string FastConnectionString => _configuration["ConnectionStrings:FastConnection"] ?? string.Empty;

        public string LoginCount => _configuration["ConnectionStrings:LoginMaxCount"];

    }
}
