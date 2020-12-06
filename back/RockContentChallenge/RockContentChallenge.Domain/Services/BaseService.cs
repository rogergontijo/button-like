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
            try
            {
                return await _repository.GetByIdAsync(guid);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            try
            {
                ValidateBeforeUpdate(entity);
                await _repository.UpdateAsync(entity); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }        

        public void Dispose()
        {
            _repository.Dispose();
        }

        private void ValidateBeforeUpdate(TEntity entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity cannot be null.");
            }

            if (entity.Guid == null || entity.Guid == Guid.Empty)
            {
                throw new Exception("Non-existent entity.");
            }
        }
    }
}
