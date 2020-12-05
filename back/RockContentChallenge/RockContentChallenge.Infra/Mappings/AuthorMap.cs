using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RockContentChallenge.Domain.Entities;

namespace RockContentChallenge.Infra.Mappings
{
    internal class AuthorMap : BaseClassMap<Author>
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            base.Configure(builder);
            builder.ToTable("Author");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100).HasColumnName("Name").HasColumnType("varchar");
        }
    }
}
