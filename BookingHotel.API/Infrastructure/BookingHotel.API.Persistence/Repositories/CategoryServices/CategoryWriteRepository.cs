using BookingHotel.API.Persistence.Contexts;
using BookingHotelAPI.Application.Repositories.CategoryRepositories;
using BookingHotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotel.API.Persistence.Repositories.CategoryServices
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(BookingHotelAPIDbContext ct) : base(ct)
        {
        }
    }
}
