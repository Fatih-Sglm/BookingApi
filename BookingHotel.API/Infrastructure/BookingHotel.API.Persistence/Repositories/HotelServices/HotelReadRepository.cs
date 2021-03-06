using BookingHotel.API.Persistence.Contexts;
using BookingHotelAPI.Application.Repositories.HotelRepositories;
using BookingHotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotel.API.Persistence.Repositories.HotelServices
{
    public class HotelReadRepository : ReadRepository<Hotel>, IHotelReadRepository
    {
        public HotelReadRepository(BookingHotelAPIDbContext ct) : base(ct)
        {
        }
    }
}
