using KodHub.Application.Interfaces.Repositories;
using KodHub.Domain.Entities;
using KodHub.Persistance.Contexts;
using KodHub.Persistance.Repositories.Common;

namespace KodHub.Persistance.Repositories
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(KodHubContext context) : base(context)
        {
        }
    }
}
