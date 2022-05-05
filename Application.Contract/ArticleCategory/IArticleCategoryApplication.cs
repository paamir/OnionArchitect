using System.Collections.Generic;
using Damain;

namespace Application.Contract
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();

        void Add(ArticleCategoryCreate articleCategoryCreate);

        void Update(ArticleCategoryUpdate articleCategoryUpdate);

        ArticleCategory Read(int Id);

        void Delete(int Id);
        void Activate(int Id);

    }
}
