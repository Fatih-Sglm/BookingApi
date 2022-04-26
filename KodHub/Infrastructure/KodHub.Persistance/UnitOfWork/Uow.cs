using KodHub.Application.Interfaces.Repositories.Common;
using KodHub.Application.Interfaces.UnitOfWork;
using KodHub.Domain.Entities.Common;
using KodHub.Persistance.Contexts;
using KodHub.Persistance.Repositories.Common;

namespace KodHub.Persistance.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly KodHubContext _context;

        public Uow(KodHubContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity, new()
        {
            return new GenericRepository<T>(_context);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
