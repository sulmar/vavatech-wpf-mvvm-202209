using Domain.Models;

namespace Domain.Repositories
{
    // Interfejs generyczny (szablon)
    public interface IEntityRepository<TEntity>
        where TEntity : BaseEntity
    {
        ICollection<TEntity> Get();
    }


}
