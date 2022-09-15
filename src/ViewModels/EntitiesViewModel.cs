using Domain.Models;
using Domain.Repositories;

namespace ViewModels
{
    public class EntitiesViewModel<TEntity> : BaseViewModel
        where TEntity : BaseEntity
    {
        public ICollection<TEntity> Entities
        {
            get => entities; set
            {
                entities = value;
                OnPropertyChanged();
            }
        }

        protected IEntityRepository<TEntity> entityRepository;
        private ICollection<TEntity> entities;

        public EntitiesViewModel(IEntityRepository<TEntity> entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        public void Load()
        {
            Entities = entityRepository.Get();
        }
    }
}
