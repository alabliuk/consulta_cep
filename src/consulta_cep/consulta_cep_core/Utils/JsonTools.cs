using Microsoft.Extensions.Configuration;
using System.IO;

namespace consulta_cep_core.Utils
{
    class JsonTools
    {
        public IConfigurationRoot ReadTokensAppsettings()
        {
            var builder = new ConfigurationBuilder()
                     .SetBasePath(Directory.GetCurrentDirectory())
                     .AddJsonFile($"appsettings.json");
            var config = builder.Build();
            return config;
        }
    }
}
