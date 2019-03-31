using System.Collections.Generic;
using System.Threading.Tasks;

namespace SC.Core.Repository
{
    public interface IReadOnlyRepository<TEntity>
    {
        Task<TEntity> FindById(object id);
        Task<IReadOnlyCollection<TEntity>> List();
    }
}