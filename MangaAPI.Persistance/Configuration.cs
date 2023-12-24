using Microsoft.Extensions.Configuration;


namespace MangaAPI.Persistance
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                IConfigurationRoot configuration;

                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                configuration = builder.Build();

                return configuration.GetConnectionString("PostgreSQL");
            }
        }
    }
}
