using System.Collections.Generic;
using Application.Contract;
using Damain;
using Infrastructure.EfCore.Repository;


namespace Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidationService _articleCategoryValidationService;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidationService articleCategoryValidationService)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _articleCategoryValidationService = articleCategoryValidationService;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _articleCategoryRepository.ReadAll();
            var result = new List<ArticleCategoryViewModel>();

            foreach (var articleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel()
                {
                    Id = articleCategory.Id,
                    IsDeleted = articleCategory.IsDeleted,
                    Title = articleCategory.Title,
                    CreationDate = articleCategory.CreationDateTime.ToString()
                });
            }

            return result;
        }

        public void Add(ArticleCategoryCreate articleCategoryCreate)
        {
            var articlecategory = new ArticleCategory(articleCategoryCreate.Title, _articleCategoryValidationService);
            _articleCategoryRepository.Create(articlecategory);
        }

        public void Update(ArticleCategoryUpdate articleCategoryUpdate)
        {
            var articleCategory = _articleCategoryRepository.Read(articleCategoryUpdate.Id);
            articleCategory.RenameTitle(articleCategoryUpdate.Title);
            _articleCategoryRepository.Save();
        }


        public ArticleCategory Read(int Id)
        {
            return _articleCategoryRepository.Read(Id);
        }

        public void Delete(int Id)
        {
            var articleCategory = _articleCategoryRepository.Read(Id);
            articleCategory.Remove();
            _articleCategoryRepository.Save();
        }

        public void Activate(int Id)
        {
            var articlecategory = _articleCategoryRepository.Read(Id);
            articlecategory.Activate();
            _articleCategoryRepository.Save();
        }

    }
}
