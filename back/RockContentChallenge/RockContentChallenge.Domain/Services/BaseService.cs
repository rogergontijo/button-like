using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Domain.Interfaces.Services;
using System;

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

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
