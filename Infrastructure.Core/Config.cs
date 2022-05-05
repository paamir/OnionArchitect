using Application;
using Application.Contract;
using Damain;
using Infrastructure.EfCore;
using Infrastructure.EfCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Application.Contract.Comment;
using Damain.Comment;
using Infrastructure.Query;

namespace Infrastructure.Core
{
    public static class Config
    {
        public static void ServicesConfiquration(IServiceCollection services, string constr)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryValidationService, ArticleCategoryValidationService>();


            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();

            services.AddTransient<IArticleQuery, ArticleQuery>();

            services.AddTransient<ICommentApplication, CommentApplication>();
            services.AddTransient<ICommentRepository, CommentRepository>();

            services.AddDbContext<OAContext>(options =>
            options.UseSqlServer(constr));
        }
    }
}
