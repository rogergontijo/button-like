using Microsoft.EntityFrameworkCore;
using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Domain.Interfaces.Repositories;
using RockContentChallenge.Infra.Context;
using System;
using System.Threading.Tasks;

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

        public async Task<TEntity> GetByIdAsync(Guid guid)
        {
            return await _context.Set<TEntity>().FindAsync(guid);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
