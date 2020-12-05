using RockContentChallenge.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace RockContentChallenge.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseClass
    {
        Task<TEntity> GetByIdAsync(Guid guid);
        Task UpdateAsync(TEntity entity);
        void Dispose();
    }
}
