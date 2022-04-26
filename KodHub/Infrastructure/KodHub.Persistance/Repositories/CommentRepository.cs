using KodHub.Application.Interfaces.Repositories;
using KodHub.Domain.Entities;
using KodHub.Persistance.Contexts;
using KodHub.Persistance.Repositories.Common;

namespace KodHub.Persistance.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(KodHubContext context) : base(context)
        {
        }
    }
}
