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
    public class ArticleCategoryMapping : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> ArticleCategory)
        {
            ArticleCategory.ToTable("ArticleCategories");

            ArticleCategory.HasKey(x => x.Id);

            ArticleCategory.ToTable("ArticleCategories");

            ArticleCategory.HasKey(x => x.Id);
            ArticleCategory.Property(x => x.Title).IsRequired().HasMaxLength(25);
            ArticleCategory.Property(x => x.CreationDateTime);
            ArticleCategory.Property(x => x.IsDeleted);

            ArticleCategory.HasMany(x => x.Article).
                WithOne(x => x.ArticleCategory).
                HasForeignKey(x => x.ArticleCategoryId);


        }
    }
}
