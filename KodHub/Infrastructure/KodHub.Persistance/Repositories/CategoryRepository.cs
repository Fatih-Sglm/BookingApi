using KodHub.Application.Interfaces.Repositories;
using KodHub.Domain.Entities;
using KodHub.Persistance.Contexts;
using KodHub.Persistance.Repositories.Common;

namespace KodHub.Persistance.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(KodHubContext context) : base(context)
        {
        }
    }
}
