using Domain.Models;
using Domain.Repositories;

namespace ViewModels
{
    public class EntitiesViewModel<TEntity> : BaseViewModel
        where TEntity : BaseEntity
    {
        public ICollection<TEntity> Entities { get; set; }

        public EntitiesViewModel(IEntityRepository<TEntity> entityRepository)
        {
            Entities = entityRepository.Get();
        }
    }
}
