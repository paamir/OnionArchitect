using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damain;
using Damain.Comment;
using Infrastructure.EfCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EfCore
{
    public class OAContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public OAContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);  // در این دو خط می رود و میبیند تما کلاس های مانند article mapping را پیدا  میکند 
            // modelBuilder.ApplyConfiguration(new ArticleMapping());
            // modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            // modelBuilder.ApplyConfiguration(new CommentMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
