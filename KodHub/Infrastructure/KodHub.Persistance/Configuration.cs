using Microsoft.Extensions.Configuration;

namespace KodHub.Persistance
{
    static class Configuraiton
    {
        static public string ConnectionString()
        {
            ConfigurationManager cm = new();
            cm.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/KodHub.UI"));
            cm.AddJsonFile("appsettings.json");
            return cm.GetConnectionString("PostreSql");
        }
    }
}
