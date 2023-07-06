using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.StaticsString
{
    public  class StaticString
    {
        private readonly IConfigurationRoot configuration;

        public StaticString(IConfigurationRoot configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public static string connectionString { get; set; }
    }
}
