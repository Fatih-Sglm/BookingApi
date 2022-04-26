using KodHub.Application.Interfaces.Repositories;
using KodHub.Domain.Entities;
using KodHub.Persistance.Contexts;
using KodHub.Persistance.Repositories.Common;

namespace KodHub.Persistance.Repositories
{
    public class WriterRepository : GenericRepository<Writer>, IWriterRepository
    {
        public WriterRepository(KodHubContext context) : base(context)
        {
        }
    }
}
