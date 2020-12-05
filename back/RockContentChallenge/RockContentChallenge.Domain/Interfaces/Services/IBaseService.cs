using System;
using System.Threading.Tasks;

namespace RockContentChallenge.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid guid);
        Task UpdateAsync(TEntity entity);
        void Dispose();
    }
}
