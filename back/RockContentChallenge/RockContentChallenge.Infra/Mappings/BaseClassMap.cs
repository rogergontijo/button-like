using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RockContentChallenge.Domain.Entities;

namespace RockContentChallenge.Infra.Mappings
{
    internal class BaseClassMap<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseClass
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(p => p.Guid);
            builder.Property(p => p.Guid).IsRequired().HasColumnName("Guid").HasColumnType("uniqueidentifier");
            builder.Property(p => p.CreateDate).IsRequired().HasColumnName("CreateDate").HasColumnType("datetime2");
        }
    }
}
