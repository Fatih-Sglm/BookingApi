using KodHub.Application.Interfaces.Repositories.Common;
using KodHub.Domain.Entities.Common;

namespace KodHub.Application.Interfaces.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity, new();

        Task SaveAsync();
    }
}
