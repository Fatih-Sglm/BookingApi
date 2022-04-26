using BookingHotel.API.Persistence.Contexts;
using BookingHotelAPI.Application.Repositories;
using BookingHotelAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotel.API.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {

        private readonly BookingHotelAPIDbContext _ct;

        public ReadRepository(BookingHotelAPIDbContext ct)
        {
            _ct = ct;
        }

        public DbSet<T> Table => _ct.Set<T>();

        public IQueryable<T> GetAll(bool trancking = true)
        {
            var query = Table.AsQueryable();
            if (!trancking)
                query = query.AsNoTracking();
            return query;
        }
          

        public async Task<T> GetByIdAsync(string id , bool trancking = true)
        {
            var query = Table.AsQueryable();
            if (!trancking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        }



        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool trancking = true)
        {
            var query = Table.AsQueryable();
            if (!trancking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool trancking = true)
        {
            var query = Table.Where(expression);
            if(!trancking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
