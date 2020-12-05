using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace RockContentChallenge.Domain.Services
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity>
        where TEntity : BaseClass
    {
        private readonly IBaseRepository<TEntity> _repository;
        
        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<TEntity> GetByIdAsync(Guid guid)
        {
            return await Task.Run(() => _repository.GetByIdAsync(guid));
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _repository.UpdateAsync(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
