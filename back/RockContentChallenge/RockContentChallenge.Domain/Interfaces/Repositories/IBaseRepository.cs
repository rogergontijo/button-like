using RockContentChallenge.Domain.Entities;

namespace RockContentChallenge.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseClass
    {
        void Update(TEntity entity);
        void Dispose();
    }
}
