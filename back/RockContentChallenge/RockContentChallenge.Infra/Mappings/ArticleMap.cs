using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RockContentChallenge.Domain.Entities;

namespace RockContentChallenge.Infra.Mappings
{
    internal class ArticleMap : BaseClassMap<Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            base.Configure(builder);
            builder.ToTable("Article");
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100).HasColumnName("Name");
            builder.Property(p => p.Text).IsRequired().HasColumnName("Text");
            builder.Property(p => p.AuthorGuid).IsRequired().HasColumnName("AuthorGuid");
            builder.Property(p => p.AmountLike).IsRequired().HasColumnName("AmountLike");

            //Foreign Key
            builder.HasOne(article => article.Author).WithMany(author => author.Articles).HasForeignKey(article => article.AuthorGuid);
        }
    }
}
