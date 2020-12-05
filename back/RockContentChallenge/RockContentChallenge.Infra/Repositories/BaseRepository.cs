using Microsoft.EntityFrameworkCore;
using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Infra.Context;

namespace RockContentChallenge.Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseClass
    {
        protected readonly ContextDb _context;

        public BaseRepository(ContextDb context)
        {
            _context = context;
        }       

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
