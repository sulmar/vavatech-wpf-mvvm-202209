using Bogus;
using Domain.Models;
using Domain.Repositories;

namespace Infrastructure
{
    public abstract class FakeEntityRepository<TEntity> : IEntityRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly ICollection<TEntity> entities;

        public FakeEntityRepository(Faker<TEntity> faker)
        {
            entities = faker.Generate(100);
        }

        public ICollection<TEntity> Get()
        {
            return entities;
        }
    }


}