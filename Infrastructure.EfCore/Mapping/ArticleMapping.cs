using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EfCore.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(25);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.ArticleCategory).
                WithMany(x => x.Article).
                HasForeignKey(x => x.ArticleCategoryId);
        }
    }
}