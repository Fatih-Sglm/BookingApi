using BookingHotelAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelAPI.Application.Repositories
{
    public interface IReadRepository<T> :IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool trancking = true);
        Task<T> GetByIdAsync(string id, bool trancking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool trancking = true);
        Task<T> GetSingleAsync (Expression<Func<T, bool>> expression , bool trancking = true);
    }
}
