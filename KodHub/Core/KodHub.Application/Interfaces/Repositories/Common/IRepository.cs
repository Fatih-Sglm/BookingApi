using KodHub.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KodHub.Application.Interfaces.Repositories.Common
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        DbSet<T> Table { get; }
        Task<T> GetByIdAsync(string id);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        void Remove(T entity);
        Task RemoveAsync(string id);
        void Update(T entity);

    }
}
