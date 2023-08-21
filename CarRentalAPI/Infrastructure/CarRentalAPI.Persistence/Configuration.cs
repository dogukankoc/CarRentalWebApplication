using Microsoft.Extensions.Configuration;

namespace CarRentalAPI.Persistence
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                //Use ConfigurationManager Library for Static Files
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/CarRentalAPI.WebAPI/"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MSSQLServer");
            }
        }
    }
}
