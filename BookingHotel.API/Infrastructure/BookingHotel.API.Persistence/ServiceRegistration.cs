using BookingHotel.API.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BookingHotel.API.Persistence.Repositories.CategoryServices;
using BookingHotelAPI.Application.Repositories.CategoryRepositories;
using BookingHotel.API.Persistence.Repositories.HotelServices;
using BookingHotelAPI.Application.Repositories.RoomRepositories;
using BookingHotel.API.Persistence.Repositories.RoomServices;
using BookingHotelAPI.Application.Repositories.Room_TypesRepositories;
using BookingHotel.API.Persistence.Repositories.Room_TypeServices;
using BookingHotelAPI.Application.Repositories.HotelRepositories;

namespace BookingHotel.API.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<BookingHotelAPIDbContext>(options => options.UseNpgsql(Configuraiton.ConnectionString()));
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<IRoomReadRepository, RoomReadRepository>();
            services.AddScoped<IRoomWriteRespository, RoomWriteRepository>();
            services.AddScoped<IRoomTypesReadRepository, RomeTypeReadRepository>();
            services.AddScoped<IRoomTypesWriteRepository, RoomTypeWriteRepository>();
            services.AddScoped<IHotelReadRepository, HotelReadRepository>();
            services.AddScoped<IHotelWriteRepository, HotelWriteRepository>();
       
        }
    }
}
