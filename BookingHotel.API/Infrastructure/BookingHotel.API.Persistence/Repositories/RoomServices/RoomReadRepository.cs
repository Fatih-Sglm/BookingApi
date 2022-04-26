using BookingHotel.API.Persistence.Contexts;
using BookingHotelAPI.Application.Repositories.RoomRepositories;
using BookingHotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotel.API.Persistence.Repositories.RoomServices
{
    public class RoomReadRepository : ReadRepository<Room>, IRoomReadRepository
    {
        public RoomReadRepository(BookingHotelAPIDbContext ct) : base(ct)
        {
        }
    }
}
