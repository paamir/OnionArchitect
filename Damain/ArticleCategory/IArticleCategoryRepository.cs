using System.Collections.Generic;

namespace Damain
{
    public interface IArticleCategoryRepository
    {
        void Create(Damain.ArticleCategory articleCategory);
        void Save();
        List<Damain.ArticleCategory> ReadAll();

        Damain.ArticleCategory Read(int Id);
        // void Delete(Domain.ArticleCategory entity);

        bool Exited(string Title);

    }
}
