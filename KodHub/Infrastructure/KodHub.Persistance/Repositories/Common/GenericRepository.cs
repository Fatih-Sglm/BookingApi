using KodHub.Application.Interfaces.Repositories.Common;
using KodHub.Domain.Entities.Common;
using KodHub.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace KodHub.Persistance.Repositories.Common
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly KodHubContext _context;

        public GenericRepository(KodHubContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);

            //EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            //return entityEntry.State == EntityState.Added;

        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }


}
