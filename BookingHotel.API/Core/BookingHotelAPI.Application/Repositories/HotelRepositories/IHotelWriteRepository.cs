using BookingHotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelAPI.Application.Repositories.HotelRepositories
{
    public interface IHotelWriteRepository : IWriteRepository<Hotel>
    {
    }
}
