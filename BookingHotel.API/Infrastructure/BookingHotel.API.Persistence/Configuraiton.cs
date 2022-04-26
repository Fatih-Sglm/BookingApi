using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotel.API.Persistence
{
    static class Configuraiton
    {
        static public string ConnectionString()
        {
            ConfigurationManager cm = new();
            cm.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/BookingHotel.API.API"));
            cm.AddJsonFile("appsettings.json");
            return cm.GetConnectionString("PostreSql");
        }
    }
}
