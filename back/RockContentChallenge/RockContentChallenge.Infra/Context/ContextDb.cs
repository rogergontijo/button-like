using Microsoft.EntityFrameworkCore;
using RockContentChallenge.Domain.Entities;
using RockContentChallenge.Infra.Mappings;

namespace RockContentChallenge.Infra.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Article> Authors { get; set; }

        public ContextDb(DbContextOptions<ContextDb> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new AuthorMap());
        }
    }
}
