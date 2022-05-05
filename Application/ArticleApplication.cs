using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Contract;
using Damain;


namespace Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public ArticleApplication(IArticleRepository articleRepository, IArticleCategoryApplication articleCategoryApplication)
        {
            _articleRepository = articleRepository;
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void Create(ArticleCreate articleCreate)
        {
            var article = new Article(
                articleCreate.Title,
                articleCreate.ShortDescription,
                articleCreate.Image,
                articleCreate.Content,
                articleCreate.ArticleCategoryId);
            _articleRepository.Create(article);
        }

        public void Delete(int articleId)
        {
            var article = _articleRepository.Read(articleId);
            article.Delete();
            _articleRepository.Save();
        }

        public List<ArticleViewModel> ReadAll()
        {
            var Articles = _articleRepository.ReadAll();
            List<ArticleViewModel> articleViewModels = new List<ArticleViewModel>();
            foreach (var result in Articles)
            {
                articleViewModels.Add(new ArticleViewModel()
                {
                    Id = result.Id,
                    IsDeleted = result.IsDeleted,
                    Content = result.Content,
                    ShortDescription = result.ShortDescription,
                    Image = result.Image,
                    ArticleCategoryId = result.ArticleCategoryId,
                    CreationDateTime = result.CreationDateTime.ToString(),
                    Title = result.Title
                });
            }

            return articleViewModels;
        }

        public ArticleViewModel Read(int Id)
        {
            var article = _articleRepository.Read(Id);
            return new ArticleViewModel()
            {
                Id = article.Id,
                Title = article.Title,
                IsDeleted = article.IsDeleted,
                Content = article.Content,
                ShortDescription = article.ShortDescription,
                Image = article.Image,
                CreationDateTime = article.CreationDateTime.ToString(),
                ArticleCategoryId = article.ArticleCategoryId
            };
        }

        public void Activate(int id)
        {
            var article = _articleRepository.Read(id);
            article.Activate();
            _articleRepository.Save();
        }

        public void Edit(ArticleEdit articleEdit)
        {
            var Article = _articleRepository.Read(articleEdit.Id);

            Article.Edit
            (
                articleEdit.Title,
                articleEdit.ShortDescription,
                articleEdit.Image,
                articleEdit.Content,
                articleEdit.ArticleCategoryId
            );
            _articleRepository.Save();
        }
    }
}