using System.Collections.Generic;
using System.Linq;
using Damain.Comment;
using Infrastructure.EfCore;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly OAContext _context;

        public ArticleQuery(OAContext context)
        {
            _context = context;
        }

        public List<ArticleQueryModel> ReadAll()
        {
            return _context.Articles.ToList().Where(x => x.IsDeleted == false).Select(x => new ArticleQueryModel()
            {
                Id = x.Id, ArticleCategoryId = x.ArticleCategoryId, CreationDateTime = x.CreationDate.ToString(),
                Image = x.Image, ShortDescription = x.ShortDescription, Title = x.Title
            }).ToList();
        }

        public ArticleDetailQuery Read(int Id)
        {
            var article = _context.Articles.FirstOrDefault(x => x.Id == Id);
            var Comments = _context.Comments.Where(x => x.ArticleId == article.Id && x.status == Statuses.Confirm).ToList();
            return new ArticleDetailQuery()
            {
                Id = article.Id, Title = article.Title, Image = article.Image,
                ArticleCategoryId = article.ArticleCategoryId,
                Content = article.Content, ShortDescription = article.ShortDescription,
                CreationDateTime = article.ShortDescription.ToString(), ArticleCategory = article.ArticleCategory,Comments = Comments,CommentCount = Comments.Count
            };
        }
    }
}