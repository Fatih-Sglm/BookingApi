using BookingHotel.API.Persistence.Contexts;
using BookingHotelAPI.Application.Repositories.Room_TypesRepositories;
using BookingHotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotel.API.Persistence.Repositories.Room_TypeServices
{
    public class RoomTypeWriteRepository : WriteRepository<Room_Type>, IRoomTypesWriteRepository
    {
        public RoomTypeWriteRepository(BookingHotelAPIDbContext ct) : base(ct)
        {
        }
    }
}
