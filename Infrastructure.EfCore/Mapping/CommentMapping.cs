using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damain.Comment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EfCore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Massage);
            builder.Property(x => x.status);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.Name);

            builder.HasOne(x => x.Article)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.ArticleId);
        }
    }
}