using BookingHotelAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHotelAPI.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);

        bool RemoveRange(List<T> entities);
        bool Remove(T entity);
        Task<bool> RemoveAsync(string id);
        bool Update(T entity);

        Task<int> SaveAsync();
    }
}
