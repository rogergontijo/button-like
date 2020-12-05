using Microsoft.EntityFrameworkCore;
using RockContentChallenge.Domain.Entities;

namespace RockContentChallenge.Infra.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public ContextDb(DbContextOptions<ContextDb> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
